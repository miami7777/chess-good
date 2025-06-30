
const hubConnection = new signalR.HubConnectionBuilder()
        .withUrl("/ru/chess/chessHub")
    .build();
let players = [];
let game;
const typeBattles = ["Пуля", "Пуля с добавлением", "Блиц", "Блиц с добавлением", "Рапид", "Рапид с добавлением", "Классика", "Классика с добавлением"];
            hubConnection.start()
                .then(function () {
                    let gameId = document.getElementById("gameId");
                    if (gameId) {                        
                        let elems = document.querySelectorAll(".container-game");
                        var index = 0, length = elems.length;
                        for (; index < length; index++) {
                            elems[index].style.display = "flex";
                        }
                        gamePlayerInfo.style.display = "flex";
                        gamePlayerTopInfo.style.display = "flex";
                        gamePlayerBottomInfo.style.display = "flex";
                        gameTypeInfo.style.display = "flex";
                        playerInfo.style.display = "none";
                        openGame(gameId.value);                        
                    }
                    hubConnection.on("Statistics", function (event) {                        
                        const data = event;                        
                        if (data && data.connects) {                           
                            connects.innerHTML = data.connects.length;                                                     
                            list_players.innerHTML = "";                                                  
                            sp.innerHTML = data.users.length;
                            data.users.forEach(function (element, key) { 
                                list_players.innerHTML += "<div><a href=\"#\">" + element.userName + "</a></div>";
                            });
                            
                            list_games.innerHTML = ""; 
                            list_battles.innerHTML = ""; 
                            data.gameState.forEach(function (element, key) {
                                if (element.players.length == 2) {                                                                      
                                    list_games.innerHTML += "<div><a href=\"game/" + element.id + "\">" + element.players[0].userName + " - " + element.players[1].userName + "</a></div>";
                                }
                                if (element.players.length == 1) {
                                    list_battles.innerHTML += "<div id=\"game-waiting-" + element.id + "\"><a href=\"#\" onclick=\"acceptGame('" + element.id + "')\">" + element.players[0].userName + "-" + element.options.min + "+" + element.options.add_sec + " " + (element.options.isRating ? "Товарищеская" : "Рейтинговая") + "</a></div>"
                                } 
                            });
                        }
                        
                    });
                    hubConnection.on("Receive", function (event) {                       
                        const data = event;                           
                        if (data.type === "PlayerList") {                            
                            players = data.players;
                            game = data.gameState;                           
                            clockWhite = game.options.min * 60 + game.options.sec;
                            clockBlack = game.options.min * 60 + game.options.sec;
                            add_sec = game.options.add_sec;
                            let type_game = game.options.min;
                            if (game.options.sec) {
                                type_game += ":" + game.options.sec;
                            }
                            type_game += "+" + game.options.add_sec;                            
                            typeGame.innerText = typeBattles[game.options.type];
                            clock.innerText = type_game;
                            setClock();
                            updatePlayerInfo();
                            list_battles.innerHTML = "";                                            
                            list_players.innerHTML = "";
                            list_games.innerHTML = "";                             
                            data.games.forEach(function (element, key) {
                                if (element.players.length == 2) {
                                    list_games.innerHTML += "<div><a href=\"game/" + element.id + "\">" + element.players[0].userName + "-" + element.players[1].userName + "</a></div>";
                                    if (element.players.length == 1) {
                                        list_battles.innerHTML += "<div id=\"game-waiting-" + element.id + "\"><a href=\"#\" onclick=\"acceptGame('" + element.id + "')\">" + element.players[0].userName + "-" + element.options.min + "+" + element.options.add_sec + " " + (element.options.isRating ? "Товарищеская" : "Рейтинговая") + "</a></div>"
                                    }
                                    if (element.players.length == 1) {
                                        list_battles.innerHTML += "<div id=\"game-waiting-" + element.id + "\"><a href=\"#\" onclick=\"acceptGame('" + element.id + "')\">" + element.players[0].userName + "-" + element.options.min + "+" + element.options.add_sec + " " + (element.options.isRating ? "Товарищеская" : "Рейтинговая") + "</a></div>"
                                        }
                                }
                            });
                            if (data.players.length === 2) {
                                playSound('audioStart');
                                let countdown = 10;
                                const updateCounter = () => {
                                    if (countdown > 0) {
                                        counter.innerText = countdown;
                                        countdown--;
                                    }
                                    else {
                                        clearInterval(intervalId);
                                        counter.innerText = "";
                                        allowMoment = true;
                                    }
                                };
                                allowMoment = false;
                                updateCounter();
                                document.getElementById("join").style.display = "none";
                                let elems = document.querySelectorAll(".container-game");
                                var index = 0, length = elems.length;
                                for (; index < length; index++) {
                                    elems[index].style.display = "flex";
                                }
                                gamePlayerInfo.style.display = "flex";
                                gamePlayerTopInfo.style.display = "flex";
                                gamePlayerBottomInfo.style.display = "flex";
                                gameTypeInfo.style.display = "flex";
                                playerInfo.style.display = "none";
                                
                                const intervalId = setInterval(updateCounter, 1000); 
                                setTimeout(() => {                                    
                                    updateClock();
                                    intervalClock = setInterval(updateClock, 1000);                                    
                                }, 10000);                                
                            }
                        } 
                        if (data.type === "Open") {
                            players = data.players;
                            game = data.gameState;                            
                            updatePlayerInfoGame();
                            allowMoment = false;
                            moves = game.moves;
                            isWhiteTurn = moves.length % 2 === 0 ? true : false;
                            boardSquaresArray = [];
                            loadPositionFromFen(game.currentBoard, isWhiteTurn);
                            pgn = game.pgn;
                            recreateHTMLFromPGN(pgn);   
                            positionArray = [...new Set(game.fen)];
                            isOpponentWhite = false;
                                                       
                        }
                        if (data.type === "Move") {
                            const startSquare = data.move.startSquare;
                            const endSquare = data.move.endSquare;
                            const promotedTo = data.move.promotedTo;
                            document.querySelectorAll('.lastMoveSquare').forEach((el) => { el.classList.remove('lastMoveSquare') });
                            displayMove(startSquare, endSquare, promotedTo);                            
                            playSound('audioMove');
                            playTik('audioTik');
                        }                       
                        if (data.type === "Clock") {                             
                            updateObserverClock();                            
                        }
                        if (data.type === "UpdateClock") {
                            clockWhite = data.whiteTime;
                            clockBlack = data.blackTime;
                            updateClockOpen();
                            intervalClock = setInterval(updateClockOpen, 1000);
                        }
                        if (data.type === "UpdateMove") {                            
                            const startSquare = data.move.startSquare;
                            const endSquare = data.move.endSquare;
                            const promotedTo = data.move.promotedTo;                                                         
                            displayObserverMove(startSquare, endSquare, promotedTo); 
                            let currentFen = generateFEN(boardSquaresArray);
                            getEvaluation(currentFen, function (lines, evaluations, scoreString) {
                                displayEval(lines, evaluations, scoreString);
                            });
                        }
                        if (data.type === "Resign") {                            
                            if (!allowMoment) return; 
                            clearInterval(intervalClock);
                            hubConnection.invoke("Message", { type: "SaveRating", gameState: game, result: (!isWhiteTurn ? "1-0" : "0-1") })
                                .catch(function (err) {
                                    return console.error(err.toString());
                                });
                            showAlert(data.winner + " выиграл!", (!isWhiteTurn ? "1-0" : "0-1"));
                        }
                        if (data.type === "ObserverResign") {                            
                            showAlert(data.winner + " выиграл!", (!isWhiteTurn ? "1-0" : "0-1"));
                        }
                        if (data.type === "Reconnect") {                             
                            players = data.players;
                            game = data.gameState;
                            color = data.color;
                            if (color == "black") {
                                flipBoard();
                            }
                                
                            if (data.gameState.isOngoing) {                                  
                                document.getElementById("join").style.display = "none";
                                document.querySelector(".container-game").style.display = "flex";
                                gamePlayerInfo.style.display = "flex";
                                gamePlayerTopInfo.style.display = "flex";
                                gamePlayerBottomInfo.style.display = "flex";
                                gameTypeInfo.style.display = "flex";
                                playerInfo.style.display = "none";
                                if (data.opponent) {                                    
                                    players = [data.playerOngoing,data.opponent];                                    
                                    userName = data.playerOngoing.userName;
                                    updatePlayerInfo();
                                    loadPositionFromFen(data.gameState.currentBoard); 
                                    pgn = data.gameState.pgn;
                                    recreateHTMLFromPGN(pgn);
                                    moves = data.gameState.moves;
                                    isWhiteTurn = moves.length % 2 === 0 ? true : false;
                                    positionArray = [...new Set(data.gameState.fen)];

                                }
                            }
                            else {

                            }
                        }
                        if (data.type === "Fen") {
                            currentPosition = data.fen;
                        }
                        if (data.type === "Pgn") {
                            pgn = data.pgn;
                        }
                    });   
                    hubConnection.on("Color", function (event) {
                        const data = event;
                       
                        if (data.type === "Color") {                            
                            color = data.color;                           
                            if (color === "black") {
                                isOpponentWhite = true;                                                                                        
                                flipBoard();                                                               
                            }                            

                        }
                    });
                    hubConnection.on("Error", function (event) {
                        document.getElementById("join").style.display = "flex";
                       
                        alert(event.message);
                    });
            })
            .catch(function (err) {
                return console.error(err.toString());
            });
    hubConnection.onclose(function () {
        console.log("Disconnected from the server!");
    })
let userName;
let color;
let userRating;
let intervalClock;
const updateClock = () => {

    if (isWhiteTurn) {
        if (clockWhite > 0) {
            let sec_w = clockWhite / 60;
            let min_w = Math.floor(sec_w);
            sec_w = clockWhite - min_w * 60;
            if (!isOpponentWhite) {
                sec_player1.innerText = sec_w < 10 ? "0" + sec_w : sec_w;
                min_player1.innerText = min_w < 10 ? "0" + min_w : min_w;
            }
            else {
                sec_player2.innerText = sec_w < 10 ? "0" + sec_w : sec_w;
                min_player2.innerText = min_w < 10 ? "0" + min_w : min_w;
            }
            clockWhite--;            
        }
        else {
            clearInterval(intervalClock);           

            if (!isOpponentWhite) {
                min_player1.innerText = "0";
                sec_player1.innerText = "00";
                let hasMaterial = hasMaterialToMate(currentPosition, "black");
                let message = hasMaterial ? "Черные победили!" : "Ничья";
                let res = hasMaterial ? "0-1" : "1/2-1/2";
                showAlert(message, res);
                if (!allowMoment) return;
                hubConnection.invoke("Message", { type: "SaveRating", gameState: game, result: res })
                    .catch(function (err) {
                        return console.error(err.toString());
                    });                
            }
            else {
                min_player2.innerText = "0";
                sec_player2.innerText = "00";
                let hasMaterial = hasMaterialToMate(currentPosition, "white");
                let message = hasMaterial ? "Черные победили!" : "Ничья";
                let res = hasMaterial ? "0-1" : "1/2-1/2";
                showAlert(message, res);
                if (!allowMoment) return;
                hubConnection.invoke("Message", { type: "SaveRating", gameState: game, result: res })
                    .catch(function (err) {
                        return console.error(err.toString());
                    });                
            }
        }
    } else {
        if (clockBlack > 0) {
            let sec_b = clockBlack / 60;
            let min_b = Math.floor(sec_b);
            sec_b = clockBlack - min_b * 60;
            if (isOpponentWhite) {
                sec_player1.innerText = sec_b < 10 ? "0" + sec_b : sec_b;
                min_player1.innerText = min_b < 10 ? "0" + min_b : min_b;
            }
            else {
                sec_player2.innerText = sec_b < 10 ? "0" + sec_b : sec_b;
                min_player2.innerText = min_b < 10 ? "0" + min_b : min_b;
            }
            clockBlack--;           
        }
        else {
            clearInterval(intervalClock);            
            if (isOpponentWhite) {
                min_player1.innerText = "0";
                sec_player1.innerText = "00";
                let hasMaterial = hasMaterialToMate(currentPosition, "white");
                let message = hasMaterial ? "Белые победили!" : "Ничья";
                let res = hasMaterial ? "1-0" : "1/2-1/2";
                showAlert(message, res);
                if (!allowMoment) return;
                hubConnection.invoke("Message", { type: "SaveRating", gameState: game, result: res })
                    .catch(function (err) {
                        return console.error(err.toString());
                    });                
            } else {
                min_player2.innerText = "0";
                sec_player2.innerText = "00";
                let hasMaterial = hasMaterialToMate(currentPosition, "black");
                let message = hasMaterial ? "Белые победили!" : "Ничья";
                let res = hasMaterial ? "1-0" : "1/2-1/2";
                showAlert(message, res);
                if (!allowMoment) return;
                hubConnection.invoke("Message", { type: "SaveRating", gameState: game, result: res })
                    .catch(function (err) {
                        return console.error(err.toString());
                    });
            }
        }
    }
};
const updateClockOpen = () => {  
    if (isWhiteTurn) {        
        if (clockWhite > 0) {
            let sec_w = clockWhite / 60;
            let min_w = Math.floor(sec_w);
            sec_w = clockWhite - min_w * 60;           
            sec_player1.innerText = sec_w < 10 ? "0" + sec_w : sec_w;
            min_player1.innerText = min_w < 10 ? "0" + min_w : min_w;
            let sec_b = clockBlack / 60;
            let min_b = Math.floor(sec_b);
            sec_b = clockBlack - min_b * 60;
            sec_player2.innerText = sec_b < 10 ? "0" + sec_b : sec_b;
            min_player2.innerText = min_b < 10 ? "0" + min_b : min_b;
            clockWhite--;
                        
        }
        else {
            clearInterval(intervalClock);           
            min_player1.innerText = "0";
            sec_player1.innerText = "00";
            let hasMaterial = hasMaterialToMate(currentPosition, "black");
            let message = hasMaterial ? "Черные победили!" : "Ничья";
            let res = hasMaterial ? "0-1" : "1/2-1/2";
            showAlert(message, res);
        }
    } else {       
        if (clockBlack > 0) {
            let sec_w = clockWhite / 60;
            let min_w = Math.floor(sec_w);
            sec_w = clockWhite - min_w * 60;
            sec_player1.innerText = sec_w < 10 ? "0" + sec_w : sec_w;
            min_player1.innerText = min_w < 10 ? "0" + min_w : min_w;
            let sec_b = clockBlack / 60;
            let min_b = Math.floor(sec_b);
            sec_b = clockBlack - min_b * 60;            
            sec_player2.innerText = sec_b < 10 ? "0" + sec_b : sec_b;
            min_player2.innerText = min_b < 10 ? "0" + min_b : min_b;
            clockBlack--;           
        }
        else {    
            clearInterval(intervalClock);           
            min_player2.innerText = "0";
            sec_player2.innerText = "00";
            let hasMaterial = hasMaterialToMate(currentPosition, "black");
            let message = hasMaterial ? "Белые победили!" : "Ничья";
            let res = hasMaterial ? "1-0" : "1/2-1/2";
            showAlert(message, res); 
        }        
    }    
};
const updateObserverClock = () => {    
    hubConnection.invoke("Message", { type: "ObserverClock", userName, gameState: game, whiteTime: clockWhite, blackTime: clockBlack })       
        .catch(function (err) {
            return console.error(err.toString());
        });    
};
function setClock() { 
    let sec_w = clockWhite / 60;
    let min_w = Math.floor(sec_w);
    sec_w = clockWhite - min_w * 60;
    if (!isOpponentWhite) {
        sec_player1.innerText = sec_w < 10 ? "0" + sec_w : sec_w;
        min_player1.innerText = min_w < 10 ? "0" + min_w : min_w;
    }
    else {
        sec_player2.innerText = sec_w < 10 ? "0" + sec_w : sec_w;
        min_player2.innerText = min_w < 10 ? "0" + min_w : min_w;
    }           
       
    let sec_b = clockBlack / 60;
    let min_b = Math.floor(sec_b);
    sec_b = clockBlack - min_b * 60;
    if (isOpponentWhite) {
        sec_player1.innerText = sec_b < 10 ? "0" + sec_b : sec_b;
        min_player1.innerText = min_b < 10 ? "0" + min_b : min_b;
    }
    else {
        sec_player2.innerText = sec_b < 10 ? "0" + sec_b : sec_b;
        min_player2.innerText = min_b < 10 ? "0" + min_b : min_b;
    } 
};
function joinGame() {
    userName = document.getElementById("usernameInput").value;
    userRating = document.getElementById("userRating")?.value;
    options = {
        min: document.getElementById("min_game").value === '' ? 3 : parseInt(document.getElementById("min_game").value),
        sec: document.getElementById("sec_game").value === '' ? 0 : parseInt(document.getElementById("sec_game").value),
        add_sec: document.getElementById("add_sec").value === '' ? 0 : parseInt(document.getElementById("add_sec").value),
        isRating: isRatingGame
    };
    if (!userName) {
        alert("Пожалуйста введи имя под которым хотите играть!");
        return;
    }
    join.style.display = "none";
   
    hubConnection.invoke("Message", { type: "Join", userName: userName, rating: userRating, options: options })
        .catch(function (err) {
            return console.error(err.toString());
        });    
}
function acceptGame(gameId) {
    userName = document.getElementById("usernameInput").value;
    userRating = document.getElementById("userRating")?.value;
    if (!userName) {
        alert("Пожалуйста введите имя под которым хотите смотреть!");
        return;
    }
    join.style.display = "none";

    hubConnection.invoke("Message", { type: "Accept", userName: userName, gameId: gameId })
        .catch(function (err) {
            return console.error(err.toString());
        });
}
function openGame(id) {
    hubConnection.invoke("Message", { type: "Open", id: id })
        .catch(function (err) {
            return console.error(err.toString());
        });
}
function assignColors() {     
    hubConnection.invoke("assignColors");
}
function updatePlayerInfo() {    
    let pl1 = players[0]?.userName == undefined ? 'Ждем...': players[0]?.userName;
    let pl2 = players[1]?.userName == undefined ? 'Ждем...' : players[1]?.userName;
    let pl1_avatar = players[0]?.avatar;
    let pl2_avatar = players[1]?.avatar;
    let p1_name = pl1;
    let p2_name = pl2;
    let r1 = players[0]?.rating;
    let r2 = players[1]?.rating;    
    if (p1_name.length > 15) {
        p1_name = p1_name.slice(0,15) + "..."
    }
    if (p2_name.length > 15) {
        p2_name = p2_name.slice(0, 15) + "..."
    }    
    const playerInfoDiv = document.getElementById("playerInfo");
    playerInfoDiv.innerHTML = `Игрок 1: ${p1_name} - Игрок 2: ${p2_name}`;
    player1.innerText = userName.length > 15 ? userName.slice(0, 15) + "..." : userName; 
    player_foto1.src = "/assets/assets/img/avatar/avatar-" + userName + ".jpg";
    tooltip_player1.innerText = userName;   
    if (userName === pl1) {
        player2.innerText = p2_name;
        player_foto2.src = "/assets/assets/img/avatar/" + pl1_avatar;
        player_foto1.src = "/assets/assets/img/avatar/" + pl2_avatar;
        tooltip_player2.innerText = pl2;
        if (!isRatingGame) {
            rating2.innerText = r2 ? "(" + r2 + ")" : "";
            rating1.innerText = r1 ? "(" + r1 + ")" : "";
        }
    } else {
        player2.innerText = p1_name;
        player_foto2.src = "/assets/assets/img/avatar/" + pl2_avatar;
        player_foto1.src = "/assets/assets/img/avatar/" + pl1_avatar;
        tooltip_player2.innerText = pl1;
        if (!isRatingGame) {
            rating2.innerText = r1 ? "(" + r1 + ")" : "";
            rating1.innerText = r2 ? "(" + r2 + ")" : "";
        }
    }    
}
function updatePlayerInfoGame() {

    let pl1 = players[0]?.userName == undefined ? 'Ждем...' : players[0]?.userName;
    let pl2 = players[1]?.userName == undefined ? 'Ждем...' : players[1]?.userName;
    let p1_name = pl1;
    let p2_name = pl2;
    let r1 = players[0]?.rating;
    let r2 = players[1]?.rating;
    if (p1_name.length > 15) {
        p1_name = p1_name.slice(0, 15) + "..."
    }
    if (p2_name.length > 15) {
        p2_name = p2_name.slice(0, 15) + "..."
    }      
    
    player1.innerText = pl1.length > 15 ? pl1.slice(0, 15) + "..." : pl1;
    tooltip_player1.innerText = pl1;    
    player2.innerText = p2_name;
    tooltip_player2.innerText = pl2;
    if (!isRatingGame) {
        rating2.innerText = r2 ? "(" + r2 + ")" : "";
        rating1.innerText = r1 ? "(" + r1 + ")" : "";
    }    
}
function updateChangeRating(color) {    
    let pl1 = players[0]?.userName == undefined ? 'Ждем...' : players[0]?.userName;       
    if (color == "" && userName === pl1) {
        rating1.innerText += "-1";
        rating1.style.color = "red";
        rating2.innerText += "+1";
        rating2.style.color = "green";
    } else if (color == "" && userName !== pl1) {
        rating1.innerText += "+1";
        rating1.style.color = "green";
        rating2.innerText += "-1";
        rating2.style.color = "red";
    }
    else if (userName === pl1) {        
        rating2.innerText += color == "white" ? "-5" : "+5";
        rating2.style.color = color == "white" ? "red" : "green";
        rating1.innerText += color == "white" ? "+5" : "-5";
        rating1.style.color = color == "white" ? "green" : "red";
    }
     else {        
        rating2.innerText += color == "white" ? "+5" : "-5";
        rating2.style.color = color == "white" ? "green" : "red";
        rating1.innerText += color == "white" ? "-5" : "+5";
        rating1.style.color = color == "white" ? "red" : "green";
    }    
}
function loadPositionFromFen(currentBoard,isWhite) {
    chessBoard.innerHTML = currentBoard;    
    if (!isWhite) {       
        chessBoard.style.transform = "rotate(180deg)";
    }
    setupBoardSquares();
    setupPieces();
    fillBoardSquaresArray();
    let currentFen = generateFEN(boardSquaresArray); 
    getEvaluation(currentFen, function (lines, evaluations, scoreString) {
        displayEval(lines, evaluations, scoreString);
    });
}
function sendMove(startSquare, endSquare, promotedTo = "blank") {
    if (!startSquare || !endSquare) {
        alert("Invalid move!");
        return;
    }
    const move = { startSquare, endSquare, promotedTo };
    const board = chessBoard.innerHTML;
    if (isWhiteTurn)
        clockBlack += add_sec+1;
    else {
        clockWhite += add_sec+1;
    }
    setClock();
    stopPlayTik('audioTik');
   
        let res = { type: "Move", userName, move: move, currentBoard: board, moves: moves, gameState: game };
        hubConnection.invoke("Message", res)
            .catch(function (err) {
                return console.error(err.toString());
            });
    let resObserver = { type: "ObserverMove", move: move, id: game.id.toString() };
    sendObserverMove(resObserver);
}
function sendObserverMove(res) {    
    if (isWhiteTurn)
        clockBlack += add_sec + 1;
    else {
        clockWhite += add_sec + 1;
    }
    setClock();  
    hubConnection.invoke("Message", res)
        .catch(function (err) {
            return console.error(err.toString());
        });
}
function sendResign(winner) {  
    if (!allowMoment) return;
    clearInterval(intervalClock);
    hubConnection.invoke("Message", { type: "SaveRating", gameState: game, result: (!isWhiteTurn ? "1-0" : "0-1") })
        .catch(function (err) {
            return console.error(err.toString());
        });
    showAlert(player2.innerText + " выиграл!", (!isWhiteTurn ? "1-0" : "0-1"));
    hubConnection.invoke("Message", { type: "Resign", winner: winner, gameState: game })
        .catch(function (err) {
            return console.error(err.toString());
        });    
}
function sendFen(fen) {
    hubConnection.invoke("Message", { type: "Fen", fen: fen, gameState: game })
        .catch(function (err) {
            return console.error(err.toString());
        });
}
function sendPgn(pgn) {
    hubConnection.invoke("Message", { type: "Pgn", pgn: pgn, gameState: game })
        .catch(function (err) {
            return console.error(err.toString());
        });
}