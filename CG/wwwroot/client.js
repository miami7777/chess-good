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
                                kf1 = data.players[0].kf;
                                kf2 = data.players[1].kf;                                
                                playSound('audioStart');
                                let countdown = 10;                                
                                const updateCounter = () => {
                                    block_info.style.display = "flex";                                    
                                    if (countdown > 0) {
                                        counter.innerText = countdown;
                                        countdown--;
                                    }
                                    else {
                                        clearInterval(intervalId);
                                        counter.innerText = "";
                                        allowMoment = true;
                                        allowLeave = false;
                                        document.querySelectorAll(".gameActions")[0].querySelector('path').setAttribute("fill", "#a4a5a6");
                                        block_info.style.display = "none";
                                    }
                                };
                                allowMoment = false;
                                updateCounter();
                                document.getElementById("join").style.display = "none";                                
                                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#a4a5a6") });
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
                                    intervalClock = setInterval(updateClock, 1200);                                    
                                }, 10000);                                
                            }
                        } 
                        if (data.type === "Open") {

                            players = data.players;
                            game = data.gameState;                            
                            updatePlayerInfoGame();
                            allowMoment = false;
                            moves = game.moves;
                            isWhiteTurn = moves.length / 2 % 2 == 0;
                            boardSquaresArray = [];                            
                            positionArray = [...new Set(game.fenArray)];
                            viewedIndex = moves.length;
                            isOpponentWhite = isWhiteTurn;
                            if (moves.length > 0) {
                                pgn = game.pgn;
                                recreateHTMLFromPGN(pgn, 1);
                                loadPositionFEN(game.fen);
                                //loadPositionFromFen(game.currentBoard, !isWhiteTurn);
                                                                                            
                            }                    
                        }
                        if (data.type === "Disconnect") {
                            if (!allowMoment || (isOpponentWhite != isWhiteTurn || !isOpponentWhite != !isWhiteTurn)) return;                            
                            showDisconnect("Соперник покинул игру?", (!isOpponentWhite ? "1-0" : "0-1"));
                        }
                        if (data.type === "Move") {                            
                            const startSquare = data.move.startSquare;
                            const endSquare = data.move.endSquare;
                            const promotedTo = data.move.promotedTo;
                            game.fen = data.fen;
                            clockWhite = data.whiteTime;
                            clockBlack = data.blackTime;
                            document.querySelectorAll('.lastMoveSquare').forEach((el) => { el.classList.remove('lastMoveSquare') });
                            document.querySelectorAll('.preMoveSquare').forEach((el) => { el.classList.remove('preMoveSquare') });
                            displayMove(startSquare, endSquare, promotedTo);                            
                                viewedIndex++;                           
                            playSound('audioMove');                            
                            //playTik('audioTik');   
                            let [startingSquareId, destinationSquareId] = premove.split("|");
                            if (startingSquareId != null && destinationSquareId != null) {
                                displayMove(startingSquareId, destinationSquareId);
                                sendMove(startingSquareId, destinationSquareId);
                                premove = "";
                            }
                            let isOpponentTurn = (isOpponentWhite && isWhiteTurn) || (!isOpponentWhite && !isWhiteTurn);                           
                            if (isOpponentTurn) {                                
                                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#a4a5a6") });
                            }
                            else {                                
                                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#1C274C") });
                            }
                        }                       
                        if (data.type === "Clock") {                             
                            updateObserverClock();                            
                        }
                        if (data.type === "GetClock") {
                            updatePlayersClock();
                        }
                        if (data.type === "UpdateClock") {
                            clockWhite = data.whiteTime;
                            clockBlack = data.blackTime;
                            updateClockOpen();
                            intervalClockOpen = setInterval(updateClockOpen, 1200);
                        }
                        if (data.type === "UpdatePlayersClock") {
                            players = data.gameState.players;
                            clockWhite = data.whiteTime;
                            clockBlack = data.blackTime;
                            updateClock();
                            intervalClock = setInterval(updateClockOpen, 1200);
                            hubConnection.invoke("Message", { type: "Ongoing", gameState: game })
                                .catch(function (err) {
                                    return console.error(err.toString());
                                });
                        }
                        if (data.type === "UpdatePlayerList") {                            
                            game.players = data.gameState.players;
                        }
                        if (data.type === "UpdateMove") {                            
                            const startSquare = data.move.startSquare;
                            const endSquare = data.move.endSquare;
                            const promotedTo = data.move.promotedTo;
                            game.fen = data.fen;
                            displayObserverMove(startSquare, endSquare, promotedTo);
                            viewedIndex++;
                            let currentFen = generateFEN(boardSquaresArray);
                            getEvaluation(currentFen, function (lines, evaluations, scoreString) {
                                displayEval(lines, evaluations, scoreString);
                            });
                        }
                        if (data.type === "UpdateRating") {
                            if (!isRatingGame) {
                                updateChangeRating();
                            }
                        }
                        if (data.type === "Resign") {                            
                            if (!allowMoment) return; 
                            clearInterval(intervalClock);
                            block_info.style.display = "flex";                            
                            game.result = !isWhiteTurn ? "1-0" : "0-1";
                            hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: (!isWhiteTurn ? "1-0" : "0-1") })
                                .catch(function (err) {
                                    return console.error(err.toString());
                                });
                            showAlert(data.winner + " выиграл!", (!isWhiteTurn ? "1-0" : "0-1"));
                        }
                        if (data.type === "AcceptDraw") {                            
                            clearInterval(intervalClock);
                            block_info.style.display = "flex";                            
                            game.result = "1/2 - 1/2";
                            hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: "1/2 - 1/2" })                                
                                .catch(function (err) {
                                    return console.error(err.toString());
                                });
                            showAlert("Ничья по договоренности!", "1/2 - 1/2");
                        }
                        if (data.type === "ObserverAcceptDraw") {
                            clearInterval(intervalClockOpen); 
                            block_info.style.display = "flex";                            
                            showAlert("Ничья по договоренности!", "1/2 - 1/2");
                        }
                        if (data.type === "CancelDraw") {
                            document.getElementById("action-alert").innerHTML = "";
                            document.getElementById("action-alert").style.display = "none";
                        }
                        if (data.type === "Draw") {
                            if (!allowMoment) return;                           
                            showDraw("Вам предложили ничью!Согласны?",true);                            
                        }
                        if (data.type === "ObserverResign") {   
                            clearInterval(intervalClockOpen);
                            block_info.style.display = "flex";                            
                            showAlert(data.winner + " выиграл!", (!isWhiteTurn ? "1-0" : "0-1"));
                        }
                        if (data.type === "ObserverDraw") {
                            showDraw("Предложили ничью!", true);
                        }
                        if (data.type === "ObserverCancelDraw") {
                            document.getElementById("alert").innerHTML = "";
                        }
                        if (data.type === "Reconnect") {                            
                            game = data.gameState;
                            userName = data.userName;
                            players = game.players;                            
                            color = game.colors;                            
                            if (color["black"].userName == userName) {
                                flipBoard();
                                block_info.style.transform = "rotate(180deg)";
                            }                           
                                document.getElementById("join").style.display = "none";
                                document.querySelector(".container-game").style.display = "flex";
                                gamePlayerInfo.style.display = "flex";
                                gamePlayerTopInfo.style.display = "flex";
                                gamePlayerBottomInfo.style.display = "flex";
                                gameTypeInfo.style.display = "flex";
                                playerInfo.style.display = "none";                            
                                updatePlayerInfo();
                                boardSquaresArray = [];
                                loadPositionFEN(game.fen);
                                //loadPositionFromFen(game.currentBoard, game.isWhiteTurn); 
                                pgn = game.pgn;
                                recreateHTMLFromPGN(pgn);
                                moves = game.moves;
                                isWhiteTurn = moves.length % 2 === 0 ? true : false;
                            //positionArray = [...new Set(game.fen)];
                            viewedIndex = positionArray.length - 1;
                            allowMoment = true;
                                                            
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
                                isWhiteTurn = true;
                                flipBoard();
                                block_info.style.transform = "rotate(180deg)";
                            }
                            else {
                                isWhiteTurn = true;
                                isOpponentWhite = false;
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
            block_info.style.display = "flex";            
            if (!isOpponentWhite) {
                min_player1.innerText = "0";
                sec_player1.innerText = "00";
                let hasMaterial = hasMaterialToMate(currentPosition, "black");
                let message = hasMaterial ? "Черные победили!" : "Ничья";                
                let res = hasMaterial ? "0-1" : "1/2-1/2";
                game.result = res;
                showAlert(message, res);
                if (!allowMoment) return;
                hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: res })                      
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
                game.result = res;
                showAlert(message, res);
                if (!allowMoment) return;
                hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: res })
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
            block_info.style.display = "flex";           
            if (isOpponentWhite) {
                min_player1.innerText = "0";
                sec_player1.innerText = "00";
                let hasMaterial = hasMaterialToMate(currentPosition, "white");
                let message = hasMaterial ? "Белые победили!" : "Ничья";               
                let res = hasMaterial ? "1-0" : "1/2-1/2";
                game.result = res;
                showAlert(message, res);
                if (!allowMoment) return;
                hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: res })                    
                    .catch(function (err) {
                        return console.error(err.toString());
                    });                
            } else {
                min_player2.innerText = "0";
                sec_player2.innerText = "00";
                let hasMaterial = hasMaterialToMate(currentPosition, "black");
                let message = hasMaterial ? "Белые победили!" : "Ничья";                             
                let res = hasMaterial ? "1-0" : "1/2-1/2";
                game.result = res;
                showAlert(message, res);
                if (!allowMoment) return;
                hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: res })  
                    .then(() => {
                        if (!isRatingGame) {
                            updateChangeRating();
                        }
                    })
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
            clearInterval(intervalClockOpen);
            block_info.style.display = "flex";
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
            clearInterval(intervalClockOpen);  
            block_info.style.display = "flex";           
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
    hubConnection.invoke("Process", { type: "ObserverClock", userName, gameState: game, whiteTime: clockWhite, blackTime: clockBlack })       
        .catch(function (err) {
            return console.error(err.toString());
        });    
};
const updatePlayersClock = () => {
    hubConnection.invoke("Process", { type: "PlayersClock", userName, gameState: game, whiteTime: clockWhite, blackTime: clockBlack })
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
function startGame(user, color, rating, options) {
    hubConnection.invoke("Message", { type: "Connect", userName: user, color: color, rating: rating, options: options })
        .catch(function (err) {
            return console.error(err.toString());
        });
}
function joinGame(min, sec, add_sec) {
    if (!min) {
        min = document.getElementById("min_game").value === '' ? 3 : parseInt(document.getElementById("min_game").value);
    }
    if (!sec) {
        sec = document.getElementById("sec_game").value === '' ? 0 : parseInt(document.getElementById("sec_game").value);
    }
    if (!add_sec) {
        add_sec = document.getElementById("add_sec").value === '' ? 0 : parseInt(document.getElementById("add_sec").value);
    }
    let select_color = document.querySelector('input[name="inline-radios"]:checked') == null ? 2 : parseInt(document.querySelector('input[name="inline-radios"]:checked').value);   
    userName = document.getElementById("usernameInput").value === '' ? 'Гость' : document.getElementById("usernameInput").value;
    userRating = document.getElementById("userRating")?.value;
    options = {
        min: min,
        sec: sec,
        add_sec: add_sec,
        isRating: isRatingGame,
        color: select_color
    };
    if (!userName) {
        alert("Пожалуйста введите имя под которым хотите играть!");
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
    let pl1 = players[0]?.userName == undefined ? 'Ждем...' :  players[0]?.userName ;
    let pl2 = players[1]?.userName == undefined ? 'Ждем...' : players[1]?.userName;
    let pl1_avatar = players[0]?.avatar;
    let pl2_avatar = players[1]?.avatar;  
    let pl1_flag = players[0]?.country;
    let pl2_flag = players[1]?.country;  
    let p1_name = pl1;
    let p2_name = pl2;
    let r1 = players[0]?.rating;
    let r2 = players[1]?.rating;
    player_r1 = r1;
    player_r2 = r2;

    if (p1_name.length > 15) {
        p1_name = p1_name.slice(0,15) + "..."
    }
    if (p2_name.length > 15) {
        p2_name = p2_name.slice(0, 15) + "..."
    }    
    const playerInfoDiv = document.getElementById("playerInfo");
    playerInfoDiv.innerHTML = `Игрок 1: ${p1_name} - Игрок 2: ${p2_name}`;
    player1.innerText = userName.length > 15 ? userName.slice(0, 15) + "..." : userName;
    player_foto1.src = pl1_avatar != 0 ? "/ru/home/DownloadThumb/" + pl1_avatar : "/assets/assets/img/avatar/default.jpg"; 
    player_foto2.src = pl2_avatar != 0 ? "/ru/home/DownloadThumb/" + pl2_avatar : "/assets/assets/img/avatar/default.jpg"; 
    if (userName === pl1) {
        player2.innerText = p2_name;
        player_foto2.src = pl1_avatar != undefined && pl1_avatar != 0 ? "/ru/home/DownloadThumb/" + pl1_avatar : "/assets/assets/img/avatar/default.jpg";
        player_foto1.src = pl2_avatar != undefined && pl2_avatar != 0 ? "/ru/home/DownloadThumb/" + pl2_avatar : "/assets/assets/img/avatar/default.jpg";
        pl1_flag && flag1.classList.add("flag-icon-" + pl1_flag);
        pl2_flag && flag2.classList.add("flag-icon-" + pl2_flag);
        if (!isRatingGame) {
            rating2.innerText = r2 ? "(" + r2 + ")" : "";
            rating1.innerText = r1 ? "(" + r1 + ")" : "";
        }
    } else {
        player2.innerText = p1_name;
        player_foto2.src = pl2_avatar != undefined && pl2_avatar != 0 ? "/ru/home/DownloadThumb/" + pl2_avatar : "/assets/assets/img/avatar/default.jpg";
        player_foto1.src = pl1_avatar != undefined && pl1_avatar != 0 ? "/ru/home/DownloadThumb/" + pl1_avatar : "/assets/assets/img/avatar/default.jpg";  
        pl1_flag && flag2.classList.add("flag-icon-" + pl1_flag);
        pl2_flag && flag1.classList.add("flag-icon-" + pl2_flag);
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
function updateChangeRating() {
   
    var data = game;
    $.ajax({
        type: "POST",
        url: "/ru/Chess/GetNewRating",
        dataType: 'json',
        data: JSON.stringify(data), 
        contentType: 'application/json; charset=utf-8',
        processData: false,
        success: function (result) {                         
            let newR1 = isOpponentWhite ? result.blackR : result.whiteR;
            let newR2 = isOpponentWhite ? result.whiteR : result.blackR;
            rating1.innerText = isOpponentWhite ? "(" + game.colors.black.rating + ")" : "(" + game.colors.white.rating + ")";
            rating2.innerText = isOpponentWhite ? "(" + game.colors.white.rating + ")" : "(" + game.colors.black.rating + ")";
            if (newR1 > 0) {
                rating1.innerText += "+" + newR1;
                rating1.style.color = "green";
            }
            if (newR1 < 0) {
                rating1.innerText += newR1;
                rating1.style.color = "red";
            }
            if (newR2 > 0) {
                rating2.innerText += "+" + newR2;
                rating2.style.color = "green";
            }
            if (newR2 < 0) {
                rating2.innerText += newR2;
                rating2.style.color = "red";
            }    
        },
        error: function (result) {
            if (result.status == 400 && result.responseText != '')
                alert(result.responseText);
        }
    });    
}
function getWaitResultPairs(r1, r2, k) {
    let dltR = r1 - r2;
   
    return (Math.pow((1 + Math.pow(k, dltR / 400)),-1));
}
function getNewRaitingPairs(r1, r2, res, k) {
     
    return k * parseFloat(res - getWaitResultPairs(r1, r2, k));
}
function loadPositionFEN(fenString) {
    boardSquaresArray = [];    
    document.querySelectorAll('.img').forEach(el => {
        el.remove();
    });
    document.querySelectorAll('.piece').forEach(el => {
        el.remove();
    });   
    let parts = fenString.split(" ");
    let piecePositions = parts[0];
    let squarePassant = parts[3];   
    if (squarePassant != "-")
        enPassantSquare = parts[3];
    let fenRows = piecePositions.split("/");   
    let color1 = "black";
    let color2 = "white";
    let rank = 8;      
    let squareEl = 0;
    let g = 8 - rank + 1;
    while (rank >=1) {
        let row = fenRows[rank-1];
        let fileIndex = 0;
        let rowIndex = 0;
        let color = "";
        let pieceType = "";
        let pieceId = "";        
        for (let file = 0; file <= row.length - 1; file++) {    
            g = 8 - rank + 1;            
            let fenChar = row[file];         
            if (!isNaN(fenChar) &&
                !isNaN(parseInt(fenChar))) {
                fileIndex += parseInt(fenChar);                
            }      
            let column = String.fromCharCode(97 + rowIndex);            
            if (fileIndex > 0) {
                for (let j = 0; j < fileIndex; j++) {
                    column = String.fromCharCode(97 + rowIndex);
                    color = "blank";
                    pieceType = "blank";
                    pieceId = "blank";                   
                    let arrayElementEmpty = {
                        squareId: column + g,
                        pieceColor: color,
                        pieceType: pieceType,
                        pieceId: pieceId
                    };

                    boardSquaresArray.push(arrayElementEmpty);
                    squareEl++;
                    square = boardSquares[squareEl];
                    rowIndex++;
                    if (rowIndex >= 8)
                        rowIndex = 8;
                    }
                                        
                fileIndex = 0;
            }
            else {                
                switch (fenChar) {
                    case "p":
                        color = color1;
                        pieceType = "pawn";
                        break;
                    case "b":
                        color = color1;
                        pieceType = "bishop";;
                        break;
                    case "n":
                        color = color1;
                        pieceType = "knight"; 
                        break;
                    case "r":
                        color = color1;
                        pieceType = "rook"; 
                        break;
                    case "q":
                        color = color1;
                        pieceType = "queen"; 
                        break;
                    case "k":
                        color = color1;
                        pieceType = "king"; 
                        break; 
                    case "P":
                        color = color2;
                        pieceType = "pawn";
                        break;
                    case "B":
                        color = color2;
                        pieceType = "bishop";;
                        break;
                    case "N":
                        color = color2;
                        pieceType = "knight";
                        break;
                    case "R":
                        color = color2;
                        pieceType = "rook";
                        break;
                    case "Q":
                        color = color2;
                        pieceType = "queen";
                        break;
                    case "K":
                        color = color2;
                        pieceType = "king";
                        break;              
                }

                if (rowIndex < 8 && rowIndex >=0) {
                    column = String.fromCharCode(97 + rowIndex);
                    pieceId = pieceType + column + g;                    

                    let arrayElement = {
                        squareId: column + g,
                        pieceColor: color,
                        pieceType: pieceType,
                        pieceId: pieceId
                    };
                    boardSquaresArray.push(arrayElement);
                    squareEl++;
                    square = boardSquares[squareEl];                   
                    rowIndex++;
                }
            }
        }        
        rank--;         
    }         
    for (let i = 0; i < boardSquaresArray.length; i++) {
        if (boardSquaresArray[i].pieceType != "blank") {
            let destinationSquare = document.getElementById(boardSquaresArray[i].squareId);
            let piece = createChessPiece(boardSquaresArray[i].pieceType, boardSquaresArray[i].pieceColor, "piece");
            destinationSquare.appendChild(piece);
        }
    }
    setupBoardSquares();
    setupPieces();
}
function getPositionFEN(fenString) {
    let currentSquaresArray = [];
    document.querySelectorAll('.img').forEach(el => {
        el.remove();
    });
    document.querySelectorAll('.piece').forEach(el => {
        el.remove();
    });
    let parts = fenString.split(" ");
    let piecePositions = parts[0];
    let fenRows = piecePositions.split("/");
    let color1 = "black";
    let color2 = "white";
    let rank = 8;
    let squareEl = 0;
    let g = 8 - rank + 1;
    while (rank >= 1) {
        let row = fenRows[rank - 1];
        let fileIndex = 0;
        let rowIndex = 0;
        let color = "";
        let pieceType = "";
        let pieceId = "";
        for (let file = 0; file <= row.length - 1; file++) {
            g = 8 - rank + 1;
            let fenChar = row[file];
            if (!isNaN(fenChar) &&
                !isNaN(parseInt(fenChar))) {
                fileIndex += parseInt(fenChar);
            }
            let column = String.fromCharCode(97 + rowIndex);
            if (fileIndex > 0) {
                for (let j = 0; j < fileIndex; j++) {
                    column = String.fromCharCode(97 + rowIndex);
                    color = "blank";
                    pieceType = "blank";
                    pieceId = "blank";
                    let arrayElementEmpty = {
                        squareId: column + g,
                        pieceColor: color,
                        pieceType: pieceType,
                        pieceId: pieceId
                    };

                    currentSquaresArray.push(arrayElementEmpty);
                    squareEl++;
                    square = boardSquares[squareEl];
                    rowIndex++;
                    if (rowIndex >= 8)
                        rowIndex = 8;
                }

                fileIndex = 0;
            }
            else {
                switch (fenChar) {
                    case "p":
                        color = color1;
                        pieceType = "pawn";
                        break;
                    case "b":
                        color = color1;
                        pieceType = "bishop";;
                        break;
                    case "n":
                        color = color1;
                        pieceType = "knight";
                        break;
                    case "r":
                        color = color1;
                        pieceType = "rook";
                        break;
                    case "q":
                        color = color1;
                        pieceType = "queen";
                        break;
                    case "k":
                        color = color1;
                        pieceType = "king";
                        break;
                    case "P":
                        color = color2;
                        pieceType = "pawn";
                        break;
                    case "B":
                        color = color2;
                        pieceType = "bishop";;
                        break;
                    case "N":
                        color = color2;
                        pieceType = "knight";
                        break;
                    case "R":
                        color = color2;
                        pieceType = "rook";
                        break;
                    case "Q":
                        color = color2;
                        pieceType = "queen";
                        break;
                    case "K":
                        color = color2;
                        pieceType = "king";
                        break;
                }

                if (rowIndex < 8 && rowIndex >= 0) {
                    column = String.fromCharCode(97 + rowIndex);
                    pieceId = pieceType + column + g;

                    let arrayElement = {
                        squareId: column + g,
                        pieceColor: color,
                        pieceType: pieceType,
                        pieceId: pieceId
                    };
                    currentSquaresArray.push(arrayElement);
                    squareEl++;
                    square = boardSquares[squareEl];
                    rowIndex++;
                }
            }
        }
        rank--;
    }
    return currentSquaresArray;
}
function loadPositionFromFen(currentBoard,isWhite) {
    chessBoard.innerHTML = currentBoard;    
    
    setupBoardSquares();
    setupPieces();
    fillBoardSquaresArray();
    
    //if (isWhite) {
    //    chessBoard.style.transform = "rotate(180deg)";
    //    if (document.getElementById("counter")) {
    //        counter.style.transform = "rotate(180deg)";
    //    }
    //}
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
    currentPosition = generateFEN(boardSquaresArray);    
    if (isWhiteTurn)
        clockBlack += parseInt(add_sec);
    else {
        clockWhite += parseInt(add_sec);
    }
    setClock();
    //stopPlayTik('audioTik');   
    process_move = true;
    viewedIndex++;
    document.getElementById("alert").innerHTML = "";
    let res = { type: "Move", userName, move: move, currentBoard: board, fen: currentPosition, moves: moves, gameState: game, whiteTime: clockWhite, blackTime: clockBlack };
    hubConnection.invoke("Process", res)
        .then(() => {
            let isOpponentTurn = (isOpponentWhite && isWhiteTurn) || (!isOpponentWhite && !isWhiteTurn);
            if (isOpponentTurn) {
                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#a4a5a6") });
            }
            else {
                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#1C274C") });
            }
        })
        .catch(function (err) {
            console.log('err',err);
                return console.error(err.toString());
            });
    let resObserver = { type: "ObserverMove", move: move, fen: currentPosition, id: game.id.toString() };
    sendObserverMove(resObserver);
}
function sendObserverMove(res) {    
    if (isWhiteTurn)
        clockBlack += parseInt(add_sec);
    else {
        clockWhite += parseInt(add_sec);
    }
    setClock(); 
    viewedIndex++;
    hubConnection.invoke("Process", res)
        .catch(function (err) {
            return console.error(err.toString());
        });
}
function sendResign(winner) { 
    let isOpponentTurn = (isOpponentWhite && isWhiteTurn) || (!isOpponentWhite && !isWhiteTurn);
    if (!allowMoment || isOpponentTurn) return;
    clearInterval(intervalClock);
    block_info.style.display = "flex";    
    game.result = !isWhiteTurn ? "1-0" : "0-1";
    hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: (!isWhiteTurn ? "1-0" : "0-1") }) 
        .catch(function (err) {
            return console.error(err.toString());
        });
    showAlert(player2.innerText + " выиграл!", (!isWhiteTurn ? "1-0" : "0-1"));
    hubConnection.invoke("Process", { type: "Resign", winner: winner, gameState: game })
        .then(() => {
            let isOpponentTurn = (isOpponentWhite && isWhiteTurn) || (!isOpponentWhite && !isWhiteTurn);
            if (isOpponentTurn) {
                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#a4a5a6") });
            }
            else {
                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#1C274C") });
            }
        })
        .catch(function (err) {
            return console.error(err.toString());
        });    
}
function sendDraw(message) {    
    if (!allowMoment) return;
    showDraw(message,false);
    hubConnection.invoke("Process", { type: "Draw", gameState: game })
        .then(() => {
            let isOpponentTurn = (isOpponentWhite && isWhiteTurn) || (!isOpponentWhite && !isWhiteTurn);
            if (isOpponentTurn) {
                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#a4a5a6") });
            }
            else {
                document.querySelectorAll(".gameActions")[2].querySelectorAll('path').forEach(el => { el.setAttribute("fill", "#1C274C") });
            }
        })
        .catch(function (err) {
            return console.error(err.toString());
        });
}
function sendCancel() {
    if (!allowMoment || !allowLeave) return;
    clearInterval(intervalClock);   
    block_info.style.display = "flex";    
    showAlert(player1.innerText + " отменил партию!");
    hubConnection.invoke("Process", { type: "Cancel", gameState: game })
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