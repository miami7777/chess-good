
using CG.Models.Enum;
using CG.Models;
using Microsoft.AspNetCore.SignalR;
using CG.Service.Interfaces;

namespace CG.Hubs;
public class ChessHub : Hub
{
    private static readonly List<string> Connections =
           new List<string>();
    private static readonly List<string> DisConnections =
           new List<string>();
    private static  List<Player> Players =
           new List<Player>();
    private static HashSet<Player> Users =
           new HashSet<Player>();
    private Dictionary<string,Player>? Colors;    
    private ICalculationRatingService _calculationRatingService;
    private static List<string> ListWaiting = new List<string>();
    private static string connectionId;    
    private static List<GameState> gameState = new List<GameState>
    {
        { new GameState
            {
                Id = 1,
                IsOngoing = false,
                Fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1",
                Moves = [],
                IsWhiteTurn = true,
                Players = new List<Player>(),
                FenArray = new List<string>(),
                Pgn = ""
            }
        }
    };

    public ChessHub(ICalculationRatingService calculationRatingService)
    {
        _calculationRatingService = calculationRatingService;
    }

    /// <summary>
    /// При подключении сокета
    /// </summary>
    /// <returns></returns>
    public override async Task OnConnectedAsync()
    {
        Connections.Add(Context.ConnectionId);
        if (Context?.User?.Identity?.Name != null)
        {
            var rating = await _calculationRatingService.GetRatingByTypeAsync(Type_Game.Blitz);            
            var join_users = new Player { ConnectionId = Context.ConnectionId, UserName = Context.User.Identity.Name, Rating = rating.ToString() };
            var user = Users.Where(x => x.UserName == Context.User.Identity.Name).FirstOrDefault();
            if (user != null)
            {
                Users.Remove(user);                
            } 
            Users.Add(join_users);            
        }        
        Statistics statistics = new Statistics()
        {
            Connects = Connections,
            gameState = gameState,
            Players = Players,
            Users = Users
        };
        await Clients.All.SendAsync("Statistics", statistics);
        //if (DisConnections.Count > 0)
        //{
        //    var game = gameState.Where(x => x.IsOngoing && DisConnections.Contains(x?.PlayerOngoing?.ConnectionId ?? "")).FirstOrDefault();
        //    var delCOn = game?.PlayerOngoing?.ConnectionId;
        //    if (game != null && delCOn != null)
        //    {
        //        var join_pl = game.PlayerOngoing;
        //        if (join_pl != null && Context != null)
        //        {
        //            join_pl.ConnectionId = Context.ConnectionId;
        //            var player_opponent = game.Players.FirstOrDefault();
        //            if (player_opponent != null)
        //            {
        //                if (game.Colors["white"].UserName == player_opponent.UserName) {
        //                    game.Players.Clear();
        //                  game.Players.AddRange([player_opponent,join_pl]);
        //                }
        //                else
        //                {
        //                    game.Players.Clear();
        //                  game.Players.AddRange([join_pl,player_opponent]);
        //                }                        
        //                game.PlayerOngoing = null;
        //                game.IsOngoing = false;                        
        //                GameMessage gameMessage = new GameMessage() { Type = "Reconnect", UserName = join_pl.UserName, Players = game.Players, gameState = game, games = gameState };
        //                await Clients.Client(Context.ConnectionId).SendAsync("Receive", gameMessage);
        //                GameMessage observerMessage = new GameMessage() { Type = "GetClock" };
        //                await Clients.Client(player_opponent.ConnectionId).SendAsync("Receive", observerMessage);                   

        //                DisConnections.Remove(delCOn);
        //            }
        //        }
        //    }
        //}

        await base.OnConnectedAsync();
    }

    /// <summary>
    /// При отключении сокета
    /// </summary>
    /// <param name="exception"></param>
    /// <returns></returns>
    public override async Task OnDisconnectedAsync(Exception exception)
    {        
        var game = gameState.Where(x => x.Players.Where(x=> x.ConnectionId == Context.ConnectionId).Any()).FirstOrDefault();
        if (game != null)
        {
            game.PlayerOngoing = game.Players.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
            if (game.PlayerOngoing != null)
            {
                game.Players.Remove(game.PlayerOngoing);
            }
            game.IsOngoing = true; 
            var player_opponent = game.Players.FirstOrDefault(x => x.ConnectionId != Context.ConnectionId);
            if (player_opponent != null)
            {
                GameMessage gameMessage = new GameMessage() { Type = "Disconnect", games = gameState };
                await Clients.Client(player_opponent.ConnectionId).SendAsync("Receive", gameMessage);
            };
        }
        var player = Players.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
        if (player != null)
        {
            Players.Remove(player);
        }
        var user = Users.FirstOrDefault(x => x.ConnectionId == Context.ConnectionId);
        if (user != null)
        {
            Users.Remove(user);
        }
        DisConnections.Add(Context.ConnectionId);
        Connections.Remove(Context.ConnectionId);        
        await Clients.All.SendAsync("Statistics", new Statistics {  gameState = gameState, Connects = Connections, Users = Users });
        await base.OnDisconnectedAsync(exception);
    }    
    public async Task Message(GameMessage message)
    {
        if (message.Type == "Join")
        {
            var game = gameState.FirstOrDefault(x => x.Players.Count == 1 && x.Options.min == message.Options.min && x.Options.sec == message.Options.sec && x.Options.add_sec == message.Options.add_sec && x.Options.isRating == message.Options.isRating && (message.Options.color != x.Options.color || message.Options.color == Models.Enums.Color.RndColor || x.Options.color == Models.Enums.Color.RndColor));

            var join_pl = new Player { ConnectionId = Context.ConnectionId, UserName = message.UserName, Options = message.Options };
            Players.Add(join_pl);
            GetTypeGame(message);
            if (join_pl.UserName != null)
            {
                var user = Users.Where(x => x.UserName == Context.User.Identity.Name).FirstOrDefault();
                join_pl.Avatar = 0;
                if (user != null)
                {
                    var avatar = _calculationRatingService.GetAvatarAndFlagAsync(new List<Player> { join_pl, new Player() });
                    var rating = await _calculationRatingService.GetRatingByTypeAsync(message?.Options?.type ?? Type_Game.Blitz);
                    join_pl.Rating = rating.ToString();
                    join_pl.Avatar = avatar.Item1;
                    join_pl.Country = avatar.Item3;
                    Users.Remove(user);
                }
                Users.Add(join_pl);
            }
            if (game == null)
            {
                GetTypeGame(message);
                game = new GameState
                {
                    Id = gameState.Count + 1,
                    IsOngoing = false,
                    Fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1",
                    Moves = [],
                    IsWhiteTurn = true,
                    Players = new List<Player>()
                    {
                       join_pl
                    },
                    FenArray = new List<string>(),
                    Pgn = "",
                    Observers = new List<Player>(),
                    Options = message.Options ?? new Options()
                    {
                        min = 3,
                        sec = 0,
                        add_sec = 0,
                        type = Type_Game.Blitz,
                        isRating = false,
                        color = Models.Enums.Color.RndColor
                    }
                };

                gameState.Add(game);
            }
            var searchPlayers = Players.Where(x => x.ConnectionId != join_pl.ConnectionId && message.Options != null && x.Options.min == message.Options.min && x.Options.sec == message.Options.sec && x.Options.add_sec == message.Options.add_sec && x.Options.isRating == message.Options.isRating && (message.Options.color != x.Options.color || message.Options.color == Models.Enums.Color.RndColor || x.Options.color == Models.Enums.Color.RndColor)).Take(1).ToList();
            if (searchPlayers.Count == 1)
            {
                searchPlayers.Add(join_pl);
                if (searchPlayers[0].Options.color == Models.Enums.Color.White || searchPlayers[1].Options.color == Models.Enums.Color.Black)
                {
                    game.Options.color = Models.Enums.Color.White;
                }
                else if (searchPlayers[1].Options.color == Models.Enums.Color.White || searchPlayers[0].Options.color == Models.Enums.Color.Black)
                {
                    game.Options.color = Models.Enums.Color.Black;
                }
                else
                {
                    game.Options.color = Models.Enums.Color.RndColor;
                }
                var avatars = _calculationRatingService.GetAvatarAndFlagAsync(searchPlayers);
                var rating1 = await _calculationRatingService.GetRatingByTypeAndUserAsync(game.Options.type, searchPlayers[0].UserName);
                var rating2 = await _calculationRatingService.GetRatingByTypeAndUserAsync(game.Options.type, searchPlayers[1].UserName);
                var kf1 = await _calculationRatingService.GetKfPlayer(game, searchPlayers[0].UserName);
                var kf2 = await _calculationRatingService.GetKfPlayer(game, searchPlayers[1].UserName);
                searchPlayers[0].Rating = rating1.ToString();
                searchPlayers[1].Rating = rating2.ToString();
                searchPlayers[0].Avatar = avatars.Item1;
                searchPlayers[1].Avatar = avatars.Item2;
                searchPlayers[0].Country = avatars.Item3;
                searchPlayers[1].Country = avatars.Item4;
                searchPlayers[0].Kf = kf1.ToString();
                searchPlayers[1].Kf = kf2.ToString();
                game.Players.Clear();
                game.Players.AddRange([searchPlayers[0], searchPlayers[1]]);
                await AssignColors(game);
            }
            GameMessage gameMessage = new GameMessage() { Type = "PlayerList", Players = game.Players, gameState = game, games = gameState };
            await Clients.Client(Context.ConnectionId).SendAsync("Receive", gameMessage);
            foreach (Player pl in searchPlayers)
            {
                if (pl.ConnectionId != Context.ConnectionId)
                {
                    await Clients.Client(pl.ConnectionId).SendAsync("Receive", gameMessage);
                }
                if (searchPlayers.Count == 2)
                    Players.Remove(pl);
            }
            await Clients.All.SendAsync("Statistics", new Statistics { gameState = gameState, Connects = Connections, Users = Users });
        }
        else if (message.Type == "Ongoing")
        {
            var game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);

            if (game != null)
            {
                var player_opponent = game.Players.FirstOrDefault(x => x.ConnectionId != Context.ConnectionId);
                if (player_opponent != null)
                {
                    game.Players = message.gameState.Players;
                    GameMessage gameMessage = new GameMessage() { Type = "UpdatePlayerList", Players = game.Players, gameState = game, games = gameState };
                    foreach (var pl in game.Players)
                    {
                        await Clients.Client(pl.ConnectionId).SendAsync("Receive", gameMessage);
                    }
                }
            }
        }
        else if (message.Type == "Accept")
        {
            var game = gameState.FirstOrDefault(x => x.Id == Convert.ToInt32(message.GameId));

            if (game != null)
            {
                if (Context.User?.Identity?.Name == null && !game.Options.isRating)
                {
                    await Clients.Client(Context.ConnectionId).SendAsync("Error", new ErrorHub { Message = "Не авторизованные пользователи не могут принимать рейтинговые вызовы!" });
                }
                else if (Context.User?.Identity?.Name != null && game.Players.FirstOrDefault(x => x.UserName == Context.User?.Identity?.Name) != null)
                {
                    await Clients.Client(Context.ConnectionId).SendAsync("Error", new ErrorHub { Message = "Вы не можете принять свой вызов!" });
                }
                else
                {
                    var join_pl = new Player { ConnectionId = Context.ConnectionId, UserName = message.UserName };
                    Players.Add(join_pl);
                    if (join_pl.UserName != null)
                    {
                        var user = Users.Where(x => x.UserName == Context.User.Identity.Name).FirstOrDefault();
                        if (user != null)
                        {
                            var rating = await _calculationRatingService.GetRatingByTypeAsync(message?.Options?.type ?? Type_Game.Blitz);
                            join_pl.Rating = rating.ToString();
                            Users.Remove(user);
                        }
                        Users.Add(join_pl);
                    }
                    game.Players.Add(join_pl);
                    await AssignColors(game);
                    GameMessage gameMessage = new GameMessage() { Type = "PlayerList", Players = game.Players, gameState = game, games = gameState };
                    foreach (Player pl in game.Players)
                    {
                        await Clients.Client(pl.ConnectionId).SendAsync("Receive", gameMessage);
                        Players.Remove(pl);
                    }
                    await Clients.All.SendAsync("Statistics", new Statistics { gameState = gameState, Connects = Connections, Users = Users });
                }
            }
        }
        else if (message.Type == "Open")
        {
            var game = gameState.FirstOrDefault(x => x.Id == Convert.ToInt32(message.Id));

            if (game != null)
            {
                var user_observer = new Player() { UserName = message.UserName ?? "Гость", ConnectionId = Context.ConnectionId };
                if (!game.Observers.Contains(user_observer))
                    game.Observers.Add(user_observer);

                GameMessage gameMessage = new GameMessage() { Type = "Open", Players = game.Players, gameState = game, games = gameState };
                await Clients.Client(Context.ConnectionId).SendAsync("Receive", gameMessage);
                GameMessage observerMessage = new GameMessage() { Type = "Clock" };
                await Clients.Client(game.Players[0].ConnectionId).SendAsync("Receive", observerMessage);
            }
        }        
        else if (message.Type == "Fen")
        {
            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            foreach (Player pl in game.Players)
            {
                if (pl.ConnectionId != Context.ConnectionId)
                {
                    GameMessage gameMessage = new GameMessage() { Type = "Fen", Fen = message.Fen, games = gameState };
                    await Clients.Client(pl.ConnectionId).SendAsync("Receive", gameMessage);
                }
            }
            game.Fen = message.Fen;
            game.FenArray.Add(message.Fen);
        }
        else if (message.Type == "Pgn")
        {
            GameState game = gameState?.FirstOrDefault(x => x.Id == message.gameState.Id);
            foreach (Player pl in game.Players)
            {
                if (pl.ConnectionId != Context.ConnectionId)
                {
                    GameMessage gameMessage = new GameMessage() { Type = "Pgn", Pgn = message.Pgn, games = gameState };
                    await Clients.Client(pl.ConnectionId).SendAsync("Receive", gameMessage);
                }
            }
            GameMessage observerMessage = new GameMessage() { Type = "Pgn", Pgn = message.Pgn, games = gameState };

            foreach (Player observer in game.Observers)
            {
                await Clients.Client(observer.ConnectionId).SendAsync("Receive", observerMessage);
            }
            game.Pgn = message.Pgn;
        }       
    }

    private static void GetTypeGame(GameMessage message)
    {
        if (message.Options != null && message.Options.add_sec == 0)
        {
            if (message.Options.min * 60 + message.Options.sec <= 120)
            {
                message.Options.type = Type_Game.Bullet;
            }
            if (message.Options.min * 60 + message.Options.sec > 120 && message.Options.min * 60 + message.Options.sec <= 480)
            {
                message.Options.type = Type_Game.Blitz;
            }
            if (message.Options.min * 60 + message.Options.sec > 480 && message.Options.min * 60 + message.Options.sec <= 1500)
            {
                message.Options.type = Type_Game.Rapid;
            }
            if (message.Options.min * 60 + message.Options.sec > 1500)
            {
                message.Options.type = Type_Game.Classical;
            }
        }
        else if (message.Options != null && message.Options.add_sec > 0)
        {
            if (message.Options.min * 60 + message.Options.sec <= 120)
            {
                message.Options.type = Type_Game.BulletInc;
            }
            if (message.Options.min * 60 + message.Options.sec > 120 && message.Options.min * 60 + message.Options.sec <= 480)
            {
                message.Options.type = Type_Game.BlitzInc;
            }
            if (message.Options.min * 60 + message.Options.sec > 480 && message.Options.min * 60 + message.Options.sec <= 1500)
            {
                message.Options.type = Type_Game.RapidInc;
            }
            if (message.Options.min * 60 + message.Options.sec > 1500)
            {
                message.Options.type = Type_Game.ClassicalInc;
            }
        }
    }

    public async Task Process(GameMessage message)
    {
        if (message.Type == "Move")
        {
            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            Move move = new Move()
            {
                StartSquare = message?.Move?.StartSquare,
                EndSquare = message?.Move?.EndSquare,
                PromotedTo = message?.Move?.PromotedTo
            };
            game.Moves = message?.Moves ?? game.Moves;
            game.IsWhiteTurn = !game.IsWhiteTurn;
            game.CurrentBoard = message?.CurrentBoard;
            game.Fen = message?.Fen;
            game.FenArray.Add(message.Fen);
            
            foreach (Player player_opponent in game.Players)
            {
                if (player_opponent != null && player_opponent.ConnectionId != Context.ConnectionId)
                {
                    GameMessage gameMessage = new GameMessage() { Type = "Move", Move = move,Fen = game.Fen, CurrentBoard = game.CurrentBoard, Moves = game.Moves, games = gameState, WhiteTime = message.WhiteTime, BlackTime = message.BlackTime };
                    await Clients.Client(player_opponent.ConnectionId).SendAsync("Receive", gameMessage);
                }
            }
            if (game.IsOngoing && game.PlayerOngoing.ConnectionId != Context.ConnectionId)
            {
                GameMessage gameMessage = new GameMessage() { Type = "Disconnect", games = gameState };
                await Clients.Client(Context.ConnectionId).SendAsync("Receive", gameMessage);
            }
        }
        else if (message.Type == "PlayersClock")
        {

            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            if (game == null) return;

            GameMessage playersMessage = new GameMessage() { Type = "UpdatePlayersClock", gameState = game, games = gameState, WhiteTime = message.WhiteTime, BlackTime = message.BlackTime };

            foreach (Player player in game.Players)
            {
                if (player.ConnectionId != Context.ConnectionId)
                {
                    await Clients.Client(player.ConnectionId).SendAsync("Receive", playersMessage);
                }
            }
        }
        else if (message.Type == "ObserverClock")
        {

            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            if (game == null) return;

            GameMessage observerMessage = new GameMessage() { Type = "UpdateClock", games = gameState, WhiteTime = message.WhiteTime, BlackTime = message.BlackTime };

            foreach (Player observer in game.Observers)
            {
                await Clients.Client(observer.ConnectionId).SendAsync("Receive", observerMessage);
            }
        }
        else if (message.Type == "ObserverMove")
        {

            GameState game = gameState.FirstOrDefault(x => x.Id == Convert.ToInt32(message.Id));
            if (game == null) return;
            Move move = new Move()
            {
                StartSquare = message?.Move?.StartSquare,
                EndSquare = message?.Move?.EndSquare,
                PromotedTo = message?.Move?.PromotedTo
            };
            List<string> observers = new List<string>();
            foreach (Player observer in game.Observers)
            {
                observers.Add(observer.ConnectionId);
            }
            game.Fen = message?.Fen;
            GameMessage observerMessage = new GameMessage() { Type = "UpdateMove", Fen = game.Fen, Move = move };
            await Clients.Clients(observers).SendAsync("Receive", observerMessage);

        }
        else if (message.Type == "Resign")
        {
            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            var player_opponent = game.Players.FirstOrDefault(x => x.ConnectionId != Context.ConnectionId);
            if (player_opponent != null)
            {
                GameMessage gameMessage = new GameMessage() { Type = "Resign", Winner = message.Winner, games = gameState };
                await Clients.Client(player_opponent.ConnectionId).SendAsync("Receive", gameMessage);
            };
            GameMessage observerMessage = new GameMessage() { Type = "ObserverResign", Winner = message.Winner, games = gameState };

            foreach (Player observer in game.Observers)
            {
                await Clients.Client(observer.ConnectionId).SendAsync("Receive", observerMessage);
            }
        }
        else if (message.Type == "Draw")
        {
            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            var player_opponent = game.Players.FirstOrDefault(x => x.ConnectionId != Context.ConnectionId);
            if (player_opponent != null)
            {
                GameMessage gameMessage = new GameMessage() { Type = "Draw", games = gameState };
                await Clients.Client(player_opponent.ConnectionId).SendAsync("Receive", gameMessage);
            };
            GameMessage observerMessage = new GameMessage() { Type = "ObserverDraw", games = gameState };

            foreach (Player observer in game.Observers)
            {
                await Clients.Client(observer.ConnectionId).SendAsync("Receive", observerMessage);
            }
        }
        else if (message.Type == "AcceptDraw")
        {
            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            var player_opponent = game.Players.FirstOrDefault(x => x.ConnectionId != Context.ConnectionId);
            if (player_opponent != null)
            {
                GameMessage gameMessage = new GameMessage() { Type = "AcceptDraw", games = gameState };
                await Clients.Client(player_opponent.ConnectionId).SendAsync("Receive", gameMessage);
            };
            GameMessage observerMessage = new GameMessage() { Type = "ObserverAcceptDraw", games = gameState };

            foreach (Player observer in game.Observers)
            {
                await Clients.Client(observer.ConnectionId).SendAsync("Receive", observerMessage);
            }
        }
        else if (message.Type == "CancelDraw")
        {
            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            var player_opponent = game.Players.FirstOrDefault(x => x.ConnectionId != Context.ConnectionId);
            if (player_opponent != null)
            {
                GameMessage gameMessage = new GameMessage() { Type = "CancelDraw", games = gameState };
                await Clients.Client(player_opponent.ConnectionId).SendAsync("Receive", gameMessage);
            };
            GameMessage observerMessage = new GameMessage() { Type = "ObserverCancelDraw", games = gameState };

            foreach (Player observer in game.Observers)
            {
                await Clients.Client(observer.ConnectionId).SendAsync("Receive", observerMessage);
            }
        }
        else if (message.Type == "SaveRating")
        {
            GameState game = gameState.FirstOrDefault(x => x.Id == message.gameState.Id);
            if (game != null)
            {
                game.Result = message.Result;
                if (Context.User?.Identity?.Name != null)
                {
                   var resCalculate =  await _calculationRatingService.CalculateRatingAsync(game);
                    if (resCalculate != null)
                    {
                        GameMessage gameMessage = new GameMessage() { Type = "UpdateRating" };
                        foreach(Player player in game.Players)
                        {
                            await Clients.Client(player.ConnectionId).SendAsync("Receive",gameMessage);
                        }
                        
                    };                
                }
            }
        }
    }
        public async Task Close(string connectionId)
    {        
        var player = Players.FirstOrDefault(x => x.ConnectionId == connectionId);
        if (player != null)
        {
            Players.Remove(player);
            Context.Abort();
            GameMessage gameMessage = new GameMessage() { Type = "PlayerList", Players = Players, games = gameState };
            await Clients.All.SendAsync("Receive", gameMessage);
        }
    }    
    public async Task AssignColors(GameState game)
    {        
        var random = new Random();
        var rnd = random.Next(0,100);
       
        string[] colors = rnd < 50? ["white", "black"] : ["black", "white"];
        if (game.Options.color == Models.Enums.Color.White)
        {
            colors = ["white", "black"];
        }
        else if (game.Options.color == Models.Enums.Color.Black)
        {
            colors = ["black", "white"];
        }
        var player1 = game.Players[0];
        if (player1 != null)
        {
            GameMessage gameMessage = new GameMessage() { Type = "Color", Color = colors[0] };
            await Clients.Client(player1.ConnectionId).SendAsync("Color", gameMessage);
        };
        var player2 = game.Players[1];
        if (player2 != null)
        {
            GameMessage gameMessage = new GameMessage() { Type = "Color", Color = colors[1] };
            await Clients.Client(player2.ConnectionId).SendAsync("Color", gameMessage);
        };
        if (player1 != null && player2 != null)
        {
            Colors = new Dictionary<string, Player>()
            {
                {colors[0],player1},
                {colors[1],player2}
            };
            game.Colors = Colors;
        }
    }
}