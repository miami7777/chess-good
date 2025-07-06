let legalSquares = [];
let boardSquaresArray = [];
let positionArray = [];
let moves = [];
const castlingSquares = ["g1","g8","c1","c8"];
let isWhiteTurn = true;
let enPassantSquare = "blank";
const boardSquares = document.getElementsByClassName("square");
const pieces = document.getElementsByClassName("piece");
const piecesImages = document.getElementsByTagName("img");
const chessBoard = document.querySelector(".chessBoard");
let allowMoment = false;
let isOpponentWhite = false;
let selectedLevel = 1;
let pgn = "";
let clockWhite = 180;
let clockBlack = 180;
process_move = false;
let add_sec = 0;
let isRatingGame = true;
var touchText="";
let touchLegal = [];
setupBoardSquares();
setupPieces();
fillBoardSquaresArray();
let board = document.querySelectorAll(".board");
if (board.length > 0) {
    addResizeBtn(board[0]);
}
let infoBoard = document.querySelectorAll(".infoBoard");
if (infoBoard.length > 0) {
    addResizeInfoBtn(infoBoard[0]);
}

const startingPosition = chessBoard.innerHTML;
let currentPosition = generateFEN(boardSquaresArray);
let currentBoard = chessBoard.innerHTML;
let pieceMoving = document.createElement("div");
pieceMoving.id = "pieceMoving";
pieceMoving.style.position = "absolute";
pieceMoving.style.width = "62px";
pieceMoving.style.height = "62px";
pieceMoving.style.zIndex = "1000";
function flipBoard() {
    Array.from(document.getElementsByClassName("piece")).forEach(div => {
        div.style.transform = div.style.transform === "rotate(180deg)" ? "rotate(0deg)" : "rotate(180deg)";
    });
    Array.from(document.getElementsByClassName("coordinate")).forEach(div => {
        div.style.transform = div.style.transform === "rotate(180deg)" ? "rotate(0deg)" : "rotate(180deg)";
        if (div.classList.contains("rank"))
            div.style.height = " 20%";
    });
    chessBoard.style.transform = chessBoard.style.transform === "rotate(180deg)" ? "rotate(0deg)" : "rotate(180deg)";
    isOpponentWhite = true;
    currentPosition = generateFEN(boardSquaresArray);
};
level.addEventListener("change", function () {
    selectedLevel = this.value;
});
function makeMove(startingSquareId,destinationSquareId,pieceType,pieceColor,captured,promotedTo = "blank") {
    moves.push({
        from: startingSquareId,
        to: destinationSquareId,
        pieceType: pieceType,
        pieceColor: pieceColor,
        captured: captured,
        promotedTo: promotedTo
    });   
}
function generateFEN(boardSquares) {
    let fen = "";
    let rank = 8;
    while (rank >= 1) {
        for (let file = "a"; file <= "h"; file = String.fromCharCode(file.charCodeAt(0) + 1)) {
            const square = boardSquares.find((element) => element.squareId === `${file}${rank}`);
            if (square && square.pieceType) {
                let pieceNotation = "";
                switch (square.pieceType) {
                    case "pawn":
                    pieceNotation = "p";
                        break;
                    case "bishop":
                        pieceNotation = "b";
                        break;
                    case "knight":
                        pieceNotation = "n";
                        break;
                    case "rook":
                        pieceNotation = "r";
                        break;
                    case "queen":
                        pieceNotation = "q";
                        break;
                    case "king":
                        pieceNotation = "k";
                        break;
                    case "blank":
                        pieceNotation = "blank";
                        break;
                }
                fen += square.pieceColor === "white" ? pieceNotation.toUpperCase() : pieceNotation;
            }
        }
        if (rank > 1) {
            fen+="/"
        }
        rank--;
    }
    fen = fen.replace(new RegExp("blankblankblankblankblankblankblankblank", "g"), 8);
    fen = fen.replace(new RegExp("blankblankblankblankblankblankblank", "g"), 7);
    fen = fen.replace(new RegExp("blankblankblankblankblankblank", "g"), 6);
    fen = fen.replace(new RegExp("blankblankblankblankblank", "g"), 5);
    fen = fen.replace(new RegExp("blankblankblankblank", "g"), 4);
    fen = fen.replace(new RegExp("blankblankblank", "g"), 3);
    fen = fen.replace(new RegExp("blankblank", "g"), 2);
    fen = fen.replace(new RegExp("blank", "g"), 1);

    fen += isWhiteTurn ? " w " : " b "; 
    let castlingString = "";
    let shortCastlePossibleForWhite = !kingHasMoved("white") && !rookHasMoved("white", "h1");
    let longCastlePossibleForWhite = !kingHasMoved("white") && !rookHasMoved("white", "a1");
    let shortCastlePossibleForBlack = !kingHasMoved("black") && !rookHasMoved("black", "h8");
    let longCastlePossibleForBlack = !kingHasMoved("black") && !rookHasMoved("black", "a8");

    if (shortCastlePossibleForWhite) castlingString += "K";
    if (longCastlePossibleForWhite) castlingString += "Q";
    if (shortCastlePossibleForBlack) castlingString += "k";
    if (longCastlePossibleForBlack) castlingString += "q";

    if (castlingString == "") castlingString += "-";
    castlingString += " ";

    fen += castlingString;
    fen += enPassantSquare == "blank" ? "-" : enPassantSquare;

    let fiftyMovesRuleCount = getFiftyMovesRuleCount();
    fen += " " + fiftyMovesRuleCount;
    let moveCount = Math.floor(moves.length / 2) + 1;
    fen += " " + moveCount;
    return fen;

}
function fillBoardSquaresArray() {
    const boardSquares = document.getElementsByClassName("square");
    for (let i = 0; i < boardSquares.length; i++) {
        let row = 8 - Math.floor(i / 8);
        let column = String.fromCharCode(97 + (i % 8));
        let square = boardSquares[i];
        square.id = column + row;
        let color = "";
        let pieceType = "";
        let pieceId = "";
        if (square.querySelector(".piece")) {
            color = square.querySelector(".piece").getAttribute("color");
            pieceType = square.querySelector(".piece").classList[1];
            pieceId = square.querySelector(".piece").id;
        }
        else {
            color = "blank";
            pieceType = "blank";
            pieceId = "blank";
        }
        let arrayElement = {
            squareId: square.id,
            pieceColor: color,
            pieceType: pieceType,
            pieceId: pieceId
        };
        boardSquaresArray.push(arrayElement);
    }
}
function deepCopyArray(array) {
    let arrayCopy = array.map((element) => {
        return { ...element }
    })
    return arrayCopy;
}
function setupBoardSquares() {
    for (i = 0; i < boardSquares.length; i++) {
        boardSquares[i].addEventListener("dragover", allowDrop);       
        boardSquares[i].addEventListener("drop", drop);  
        boardSquares[i].addEventListener("touchstart", (ev) => {
            ev.preventDefault();
            if (!allowMoment) return;
            
            if (ev.target) {
                const piece = ev.target.parentElement;

                var movableElement = piece; 
                
                const pieceColor = piece.getAttribute("color");
                const pieceType = piece.classList[1];
                const pieceId = piece.id;
                if ((isWhiteTurn && pieceColor == "white") || (!isWhiteTurn && pieceColor == "black")) {
                    const startingSquareId = piece.parentNode.id;

                    touchText = piece.id + "|" + startingSquareId;
                    const pieceObject = { pieceColor: pieceColor, pieceType: pieceType, pieceId: pieceId }
                    let legalSquares = getPossibleMoves(startingSquareId, pieceObject, boardSquaresArray);
                    let legalSquaresJson = JSON.stringify(legalSquares);
                    touchLegal = legalSquaresJson;
                    // Получаем первое касание (touch)
                    var touch = ev.targetTouches[0];
                   
                    // Получаем начальные координаты элемента
                    var offsetX = touch.clientX;
                    var offsetY = touch.clientY;                 
                    let m = document.getElementById(piece.id);
                    let myMP = m.appendChild(pieceMoving);
                    pieceMoving.style.left = touch.clientX - offsetX + 'px';
                    pieceMoving.style.top = touch.clientY - offsetY + 'px';                    
                    var imgMoving = document.createElement("img");
                    imgMoving.src = "../../piece/" + pieceColor.charAt(0).toUpperCase() + pieceColor.slice(1).toString() + "-" + pieceType.charAt(0).toUpperCase() + pieceType.slice(1).toString() + ".png";
                    pieceMoving.appendChild(imgMoving);                    
                    
                    function moveElement(event) {
                        event.preventDefault();
                        var touch = event.changedTouches[0];                          
                                                                                               

                        pieceMoving.style.left = touch.clientX - offsetX + 'px';
                        pieceMoving.style.top = touch.clientY - offsetY + 'px';
                    }
                }
                function stopMoving(ev) {
                    if (!allowMoment) return;
                    var touch = ev.targetTouches[0];
                    
                    let isOpponentTurn = (isOpponentWhite && isWhiteTurn) || (!isOpponentWhite && !isWhiteTurn);
                    if (isOpponentTurn) return;
                    ev.preventDefault();
                    imgMoving.remove();
                    pieceMoving.remove();
                    var endTarget = document.elementFromPoint(
                        ev.changedTouches[0].clientX,
                        ev.changedTouches[0].clientY
                    );                   
                    if (!endTarget.classList.contains("square")) {
                        endTarget = endTarget.parentElement.parentElement;
                    }                   
                    const destinationSquare = endTarget;                  
                    let destinationSquareId = destinationSquare.id;

                    let data = touchText;
                    touchText = "";
                    let [pieceId, startingSquareId] = data.split("|");                   
                    displayMove(startingSquareId, destinationSquareId);
                    movableElement.removeEventListener('touchmove', moveElement);
                    movableElement.removeEventListener('touchend', stopMoving);
                }
                movableElement.addEventListener('touchmove', moveElement);
                movableElement.addEventListener('touchend', stopMoving);
            }
        });
        
        let row = 8 - Math.floor(i / 8);
        let column = String.fromCharCode(97 + (i % 8));
        let square = boardSquares[i];
        square.id = column + row;
    }
}
function setupPieces() {
    for (i = 0; i < pieces.length; i++) {
        pieces[i].addEventListener("dragstart", drag);        
        pieces[i].setAttribute("draggable", true);
        pieces[i].id = pieces[i].className.split(" ")[1] + pieces[i].parentElement.id;       
    }
    for (i = 0; i < piecesImages.length; i++) {       
        piecesImages[i].setAttribute("draggable", false);
    }
}
function allowDrop(ev) {
    ev.preventDefault();
}
function drag(ev) {      
    if (!allowMoment) return;
    const piece = ev.target;
    const pieceColor = piece.getAttribute("color");
    const pieceType = piece.classList[1];
    const pieceId = piece.id;
    if ((isWhiteTurn && pieceColor == "white") || (!isWhiteTurn && pieceColor == "black")) {
        const startingSquareId = piece.parentNode.id;
        ev.dataTransfer.setData("text", piece.id + "|" + startingSquareId);
        const pieceObject = { pieceColor: pieceColor, pieceType: pieceType, pieceId: pieceId }
        let legalSquares = getPossibleMoves(startingSquareId, pieceObject, boardSquaresArray);
        let legalSquaresJson = JSON.stringify(legalSquares);        
        ev.dataTransfer.setData("application/json", legalSquaresJson);
    }    
}
function drop(ev) {  
   
    if (!allowMoment) return;
    let isOpponentTurn = (isOpponentWhite && isWhiteTurn) || (!isOpponentWhite && !isWhiteTurn);    
    if (isOpponentTurn) return;
    ev.preventDefault();
    
    const destinationSquare = ev.currentTarget;
    let destinationSquareId = destinationSquare.id;    
    let data = ev.dataTransfer.getData("text");    
    let [pieceId, startingSquareId] = data.split("|");
    displayMove(startingSquareId, destinationSquareId);  
}
function touchDrop(ev) {   
    if (!allowMoment) return;
    let isOpponentTurn = (isOpponentWhite && isWhiteTurn) || (!isOpponentWhite && !isWhiteTurn);
    if (isOpponentTurn) return;
    ev.preventDefault();
    const destinationSquare = ev.currentTarget.parentElement;
    let destinationSquareId = destinationSquare.id;
    let data = touchText;
    touchText = "";      
    let [pieceId, startingSquareId] = data.split("|");
    displayMove(startingSquareId, destinationSquareId);
}
function performEnPassant(piece, pieceColor, startingSquareId, destinationSquareId) {    
    let file = destinationSquareId[0];
    let rank = parseInt(destinationSquareId[1]);
    rank += (pieceColor === "white") ? -1 : 1;
    let squareBehindId = file + rank;
    const squareBehindElement = document.getElementById(squareBehindId);   
    while (squareBehindElement.firstChild) {
        squareBehindElement.removeChild(squareBehindElement.firstChild);
    }
    let squareBehind = boardSquaresArray.find((element) => element.squareId === squareBehindId);
    squareBehind.pieceColor = "blank";
    squareBehind.pieceType = "blank";
    squareBehind.pieceId = "blank";
    const destinationSquare = document.getElementById(destinationSquareId);
    destinationSquare.appendChild(piece);
    isWhiteTurn = !isWhiteTurn;
    updatePGN(startingSquareId, destinationSquareId, isWhiteTurn);
    updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray);
    let captured = true;
    makeMove(startingSquareId, destinationSquareId, "pawn", pieceColor, captured);
    enPassantSquare = "blank";
    checkForEndGame();
    return;     
}
function performCastling(piece, pieceColor, startingSquareId, destinationSquareId, boardSquaresArray) {
    let rookId, rookDetinationSquareId, checkSquareId;
    if (destinationSquareId == "g1") {
        rookId = "rookh1";
        rookDetinationSquareId = "f1";
        checkSquareId = "f1";
    }else if (destinationSquareId == "c1") {
        rookId = "rooka1";
        rookDetinationSquareId = "d1";
        checkSquareId = "d1";
    }
    else if (destinationSquareId == "g8") {
        rookId = "rookh8";
        rookDetinationSquareId = "f8";
        checkSquareId = "f8";
    }
    else if (destinationSquareId == "c8") {
        rookId = "rooka8";
        rookDetinationSquareId = "d8";
        checkSquareId = "d8";
    }    
    if (IsKingInCheck(checkSquareId, pieceColor, boardSquaresArray)) return;
    let rook = document.getElementById(rookId);
    let rookDetinationSquare = document.getElementById(rookDetinationSquareId);
    rookDetinationSquare.appendChild(rook);
    updateBoardSquaresArray(rook.id.slice(-2), rookDetinationSquare.id, boardSquaresArray);
    const destinationSquare = document.getElementById(destinationSquareId);
    destinationSquare.appendChild(piece);
    isWhiteTurn = !isWhiteTurn;
    updatePGN(startingSquareId, destinationSquareId, isWhiteTurn);
    updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray);
    let captured = false;
    makeMove(startingSquareId, destinationSquareId, "king", pieceColor, captured);
    checkForEndGame();
    return;
}
function updateBoardSquaresArray(currentSquareId, destinationSquareId, boardSquaresArray, promotionOption = "blank") {    
    let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId);
    let destinationSquare = boardSquaresArray.find((element) => element.squareId === destinationSquareId);
    let pieceColor = currentSquare.pieceColor;
    let pieceType = promotionOption == "blank" ? currentSquare.pieceType : promotionOption;
    let pieceId = promotionOption == "blank" ? currentSquare.pieceId : promotionOption + currentSquare.pieceId;
    destinationSquare.pieceColor = pieceColor;
    destinationSquare.pieceType = pieceType;
    destinationSquare.pieceId = pieceId;
    currentSquare.pieceColor = "blank";
    currentSquare.pieceType = "blank";
    currentSquare.pieceId = "blank";   
}
function getPossibleMoves(startingSquareId, piece, boardSquaresArray) {
    const pieceColor = piece.pieceColor;
    const pieceType = piece.pieceType;
    let legalSquares = [];
    if (pieceType == "pawn") {
        legalSquares = getPawnMoves(startingSquareId, pieceColor, boardSquaresArray);
        return legalSquares;
    }
    if (pieceType == "knight") {
        legalSquares = getKnightMoves(startingSquareId, pieceColor, boardSquaresArray);
        return legalSquares;
    }
    if (pieceType == "rook") {
        legalSquares = getRookMoves(startingSquareId, pieceColor, boardSquaresArray);
        return legalSquares;
    }
    if (pieceType == "bishop") {
        legalSquares = getBishopMoves(startingSquareId, pieceColor, boardSquaresArray);
        return legalSquares;
    }
    if (pieceType == "queen") {
        legalSquares = getQueenMoves(startingSquareId, pieceColor, boardSquaresArray); 
        return legalSquares;
    }
    if (pieceType == "king") {
        legalSquares = getKingMoves(startingSquareId, pieceColor, boardSquaresArray);
        return legalSquares;
    }
}
function getPawnMoves(startingSquareId, pieceColor, boardSquaresArray) {
    let diagonalSquares = checkPawnDiagonalCaptures(startingSquareId, pieceColor, boardSquaresArray);
    let forwardSquares = checkPawnForwardMoves(startingSquareId, pieceColor, boardSquaresArray);
    let legalSquares = [...diagonalSquares, ...forwardSquares];
    return legalSquares;
}
function getKnightMoves(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charCodeAt(0)-97;
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let currentRank = rankNumber;
    let legalSquares = [];
    
    const moves = [
        [-2,1],[-1,2],[1,-2],[1,2],[2,-1],[-1,-2],[2,1],[-2,-1]
    ];
    moves.forEach((move) => {
        currentFile = file + move[0];
        currentRank = rankNumber + move[1];
        if (currentFile >= 0 && currentFile <= 7 && currentRank > 0 && currentRank <= 8) {
            let currentSquareId = String.fromCharCode(currentFile + 97) + currentRank;
            let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)            
            let squareContent = currentSquare.pieceColor;
            if (squareContent != "blank" && squareContent == pieceColor)
                return legalSquares;
            legalSquares.push(String.fromCharCode(currentFile + 97) + currentRank);
        }
    })
    return legalSquares;
}
function getRookMoves(startingSquareId, pieceColor, boardSquaresArra) {
    let moveToEighthRankSquares = moveToEighthRank(startingSquareId, pieceColor, boardSquaresArra);
    let moveToFirstRankSquares = moveToFirstRank(startingSquareId, pieceColor, boardSquaresArra);
    let moveToAFileSquares = moveToAFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToHFileSquares = moveToHFile(startingSquareId, pieceColor, boardSquaresArra);
    let legalSquares = [...moveToEighthRankSquares, ...moveToFirstRankSquares, ...moveToAFileSquares, ...moveToHFileSquares];
    return legalSquares;
}
function getBishopMoves(startingSquareId, pieceColor, boardSquaresArra) {
    let moveToEighthRankAFileSquares = moveToEighthRankAFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToEighthRankHFileSquares = moveToEighthRankHFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToFirstRankHFileSquares = moveToFirstRankHFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToFirstRankAFileSquares = moveToFirstRankAFile(startingSquareId, pieceColor, boardSquaresArra);
    let legalSquares = [...moveToEighthRankAFileSquares, ...moveToEighthRankHFileSquares, ...moveToFirstRankHFileSquares, ...moveToFirstRankAFileSquares];
    return legalSquares;
}
function getQueenMoves(startingSquareId, pieceColor, boardSquaresArra) {
    let moveToEighthRankSquares = moveToEighthRank(startingSquareId, pieceColor, boardSquaresArra);
    let moveToFirstRankSquares = moveToFirstRank(startingSquareId, pieceColor, boardSquaresArra);
    let moveToAFileSquares = moveToAFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToHFileSquares = moveToHFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToEighthRankAFileSquares = moveToEighthRankAFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToEighthRankHFileSquares = moveToEighthRankHFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToFirstRankHFileSquares = moveToFirstRankHFile(startingSquareId, pieceColor, boardSquaresArra);
    let moveToFirstRankAFileSquares = moveToFirstRankAFile(startingSquareId, pieceColor, boardSquaresArra);
    let legalSquares = [...moveToEighthRankSquares, ...moveToFirstRankSquares, ...moveToAFileSquares, ...moveToHFileSquares, ...moveToEighthRankAFileSquares,  ...moveToEighthRankHFileSquares, ...moveToFirstRankHFileSquares, ...moveToFirstRankAFileSquares];
    return legalSquares;
}
function getKingMoves(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charCodeAt(0) - 97;
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let currentRank = rankNumber;
    let legalSquares = [];
    const moves = [
        [0, 1], [0, -1], [1, 1], [1, -1], [-1, -1], [-1, 0], [1, 0], [-1, 1]
    ];
    moves.forEach((move) => {
        currentFile = file + move[0];
        currentRank = rankNumber + move[1];
        if (currentFile >= 0 && currentFile <= 7 && currentRank > 0 && currentRank <= 8) {
            let currentSquareId = String.fromCharCode(currentFile + 97) + currentRank;
            let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId);
            let squareContent = currentSquare.pieceColor;
            if (squareContent != "blank" && squareContent == pieceColor)
                return legalSquares;
            legalSquares.push(String.fromCharCode(currentFile + 97) + currentRank);
        }
    });
    let shortCastleSquare = isShortCastlePossible(pieceColor, boardSquaresArray);
    let longCastleSquare = isLongCastlePossible(pieceColor, boardSquaresArray);
    if (shortCastleSquare != "blank") legalSquares.push(shortCastleSquare);
    if (longCastleSquare != "blank") legalSquares.push(longCastleSquare);
    return legalSquares;
}
function moveToEighthRank(startingSquareId, pieceColor, boardSquaresArray) {    
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);    
    let currentRank = rankNumber;
    let legalSquares = [];
    while (currentRank != 8) {
        currentRank++;
        currentSquareId = file + currentRank;
        let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
        let squareContent = currentSquare.pieceColor;
        if (squareContent != "blank" && squareContent == pieceColor)
            return legalSquares;
            legalSquares.push(currentSquareId);
        if (squareContent != "blank" && squareContent != pieceColor)
            return legalSquares;
    }
    return legalSquares;
}
function moveToFirstRank(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentRank = rankNumber;
    let legalSquares = [];
    while (currentRank != 1) {
        currentRank--;
        currentSquareId = file + currentRank;
        let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
        let squareContent = currentSquare.pieceColor;
        if (squareContent != "blank" && squareContent == pieceColor)
            return legalSquares;
        legalSquares.push(currentSquareId);
        if (squareContent != "blank" && squareContent != pieceColor)
            return legalSquares;
    }
    return legalSquares;
}
function moveToAFile(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let legalSquares = [];
    while (currentFile != "a") {
        currentFile = String.fromCharCode(currentFile.charCodeAt(currentFile.length - 1) - 1);
        currentSquareId = currentFile + rank;
        let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
        let squareContent = currentSquare.pieceColor;
        if (squareContent != "blank" && squareContent == pieceColor)
            return legalSquares;
        legalSquares.push(currentSquareId);
        if (squareContent != "blank" && squareContent != pieceColor)
            return legalSquares;
    }
    return legalSquares;
}
function moveToHFile(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let legalSquares = [];
    while (currentFile != "h") {
        currentFile = String.fromCharCode(currentFile.charCodeAt(currentFile.length - 1) + 1);
        currentSquareId = currentFile + rank;
        let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
        let squareContent = currentSquare.pieceColor;
        if (squareContent != "blank" && squareContent == pieceColor)
            return legalSquares;
        legalSquares.push(currentSquareId);
        if (squareContent != "blank" && squareContent != pieceColor)
            return legalSquares;
    }
    return legalSquares;
}
function moveToEighthRankHFile(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let currentRank = rankNumber;
    let legalSquares = [];
    while (!(currentFile == "h" || currentRank == 8)) {
        currentFile = String.fromCharCode(currentFile.charCodeAt(currentFile.length - 1) + 1);
        currentRank++;
        currentSquareId = currentFile + currentRank;
        let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
        let squareContent = currentSquare.pieceColor;
        if (squareContent != "blank" && squareContent == pieceColor)
            return legalSquares;
        legalSquares.push(currentSquareId);
        if (squareContent != "blank" && squareContent != pieceColor)
            return legalSquares;
    }
    return legalSquares;
}
function moveToEighthRankAFile(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let currentRank = rankNumber;
    let legalSquares = [];
    while (!(currentFile == "a" || currentRank == 8)) {
        currentFile = String.fromCharCode(currentFile.charCodeAt(currentFile.length - 1) - 1);
        currentRank++;
        currentSquareId = currentFile + currentRank;
        let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
        let squareContent = currentSquare.pieceColor;
        if (squareContent != "blank" && squareContent == pieceColor)
            return legalSquares;
        legalSquares.push(currentSquareId);
        if (squareContent != "blank" && squareContent != pieceColor)
            return legalSquares;
    }
    return legalSquares;
}
function moveToFirstRankAFile(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let currentRank = rankNumber;
    let legalSquares = [];
    while (!(currentFile == "a" || currentRank == 1)) {
        currentFile = String.fromCharCode(currentFile.charCodeAt(currentFile.length - 1) - 1);
        currentRank--;
        currentSquareId = currentFile + currentRank;
        let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
        let squareContent = currentSquare.pieceColor;
        if (squareContent != "blank" && squareContent == pieceColor)
            return legalSquares;
        legalSquares.push(currentSquareId);
        if (squareContent != "blank" && squareContent != pieceColor)
            return legalSquares;
    }
    return legalSquares;
}
function moveToFirstRankHFile(startingSquareId, pieceColor, boardSquaresArray) {
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let currentRank = rankNumber;
    let legalSquares = [];
    while (!(currentFile == "h" || currentRank == 1)) {
        currentFile = String.fromCharCode(currentFile.charCodeAt(currentFile.length - 1) + 1);
        currentRank--;
        currentSquareId = currentFile + currentRank;
        let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
        let squareContent = currentSquare.pieceColor;
        if (squareContent != "blank" && squareContent == pieceColor)
            return legalSquares;
        legalSquares.push(currentSquareId);
        if (squareContent != "blank" && squareContent != pieceColor)
            return legalSquares;
    }
    return legalSquares;
}
function checkPawnDiagonalCaptures(startingSquareId, pieceColor,boardSquaresArray) {
    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let currentRank = rankNumber;
    let legalSquares = [];
    const direction = pieceColor == "white" ? 1 : -1;
    currentRank += direction;
    for (let i = -1; i <= 1; i += 2) {
        currentFile = String.fromCharCode(file.charCodeAt(0) + i);
        if (currentFile >= "a" && currentFile <= "h") {
            currentSquareId = currentFile + currentRank;
            let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId)
            let squareContent = currentSquare.pieceColor;
            if (squareContent != "blank" && squareContent != pieceColor) {
                legalSquares.push(currentSquareId);                
            }
            if (squareContent == "blank") {
                currentSquareId = currentFile + rank;
                let pawnStartingSquareRank = rankNumber + direction * 2;
                let pawnStartingSquareId = currentFile + pawnStartingSquareRank;               
                if (enPassantPossible(currentSquareId, pawnStartingSquareId, direction)) {
                    let pawnStartingSquareRank = rankNumber + direction;
                    let enPassantSquare = currentFile + pawnStartingSquareRank;
                    legalSquares.push(enPassantSquare);
                }
            }
        }
    }
    return legalSquares;
}
function checkPawnForwardMoves(startingSquareId, pieceColor, boardSquaresArray) {

    const file = startingSquareId.charAt(0);
    const rank = startingSquareId.charAt(1);
    const rankNumber = parseInt(rank);
    let currentFile = file;
    let currentRank = rankNumber;
    let legalSquares = [];
    const direction = pieceColor == "white" ? 1 : -1;
    currentRank += direction;    
    currentSquareId = currentFile + currentRank;    
    let currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId);
    let squareContent = currentSquare.pieceColor;
    if (squareContent != "blank")
        return legalSquares;           
    
    legalSquares.push(currentSquareId);
    
    if ((rankNumber != 2 && pieceColor == "white") || (rankNumber != 7 && pieceColor == "black"))
        return legalSquares;    
    currentRank += direction;
    currentSquareId = currentFile + currentRank;
    currentSquare = boardSquaresArray.find((element) => element.squareId === currentSquareId);
       
    squareContent = currentSquare.pieceColor;
    if (squareContent != "blank")
        return legalSquares;

    legalSquares.push(currentSquareId);
    return legalSquares;
}
function getPieceAtSquare(squareId, boardSquaresArray) {
    let currentSquare = boardSquaresArray.find((element) => element.squareId === squareId);    
    const color = currentSquare.pieceColor;
    const pieceType = currentSquare.pieceType;
    const pieceId = currentSquare.pieceId;
    return { pieceColor: color, pieceType: pieceType, pieceId: pieceId };

}
function isMoveValidAgainstCheck(legalSquares, startingSquareId, pieceColor, pieceType) {
    let kingSquare = isWhiteTurn ? getKingLastMove("white") : getKingLastMove("black");   
    
    let boardSquaresArrayCopy = deepCopyArray(boardSquaresArray);
    let legalSquaresCopy = legalSquares.slice();   
    legalSquaresCopy.forEach((element) => {
        let destinationId = element;
        boardSquaresArrayCopy = deepCopyArray(boardSquaresArray);
        updateBoardSquaresArray(startingSquareId, destinationId, boardSquaresArrayCopy);        
        if (pieceType != "king" && IsKingInCheck(kingSquare, pieceColor, boardSquaresArrayCopy)) {
            legalSquares = legalSquares.filter((item) => item != destinationId);
        }
        
        if (pieceType == "king" && IsKingInCheck(destinationId, pieceColor, boardSquaresArrayCopy)) {
            legalSquares = legalSquares.filter((item) => item != destinationId);
        }
    });   
    return legalSquares;
}
function IsKingInCheck(squareId, pieceColor, boardSquaresArray) {   
    let legalSquares = getRookMoves(squareId, pieceColor, boardSquaresArray);
    for (let squareId of legalSquares) {
        let pieceProperties = getPieceAtSquare(squareId, boardSquaresArray);       
        if ((pieceProperties.pieceType == "rook" || pieceProperties.pieceType == "queen") && pieceColor != pieceProperties.pieceColor) return true;
    }
    legalSquares = getBishopMoves(squareId, pieceColor, boardSquaresArray);
    for (let squareId of legalSquares) {
        let pieceProperties = getPieceAtSquare(squareId, boardSquaresArray);
        if ((pieceProperties.pieceType == "bishop" || pieceProperties.pieceType == "queen") && pieceColor != pieceProperties.pieceColor) return true;
    }
    legalSquares = checkPawnDiagonalCaptures(squareId, pieceColor, boardSquaresArray);
    for (let squareId of legalSquares) {
        let pieceProperties = getPieceAtSquare(squareId, boardSquaresArray);
        if ((pieceProperties.pieceType == "pawn") && pieceColor != pieceProperties.pieceColor) return true;
    }
    legalSquares = checkPawnForwardMoves(squareId, pieceColor, boardSquaresArray);
    for (let squareId of legalSquares) {
        let pieceProperties = getPieceAtSquare(squareId, boardSquaresArray);
        if ((pieceProperties.pieceType == "pawn") && pieceColor != pieceProperties.pieceColor) return true;
    }
    legalSquares = getKnightMoves(squareId, pieceColor, boardSquaresArray);
    for (let squareId of legalSquares) {
        let pieceProperties = getPieceAtSquare(squareId, boardSquaresArray);
        if ((pieceProperties.pieceType == "knight") && pieceColor != pieceProperties.pieceColor) return true;
    }
    legalSquares = getKingMoves(squareId, pieceColor, boardSquaresArray);
    for (let squareId of legalSquares) {
        let pieceProperties = getPieceAtSquare(squareId, boardSquaresArray);
        if ((pieceProperties.pieceType == "king") && pieceColor != pieceProperties.pieceColor) return true;
    }
    return false;
}
function isThreefoldRepetition() {
    return positionArray.some((string) => {
        const fen = string.split(" ").slice(0, 4).join(" ");
        return positionArray.filter((element) => element.split(" ").slice(0, 4).join(" ") === fen).length >= 3
    });
}
function hasInsufficientMaterial(fen) {
    const piecePlacement = fen.split(" ")[0];
    const whiteBishops = piecePlacement.split("").filter(char => char === "B").length;
    const blackBishops = piecePlacement.split("").filter(char => char === "b").length;
    const whiteKnights = piecePlacement.split("").filter(char => char === "N").length;
    const blackKnights = piecePlacement.split("").filter(char => char === "n").length;
    const whiteQueens = piecePlacement.split("").filter(char => char === "Q").length;
    const blackQueens = piecePlacement.split("").filter(char => char === "q").length;
    const whiteRooks = piecePlacement.split("").filter(char => char === "R").length;
    const blackRooks = piecePlacement.split("").filter(char => char === "r").length;
    const whitePawns = piecePlacement.split("").filter(char => char === "P").length;
    const blackPawns = piecePlacement.split("").filter(char => char === "p").length;

    if (whiteQueens + blackQueens + whiteRooks + blackRooks + whitePawns + blackPawns > 0) {
        return false;
    }
    if (whiteKnights + blackKnights > 1) {
        return false;
    }
    if (whiteKnights + blackKnights > 1) {
        return false;
    }
    if (whiteKnights + blackKnights > 1) {
        return false;
    }
    if ((whiteBishops > 0 || blackBishops > 0) && (whiteKnights + blackKnights > 0)) {
        return false;
    }
    if (whiteBishops > 1 || blackBishops > 1) {
        return false;
    }
    if (whiteBishops === 1 && blackBishops === 1) {
        let whiteBishopSquareColor, blackBishopSquareColor;
        let whiteBishopSquare = boardSquaresArray.find(element => (element.pieceType === "bishop" && element.pieceColor === "white"));
        let blackBishopSquare = boardSquaresArray.find(element => (element.pieceType === "bishop" && element.pieceColor === "black"));

        whiteBishopSquareColor = getSquareColor(whiteBishopSquare.squareId);
        blackBishopSquareColor = getSquareColor(blackBishopSquare.squareId);

        if (whiteBishopSquareColor != blackBishopSquareColor)
            return false;
    }
    return true;
}
function hasMaterialToMate(fen,color) {
    const piecePlacement = fen.split(" ")[0];
    const whiteBishops = piecePlacement.split("").filter(char => char === "B").length;
    const blackBishops = piecePlacement.split("").filter(char => char === "b").length;
    const whiteKnights = piecePlacement.split("").filter(char => char === "N").length;
    const blackKnights = piecePlacement.split("").filter(char => char === "n").length;
    const whiteQueens = piecePlacement.split("").filter(char => char === "Q").length;
    const blackQueens = piecePlacement.split("").filter(char => char === "q").length;
    const whiteRooks = piecePlacement.split("").filter(char => char === "R").length;
    const blackRooks = piecePlacement.split("").filter(char => char === "r").length;
    const whitePawns = piecePlacement.split("").filter(char => char === "P").length;
    const blackPawns = piecePlacement.split("").filter(char => char === "p").length;

    if (color == "white" && (whiteQueens + whiteRooks + whitePawns + whiteBishops) == 0 && (whiteKnights == 1)) {
        return false;
    }
    if (color == "black" && (blackQueens + blackRooks + blackPawns + blackBishops) == 0 && (blackKnights == 1)) {
        return false;
    }
    if (color == "white" && (whiteQueens + whiteRooks + whitePawns + whiteBishops) == 0 && (whiteKnights == 2 && (blackQueens + blackRooks + blackPawns + blackBishops + blackKnights) > 0)) {
        return false;
    }
    if (color == "black" && (blackQueens + blackRooks + blackPawns + blackBishops) == 0 && (blackKnights == 2 && (whiteQueens + whiteRooks + whitePawns + whiteBishops + whiteKnights) > 0)) {
        return false;
    }
    if (color == "black" && (blackQueens + blackRooks + blackPawns + blackBishops) == 0 && (blackKnights == 1)) {
        return false;
    }
    if (color == "white" && (whiteQueens + whiteRooks + whitePawns + whiteKnights) == 0 && (whiteBishops == 1)) {
        return false;
    }
    if (color == "black" && (blackQueens + blackRooks + blackPawns + blackKnights) == 0 && (blackBishops == 1)) {
        return false;
    }
    if (color == "white" && whiteQueens + whiteRooks + whitePawns + whiteBishops + whiteKnights == 0) {
        return false;
    }
    if (color == "black" && blackQueens + blackRooks + blackPawns + blackBishops + blackKnights == 0) {
        return false;
    }   
    return true;
}
function getSquareColor(squareId) {
    let squareElement = document.getElementById(squareId);
    let squareColor = squareElement.classList.contains("white") ? "white" : "black";
    return squareColor;
}
function checkForEndGame() {
    checkForCheckMateAndStaleMate();
    currentPosition = generateFEN(boardSquaresArray);
    sendFen(currentPosition);
    sendPgn(pgn);
    positionArray.push(currentPosition);
    let threeFoldRepetition = isThreefoldRepetition();
    let insuficientMaterial = hasInsufficientMaterial(currentPosition);
    let fiftyMovesRuleCount = currentPosition.split(" ")[4];
    let fiftyMovesRule = fiftyMovesRuleCount != 100 ? false : true;
    let isDraw = threeFoldRepetition || insuficientMaterial || fiftyMovesRule;
    if (isDraw) {
        if (!isRatingGame) {
            hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: "1/2-1/2" })
                .catch(function (err) {
                    return console.error(err.toString());
                });
        }
        clearInterval(intervalClock);
        showAlert("Ничья","1/2-1/2");
    }
}
resignButton.addEventListener("click", () => {    
    sendResign(player2.innerText);    
    
})
function checkForCheckMateAndStaleMate() {
    let kingSquare = isWhiteTurn ? getKingLastMove("white") : getKingLastMove("black");
    let pieceColor = isWhiteTurn ? "white" : "black";
    let boardSquaresArrayCopy = deepCopyArray(boardSquaresArray);    
    let kingIsCheck = IsKingInCheck(kingSquare, pieceColor, boardSquaresArrayCopy);    
    let possibleMoves = getAllPossibleMoves(boardSquaresArrayCopy, pieceColor);    
    if (possibleMoves.length > 0) return;
    let message = "";
    let res = "";
    if (kingIsCheck) {
        isWhiteTurn ? (message = "Черные победили!") : (message = "Белые победили!");
        res = !isWhiteTurn ? "1-0" : "0-1";
    }
    else {
        message = "Ничья";
        res = "1/2-1/2";
    }
    clearInterval(intervalClock);
    if (!isRatingGame) {
        hubConnection.invoke("Process", { type: "SaveRating", gameState: game, result: res })
            .catch(function (err) {
                return console.error(err.toString());
            });
    }
    showAlert(message,res);
}
function getAllPossibleMoves(squaresArray, color) {
    return squaresArray.filter((square) => square.pieceColor === color).flatMap((square) => {
        const { pieceColor, pieceType, pieceId } = getPieceAtSquare(square.squareId, squaresArray);
        if (pieceId == "blank") return [];
        let squaresArrayCopy = deepCopyArray(squaresArray);
        const pieceObject = { pieceColor: pieceColor, pieceType: pieceType, pieceId: pieceId };
        let legalSquares = getPossibleMoves(square.squareId, pieceObject, squaresArrayCopy);       
        legalSquares = isMoveValidAgainstCheck(legalSquares, square.squareId, pieceColor, pieceType);
        return legalSquares;
    });
}
function showAlert(message,res) {
    const alert = document.getElementById("alert");
    const result = document.getElementById("result");
    alert.innerHTML = message;
    alert.style.display = "block";
    result.innerHTML = res;
    result.style.display = "block";
    let color = "";
    if (res == "1-0") {
        color = "white"
    } 
    if (res == "0-1") {
        color = "black"
    } 
    stopPlayTik('audioTik');
    if (!allowMoment) return;
    if (!isRatingGame) {
        updateChangeRating(color);
    }
    allowMoment = false;
}
function getKingLastMove(color) {   
    let kingLastMove = moves.findLast(element => element.pieceType === "king" && element.pieceColor === color);    
    if (kingLastMove == undefined) 
        return isWhiteTurn ? "e1" : "e8";    
        return kingLastMove.to;    
}
function isShortCastlePossible(pieceColor,boardSquaresArray) {
    let rank = pieceColor === "white" ? "1" : "8";
    let fSquare = boardSquaresArray.find(element => element.squareId == `f${rank}`);
    let gSquare = boardSquaresArray.find(element => element.squareId == `g${rank}`);
    if (fSquare.pieceColor != "blank" || gSquare.pieceColor != "blank" || kingHasMoved(pieceColor) || rookHasMoved(pieceColor,`h${rank}`)) {
        return "blank";
    }
    return `g${rank}`;
}
function isLongCastlePossible(pieceColor, boardSquaresArray) {
    let rank = pieceColor === "white" ? "1" : "8";
    let dSquare = boardSquaresArray.find(element => element.squareId == `d${rank}`);
    let cSquare = boardSquaresArray.find(element => element.squareId == `c${rank}`);
    let bSquare = boardSquaresArray.find(element => element.squareId == `b${rank}`);
    if (dSquare.pieceColor != "blank" || cSquare.pieceColor != "blank" || bSquare.pieceColor != "blank" || kingHasMoved(pieceColor) || rookHasMoved(pieceColor, `a${rank}`)) {
        return "blank";
    }
    return `c${rank}`;
}
function kingHasMoved(pieceColor) {
    let result = moves.find((element) => (element.pieceColor === pieceColor) && (element.pieceType === "king"));
    if (result != undefined) return true;
    return false;
}
function rookHasMoved(pieceColor, startingSquareId) {
    let result = moves.find((element) => (element.pieceColor === pieceColor) && (element.pieceType === "rook") && (element.from == startingSquareId));
    if (result != undefined) return true;
    return false;
}
function enPassantPossible(currentSquareId, pawnStartingSquareId, direction) {   
    if (moves.length == 0)
        return false;
    let lastMove = moves[moves.length - 1];
    if (!(lastMove.to === currentSquareId && lastMove.from === pawnStartingSquareId && lastMove.pieceType == "pawn")) return false;
    file = currentSquareId[0];
    rank = parseInt(currentSquareId[1]);
    rank += direction;
    let squareBehindId = file + rank;
    enPassantSquare = squareBehindId;
    return true;
}
function displayObserverPromotionChoices(pieceId, pieceColor, startingSquareId, destinationSquareId, captured, promotedTo = "blank") {
    if (promotedTo != "blank") {       
        performPromotion(pieceId, promotedTo, pieceColor, startingSquareId, destinationSquareId, captured);
        return;
    }   
}
function displayPromotionChoices(pieceId, pieceColor, startingSquareId, destinationSquareId, captured, promotedTo = "blank") {    
    if (promotedTo != "blank") {
        performPromotion(pieceId, promotedTo, pieceColor, startingSquareId, destinationSquareId, captured);
        return;
    }
    let file = destinationSquareId[0];
    let rank = parseInt(destinationSquareId[1]);
    let rank1 = (pieceColor === "white") ? rank - 1 : rank + 1;
    let rank2 = (pieceColor === "white") ? rank - 2 : rank + 2;
    let rank3 = (pieceColor === "white") ? rank - 3 : rank + 3;

    let squareBehindId1 = file + rank1;
    let squareBehindId2 = file + rank2;
    let squareBehindId3 = file + rank3;

    let destinationSquare = document.getElementById(destinationSquareId);
    const squareBehind1 = document.getElementById(squareBehindId1);
    const squareBehind2 = document.getElementById(squareBehindId2);
    const squareBehind3 = document.getElementById(squareBehindId3);

    let piece1 = createChessPiece("queen", pieceColor, "promotionOption");
    let piece2 = createChessPiece("knight", pieceColor, "promotionOption");
    let piece3 = createChessPiece("rook", pieceColor, "promotionOption");
    let piece4 = createChessPiece("bishop", pieceColor, "promotionOption");

    destinationSquare.appendChild(piece1);
    squareBehind1.appendChild(piece2);
    squareBehind2.appendChild(piece3);
    squareBehind3.appendChild(piece4);
    let promotionOptions = document.getElementsByClassName("promotionOption");
    for (let i = 0; i < promotionOptions.length; i++) {
        let pieceType = promotionOptions[i].classList[1];
        promotionOptions[i].addEventListener("click", function () {
            performPromotion(pieceId, pieceType, pieceColor, startingSquareId, destinationSquareId, captured);
            sendMove(startingSquareId, destinationSquareId, pieceType);
        });
    }
}
function performPromotion(pieceId, pieceType, pieceColor, startingSquareId, destinationSquareId, captured) {
    clearPromotionOptions();   
    promotionPiece = pieceType;
    piece = createChessPiece(pieceType, pieceColor, "piece");
    piece.addEventListener("dragstart", drag);
    piece.setAttribute("draggable", true);
    piece.firstChild.setAttribute("draggable", false);
    piece.id = pieceType + pieceId;
    const startingSquare = document.getElementById(startingSquareId);
    while (startingSquare.firstChild) {
        startingSquare.removeChild(startingSquare.firstChild);
    }
    const destinationSquare = document.getElementById(destinationSquareId);    
    destinationSquare.appendChild(piece);
    if (captured) {
        let children = destinationSquare.children;
        for (let i = 0; i < children.length; i++) {
            if (!children[i].classList.contains("coordinate")) {
                destinationSquare.removeChild(children[i]);
            }
        }
    }
    isWhiteTurn = !isWhiteTurn;
    updatePGN(startingSquareId, destinationSquareId, isWhiteTurn, pieceType);
            updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray, pieceType);
            makeMove(startingSquareId, destinationSquareId, pieceType, pieceColor, captured, pieceType);
            checkForEndGame();
            return;
}
function createChessPiece(pieceType, color, pieceClass) {
    let pieceName = "https://chess-good.ru/piece/" + color.charAt(0).toUpperCase() + color.slice(1) + "-" + pieceType.charAt(0).toUpperCase() + pieceType.slice(1) + ".png";
    let pieceDiv = document.createElement("div");
    pieceDiv.className = `${pieceClass} ${pieceType}`;
    pieceDiv.setAttribute("color", color);
    let img = document.createElement("img");
    img.src = pieceName;
    img.alt = pieceType;
    if (isOpponentWhite) {
        img.style.transform = "rotate(180deg)";
    }
    pieceDiv.appendChild(img);
    return pieceDiv;
}
chessBoard.addEventListener("click", clearPromotionOptions);
function clearPromotionOptions() {
    for (let i = 0; i < boardSquares.length; i++) {
        let style = getComputedStyle(boardSquares[i]);
        let backgroundColor = style.backgroundColor;
        let rgbaColor = backgroundColor.replace("0.5)", "1)");
        boardSquares[i].style.backgroundColor = rgbaColor;
        boardSquares[i].style.opacity = 1;
    }
    let elementsToRemove = chessBoard.querySelectorAll(".promotionOption");
    elementsToRemove.forEach(function (element) {
        element.parentElement.removeChild(element);
    });
    allowMoment = true;
}
function updateBoardSquaresOpacity() {
    for (let i = 0; i < boardSquares.length; i++) {
        if (!(boardSquares[i].querySelector(".promotionOption"))) {
            boardSquares[i].style.opacity = 0.5;
        }
        else {
            let style = getComputedStyle(boardSquares[i]);
            let backgroundColor = style.backgroundColor;
            let rgbaColor = backgroundColor.replace("rgb", "rgba").replace(")", ",0.5)");
            boardSquares[i].style.backgroundColor = rgbaColor;
        }
    }
}
function getFiftyMovesRuleCount() {
    let count = 0;
    for (let i = 0; i < moves.length; i++) {
        count++;
        if (moves[i].captured || moves[i].pieceType === "pawn" || moves[i].promotedTo != "blank") {
            count = 0;
        }
    }
    return count;
}
function getEvaluation(fen, callback) {    
    const engine = new Worker("../../../node_modules/stockfish/src/stockfish-nnue-16.js");     
    let evaluations = [];
    let lines = [];
    let possibleMoves = 3;
    engine.onmessage = function (event) {        
        let message = event.data;
        
        if (message.startsWith("info depth 10")) {
            let multipvIndex = message.indexOf("multipv");
            if (multipvIndex != -1) {
                let multipvString = message.slice(multipvIndex).split(" ")[1];
                let multipv = parseInt(multipvString);
                let scoreIndex = message.indexOf("score cp");
                if (scoreIndex != -1) {
                    var scoreString = message.slice(scoreIndex).split(" ")[2];
                    let evaluation = parseInt(scoreString) / 100;
                    evaluation = isWhiteTurn ? evaluation : evaluation * -1;
                    evaluations[multipv - 1] = evaluation;
                }
                else {
                    scoreIndex = message.indexOf("score mate");
                    scoreString = message.slice(scoreIndex).split(" ")[2];
                    evaluation = parseInt(scoreString);
                    evaluation = Math.abs(evaluation);
                    evaluations[multipv - 1] = "#" + evaluation;
                };
                let pvIndex = message.indexOf(" pv ");
                if (pvIndex != -1) {
                    let pvString = message.slice(pvIndex + 4).split(" ");
                    lines[multipv - 1] = pvString.join(" ");
                    if (evaluations.length === possibleMoves && lines.length === possibleMoves) {
                        callback(lines, evaluations, scoreString);
                    }
                }
            }
        }
        if (message.startsWith("Nodes searched:")) {
            let parts = message.split(" ");
            let numberOfMoves = parseInt(parts[2]);
            if (numberOfMoves < 3) {
                possibleMoves = numberOfMoves;
                line1.innerHTML = ""; line2.innerHTML = ""; line3.innerHTML = "";
                eval1.innerHTML = ""; eval2.innerHTML = ""; eval3.innerHTML = "";
            }
        }
    };
    engine.onerror = function (error) {
        console.log('error',error);
    }
    engine.postMessage("uci");
    engine.postMessage("isready");
    engine.postMessage("ucinewgame");
    engine.postMessage("setoption name multipv value 3");
    engine.postMessage("position fen " + fen);
    engine.postMessage("go perft 1");
    engine.postMessage("go depth 10");    
}
function displayEval(lines, evaluations, scoreString, whiteTurn = true, moveNumber = 1) {   
    let blackBar = document.querySelector(".blackBar");
    let blackBarHeight = 50 - (evaluations[0] / 15) * 100;
    blackBarHeight = blackBarHeight > 100 ? (blackBarHeight = 100) : blackBarHeight;
    blackBarHeight = blackBarHeight < 0 ? (blackBarHeight = 0) : blackBarHeight;
    blackBar.style.height = blackBarHeight + "%";
    let evalNum = document.querySelector(".evalNum");
    evalNum.innerHTML = evaluations[0];
    for (let i = 0; i < lines.length; i++) {
        let eval = document.getElementById("eval" + (i + 1));
        let line = document.getElementById("line" + (i + 1));
        eval.innerHTML = evaluations[i];
        line.innerHTML = convertToStockfishToStandardNotation(lines[i],moveNumber,whiteTurn);
        document.getElementById("eval").innerHTML = evaluations[0];
        if (Math.abs(evaluations[0] < 0.5)) {
            document.getElementById("evalText").innerHTML = "Equal";
        }
        if (evaluations[0] < 1 && evaluations[0] >= 0.5) {
            document.getElementById("evalText").innerHTML = "У белых немного лучше";
        }
        if (evaluations[0] > -1 && evaluations[0] <= 0.5) {
            document.getElementById("evalText").innerHTML = "У черных немного лучше";
        }
        if (evaluations[0] < 2 && evaluations[0] >= 1) {
            document.getElementById("evalText").innerHTML = "У белых намного лучше";
        }
        if (evaluations[0] > -2 && evaluations[0] <= 1) {
            document.getElementById("evalText").innerHTML = "У черных намного лучше";
        }
        if (evaluations[0] > 2) {
            document.getElementById("evalText").innerHTML = "Белые выигрывают";
        }
        if (evaluations[0] < -2) {
            document.getElementById("evalText").innerHTML = "Черные выигрывают";
        }
        if (evaluations[0].toString().includes("#")) {
            const mateInMoves = evaluations[0].slice(1);
            const isWhiteWinning = (parseInt(scoreString) > 0 && isWhiteTurn) || (parseInt(scoreString) < 0 && !isWhiteTurn);
            const winningColor = isWhiteWinning ? "White" : "Black";
            document.getElementById("evalText").innerHTML = `${winningColor} могут поставить мат в ${mateInMoves} ходов`;
            blackBarHeight = isWhiteWinning ? 0 : 100;
            blackBar.style.height = blackBarHeight + "%";
        }
    }    
}
function convertToStockfishToStandardNotation(stockfishMoves, moveNumber, whiteTurn) {
    let standardMoves = "";
    let moves = stockfishMoves.split(" ");
    let boardSquaresArayCopy = deepCopyArray(boardSquaresArray);
    for (let i = 0; i < moves.length; i++) {
        let move = moves[i];
        let from = move.substring(0, 2);
        let to = move.substring(2, 4);
        let promotion = move.length > 4 ? move.charAt(4) : null;
        let fromSquare = boardSquaresArayCopy.find(square => square.squareId === from);
        let toSquare = getPieceAtSquare(to, boardSquaresArayCopy);
        if (fromSquare && toSquare) {
            let fromPiece = fromSquare.pieceType;
            switch (fromPiece.toLowerCase()) {
                case "pawn":
                    fromPiece = "";
                    break;
                case "knight":
                    fromPiece = "N";
                    break;
                case "bishop":
                    fromPiece = "B";
                    break;
                case "rook":
                    fromPiece = "R";
                    break;
                case "queen":
                    fromPiece = "Q";
                    break;
                case "king":
                    fromPiece = "K";
                    break;
            }
            let captureSymbol = "";
            if ((toSquare.pieceType != "blank") || (toSquare.pieceType == "blank" && fromSquare.pieceType.toLowerCase() === "pawn" && from.charAt(0) != to.charAt(0))) {
                captureSymbol = "x";
                if (fromSquare.pieceType.toLowerCase() === "pawn") {
                    fromPiece = from.charAt(0);
                }
            }

            let standardMove = `${fromPiece}${captureSymbol}${to}`;
            if (promotion) {
                switch (promotion.toLowerCase()) {
                    case "q":
                        standardMove += "=Q";
                        break;
                    case "r":
                        standardMove += "=R";
                        break;
                    case "b":
                        standardMove += "=B";
                        break;
                    case "n":
                        standardMove += "=N";
                        break;
                }
            }
            let kingColor = fromSquare.pieceColor == "white" ? "black" : "white";
            let kingSquareId = getKingSquare(kingColor, boardSquaresArayCopy);
            updateBoardSquaresArray(from, to, boardSquaresArayCopy);
            if (IsKingInCheck(kingSquareId, kingColor, boardSquaresArayCopy)) {
                if ((standardMove === "Kg8" && fromSquare.squareId == "e8") || (standardMove === "Kg1" && fromSquare.squareId == "e1")) {
                    standardMove = "0-0";
                }
                if ((standardMove === "Kc8" && fromSquare.squareId == "e8") || (standardMove === "Kc1" && fromSquare.squareId == "e1")) {
                    standardMove = "0-0-0";
                }                
            }
                standardMoves += `${(whiteTurn && i % 2 == 0) || (!whiteTurn && i % 2 == 1) ? " " + moveNumber++ + "." : " "}${standardMove}`;
                if (!whiteTurn && i == 0) standardMoves = `${moveNumber + ". ..."}${standardMove} `;
        }
    }   
    return standardMoves.trim();
}
function convertToStandardNotation(move) {
    let standardMove = "";    
    let boardSquaresArayCopy = deepCopyArray(boardSquaresArray);
           
        let from = move.substring(0, 2);
        let to = move.substring(2, 4);
        let promotion = move.length > 4 ? move.charAt(4) : null;
        let fromSquare = boardSquaresArayCopy.find(square => square.squareId === from);
        let toSquare = getPieceAtSquare(to, boardSquaresArayCopy);
        if (fromSquare && toSquare) {
            let fromPiece = fromSquare.pieceType;
            switch (fromPiece.toLowerCase()) {
                case "pawn":
                    fromPiece = "";
                    break;
                case "knight":
                    fromPiece = "N";
                    break;
                case "bishop":
                    fromPiece = "B";
                    break;
                case "rook":
                    fromPiece = "R";
                    break;
                case "queen":
                    fromPiece = "Q";
                    break;
                case "king":
                    fromPiece = "K";
                    break;
            }
            let captureSymbol = "";
            if ((toSquare.pieceType != "blank") || (toSquare.pieceType == "blank" && fromSquare.pieceType.toLowerCase() === "pawn" && from.charAt(0) != to.charAt(0))) {
                captureSymbol = "x";
                if (fromSquare.pieceType.toLowerCase() === "pawn") {
                    fromPiece = from.charAt(0);
                }
            }
            standardMove = `${fromPiece}${captureSymbol}${to}`;

            if (promotion) {
                switch (promotion.toLowerCase()) {
                    case "q":
                        standardMove += "=Q";
                        break;
                    case "r":
                        standardMove += "=R";
                        break;
                    case "b":
                        standardMove += "=B";
                        break;
                    case "n":
                        standardMove += "=N";
                        break;
                }
            }
            let kingColor = fromSquare.pieceColor == "white" ? "black" : "white";
            let kingSquareId = getKingSquare(kingColor, boardSquaresArayCopy);
            updateBoardSquaresArray(from, to, boardSquaresArayCopy);
            if (IsKingInCheck(kingSquareId, kingColor, boardSquaresArayCopy)) {
                standardMove += "+";
            }
                if ((standardMove === "Kg8" && fromSquare.squareId == "e8") || (standardMove === "Kg1" && fromSquare.squareId == "e1")) {
                    standardMove = "0-0";
                }
                if ((standardMove === "Kc8" && fromSquare.squareId == "e8") || (standardMove === "Kc1" && fromSquare.squareId == "e1")) {
                    standardMove = "0-0-0";
                }
                        
        }    
    return standardMove.trim();
}
function getKingSquare(color, squareArray) {
    let kingSquare = squareArray.find(square => square.pieceType.toLowerCase() === "king" && square.pieceColor === color);
    return kingSquare ? kingSquare.squareId : null;
}
function displayObserverMove(startingSquareId, destinationSquareId, promotedTo = "blank") {
    
    const pieceObject = getPieceAtSquare(startingSquareId, boardSquaresArray);   
    const piece = document.getElementById(pieceObject.pieceId);
    if (!piece) return;
   
    const pieceId = pieceObject.pieceId;
    const pieceColor = pieceObject.pieceColor;
    const pieceType = pieceObject.pieceType;
    let destinationSquare = document.getElementById(destinationSquareId);
    let squareContent = getPieceAtSquare(destinationSquareId, boardSquaresArray)
    if (squareContent.pieceColor == "blank") {
        let isCheck = false;
        if (pieceType == "king") {
            isCheck = IsKingInCheck(startingSquareId, pieceColor, boardSquaresArray);
        }
        if (pieceType == "king" && !kingHasMoved(pieceColor) && castlingSquares.includes(destinationSquareId) && !isCheck) {
            performCastling(piece, pieceColor, startingSquareId, destinationSquareId, boardSquaresArray);            
            return;
        }
        if (pieceType == "king" && !kingHasMoved(pieceColor) && castlingSquares.includes(destinationSquareId) && isCheck) {
            return;
        }
        if (pieceType == "pawn" && enPassantSquare == destinationSquareId) {
            performEnPassant(piece, pieceColor, startingSquareId, destinationSquareId);            
            return;
        }
        enPassantSquare = "blank";
        if (pieceType == "pawn" && (destinationSquareId.charAt(1) == "8" || destinationSquareId.charAt(1) == "1")) {
            displayObserverPromotionChoices(pieceId, pieceColor, startingSquareId, destinationSquareId, false, promotedTo);
            return;
        }
        let children = destinationSquare.children;
        for (let i = 0; i < children.length; i++) {
            if (!children[i].classList.contains("coordinate")) {
                destinationSquare.removeChild(children[i]);
            }
        }
        destinationSquare.appendChild(piece);               
        isWhiteTurn = !isWhiteTurn;
        updatePGN(startingSquareId, destinationSquareId, isWhiteTurn);
        updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray);
        let captured = false;
        makeMove(startingSquareId, destinationSquareId, pieceType, pieceColor, captured);        
        checkForEndGame();
        return;
    }
    if ((squareContent.pieceColor != "blank")) {
        if (pieceType == "pawn" && (destinationSquareId.charAt(1) == "8" || destinationSquareId.charAt(1) == "1")) { 
            displayObserverPromotionChoices(pieceId, pieceColor, startingSquareId, destinationSquareId, true, promotedTo);
            return;
        }
        let children = destinationSquare.children;
        for (let i = 0; i < children.length; i++) {
            if (!children[i].classList.contains("coordinate")) {
                destinationSquare.removeChild(children[i]);
            }
        }        
        destinationSquare.appendChild(piece);
        isWhiteTurn = !isWhiteTurn;
        updatePGN(startingSquareId, destinationSquareId, isWhiteTurn);
        updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray);
        let captured = true;
        makeMove(startingSquareId, destinationSquareId, pieceType, pieceColor, captured);      
        checkForEndGame();
        return;
    }
}
function displayMove(startingSquareId, destinationSquareId, promotedTo = "blank") {    
    const pieceObject = getPieceAtSquare(startingSquareId, boardSquaresArray);
    const piece = document.getElementById(pieceObject.pieceId);
    const pieceId = pieceObject.pieceId;
    const pieceColor = pieceObject.pieceColor;
    const pieceType = pieceObject.pieceType;
    let destinationSquare = document.getElementById(destinationSquareId);
    let legalSquares = getPossibleMoves(startingSquareId, pieceObject, boardSquaresArray);

    legalSquares = isMoveValidAgainstCheck(legalSquares, startingSquareId, pieceColor, pieceType);    
    if (pieceType == "king") {
        let isCheck = IsKingInCheck(destinationSquareId, pieceColor, boardSquaresArray);
        if (isCheck) return;

    }
    let squareContent = getPieceAtSquare(destinationSquareId, boardSquaresArray)
    if (squareContent.pieceColor == "blank" && legalSquares.includes(destinationSquareId)) {
        let isCheck = false;
        if (pieceType == "king") {
            isCheck = IsKingInCheck(startingSquareId, pieceColor, boardSquaresArray);
        }
        if (pieceType == "king" && !kingHasMoved(pieceColor) && castlingSquares.includes(destinationSquareId) && !isCheck) {
            performCastling(piece, pieceColor, startingSquareId, destinationSquareId, boardSquaresArray);
            sendMove(startingSquareId, destinationSquareId);
            return;
        }
        if (pieceType == "king" && !kingHasMoved(pieceColor) && castlingSquares.includes(destinationSquareId) && isCheck) {
            return;
        }
        if (pieceType == "pawn" && enPassantSquare == destinationSquareId) {
            performEnPassant(piece, pieceColor, startingSquareId, destinationSquareId); 
            sendMove(startingSquareId, destinationSquareId);
            return;
        }
        enPassantSquare = "blank";
        if (pieceType == "pawn" && (destinationSquareId.charAt(1) == "8" || destinationSquareId.charAt(1) == "1")) {
            allowMoment = false;
            displayPromotionChoices(pieceId, pieceColor, startingSquareId, destinationSquareId, false, promotedTo);
            if (promotedTo == "blank")
                updateBoardSquaresOpacity(startingSquareId);
            return;
        }
        destinationSquare.appendChild(piece);
        let startingSquare = document.getElementById(startingSquareId);
        startingSquare.classList.add("lastMoveSquare");
        destinationSquare.classList.add("lastMoveSquare");
        isWhiteTurn = !isWhiteTurn;        
        updatePGN(startingSquareId, destinationSquareId, isWhiteTurn);
        updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray);
        let captured = false;
        makeMove(startingSquareId, destinationSquareId, pieceType, pieceColor, captured);        
        sendMove(startingSquareId, destinationSquareId);
        checkForEndGame();
        return;
    }
    if ((squareContent.pieceColor != "blank") && (legalSquares.includes(destinationSquareId))) {
        if (pieceType == "pawn" && (destinationSquareId.charAt(1) == "8" || destinationSquareId.charAt(1) == "1")) {
            allowMoment = false;
            displayPromotionChoices(pieceId, pieceColor, startingSquareId, destinationSquareId, true, promotedTo);
            if (promotedTo === "blank")
            updateBoardSquaresOpacity(startingSquareId);
            return;
        }
        let children = destinationSquare.children;
        for (let i = 0; i < children.length; i++) {
            if (!children[i].classList.contains("coordinate")) {
                destinationSquare.removeChild(children[i]);
            }
        }        
        destinationSquare.appendChild(piece);
        isWhiteTurn = !isWhiteTurn;         
        updatePGN(startingSquareId, destinationSquareId, isWhiteTurn);
        updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray);
        let captured = true;
        makeMove(startingSquareId, destinationSquareId, pieceType, pieceColor, captured);
        sendMove(startingSquareId, destinationSquareId);
        checkForEndGame();
        return;
    }
}
function displayCurrentMove(startingSquareId, destinationSquareId, promotedTo = "blank") {
    const pieceObject = getPieceAtSquare(startingSquareId, boardSquaresArray);
    const piece = document.getElementById(pieceObject.pieceId);
    const pieceId = pieceObject.pieceId;
    const pieceColor = pieceObject.pieceColor;
    const pieceType = pieceObject.pieceType;
    let destinationSquare = document.getElementById(destinationSquareId);
    let legalSquares = getPossibleMoves(startingSquareId, pieceObject, boardSquaresArray);

    legalSquares = isMoveValidAgainstCheck(legalSquares, startingSquareId, pieceColor, pieceType);
    if (pieceType == "king") {
        let isCheck = IsKingInCheck(destinationSquareId, pieceColor, boardSquaresArray);
        if (isCheck) return;

    }
    let squareContent = getPieceAtSquare(destinationSquareId, boardSquaresArray)
    if (squareContent.pieceColor == "blank" && legalSquares.includes(destinationSquareId)) {
        let isCheck = false;
        if (pieceType == "king") {
            isCheck = IsKingInCheck(startingSquareId, pieceColor, boardSquaresArray);
        }
        if (pieceType == "king" && !kingHasMoved(pieceColor) && castlingSquares.includes(destinationSquareId) && !isCheck) {
            performCastling(piece, pieceColor, startingSquareId, destinationSquareId, boardSquaresArray);
            sendCurrentMove(startingSquareId, destinationSquareId);
            return;
        }
        if (pieceType == "king" && !kingHasMoved(pieceColor) && castlingSquares.includes(destinationSquareId) && isCheck) {
            return;
        }
        if (pieceType == "pawn" && enPassantSquare == destinationSquareId) {
            performEnPassant(piece, pieceColor, startingSquareId, destinationSquareId);
            sendCurrentMove(startingSquareId, destinationSquareId);
            return;
        }
        enPassantSquare = "blank";
        if (pieceType == "pawn" && (destinationSquareId.charAt(1) == "8" || destinationSquareId.charAt(1) == "1")) {
            allowMoment = false;
            displayPromotionChoices(pieceId, pieceColor, startingSquareId, destinationSquareId, false, promotedTo);
            if (promotedTo == "blank")
                updateBoardSquaresOpacity(startingSquareId);
            return;
        }
        destinationSquare.appendChild(piece);
        let startingSquare = document.getElementById(startingSquareId);
        startingSquare.classList.add("lastMoveSquare");
        destinationSquare.classList.add("lastMoveSquare");
        isWhiteTurn = !isWhiteTurn;
        updatePGN(startingSquareId, destinationSquareId, isWhiteTurn);
        updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray);
        let captured = false;
        makeMove(startingSquareId, destinationSquareId, pieceType, pieceColor, captured);
        sendCurrentMove(startingSquareId, destinationSquareId);
        checkForEndGame();
        return;
    }
    if ((squareContent.pieceColor != "blank") && (legalSquares.includes(destinationSquareId))) {
        if (pieceType == "pawn" && (destinationSquareId.charAt(1) == "8" || destinationSquareId.charAt(1) == "1")) {
            allowMoment = false;
            displayPromotionChoices(pieceId, pieceColor, startingSquareId, destinationSquareId, true, promotedTo);
            if (promotedTo === "blank")
                updateBoardSquaresOpacity(startingSquareId);
            return;
        }
        let children = destinationSquare.children;
        for (let i = 0; i < children.length; i++) {
            if (!children[i].classList.contains("coordinate")) {
                destinationSquare.removeChild(children[i]);
            }
        }
        destinationSquare.appendChild(piece);
        isWhiteTurn = !isWhiteTurn;
        updatePGN(startingSquareId, destinationSquareId, isWhiteTurn);
        updateBoardSquaresArray(startingSquareId, destinationSquareId, boardSquaresArray);
        let captured = true;
        makeMove(startingSquareId, destinationSquareId, pieceType, pieceColor, captured);
        sendCurrentMove(startingSquareId, destinationSquareId);
        checkForEndGame();
        return;
    }
}
function updatePGN(startingSquareId, destinationSquareId, whiteTurn, promotedTo = "") {
    let move = startingSquareId + destinationSquareId + promotedTo;
    let standardMove = convertToStandardNotation(move);    
    let moveNumber = moves.length / 2 + 1;
    if (whiteTurn) {
        let newMove = createMoveElement(standardMove, "playerMove");
        pgnContainer.appendChild(newMove);
        pgn += " " + standardMove;
    }
    else {
        let number = createMoveElement(moveNumber, "moveNumber");
        let newMove = createMoveElement(standardMove, "playerMove");
        pgnContainer.appendChild(number);
        pgnContainer.appendChild(newMove);
        pgn += " " + moveNumber + "." + standardMove;
    }
    pgnContainer.scrollTop = pgnContainer.scrollHeight;
}
function createMoveElement(standardMove, elementClass) {
    let playerMove = document.createElement("div");
    playerMove.classList.add(elementClass);
    playerMove.innerHTML = standardMove;
    return playerMove;
}
function recreateHTMLFromPGN(pgn) {
    pgnContainer.innerHTML = "";
    let moveArray = pgn.trim().split(/\s+/);
    let moveNumber = 1;    
    for (let i = 0; i < moveArray.length; i++) {
        if (moveArray[i].includes(".")) {
            let number = createMoveElement(moveNumber, "moveNumber");
            let newMove = createMoveElement(moveArray[i].split(".")[1], "playerMove");
            pgnContainer.appendChild(number);
            pgnContainer.appendChild(newMove);            
            moveNumber++;
        } else {
            let newMove = createMoveElement(moveArray[i], "playerMove");
            pgnContainer.appendChild(newMove);
        }        
    }
    pgnContainer.scrollTop = pgnContainer.scrollHeight;
}
//window.addEventListener('resize', () => {   
//    if (window.innerHeight > 750) {
//        chessBoard.style.height = Math.floor((600 / window.innerHeight) * 100) + "vh";
//        chessBoard.style.width = Math.floor((600 / window.innerWidth) * 100) + "vw";
//        counter.style.left = "200px";
//        counter.style.top = "200px";
//    }
//    else if (window.innerHeight < 650 && window.innerHeight > 550) {
//        chessBoard.style.height = Math.floor((400 / window.innerHeight) * 100) + "vh";
//        chessBoard.style.width = Math.floor((400 / window.innerWidth) * 100) + "vw";
//        counter.style.left = "150px";
//        counter.style.top = "150px";
//    }
//    else if (window.innerHeight < 650 && window.innerHeight > 550) {
//        chessBoard.style.height = Math.floor((400 / window.innerHeight) * 100) + "vh";
//        chessBoard.style.width = Math.floor((400 / window.innerWidth) * 100) + "vw";
//        counter.style.left = "120px";
//        counter.style.top = "120px";
//    }
//});


//function getBestMove(fen,callback) {
//    let engine = new Worker("./node_modules/stockfish/src/stockfish-nnue-16.js");
//    engine.onmessage = function (event) {
//        let message = event.data;
//        if (message.startsWith("bestmove")) {
//            let bestMove = event.data.split(" ")[1];
//            callback(bestMove);
//            engine.terminate();
//        }
//    };
//    engine.postMessage("position fen " + fen);
//    engine.postMessage(`go depth ${selectedLevel}`);
//}
//function playBestMove(bestMove) {
//    let startingSquareId = bestMove.substring(0, 2);
//    let destinationSquareId = bestMove.substring(2, 4);
//    let promotedTo = "";
//    if (bestMove.length === 5) {
//        promotedTo = bestMove.substring(4, 5);
//        let pieceMap = {
//            "q": "queen",
//            "r": "rook",
//            "n": "knight",
//            "b": "bishop"
//        };
//        promotedTo = pieceMap[promotedTo];
//    }
//    displayMove(startingSquareId, destinationSquareId, promotedTo);
//}
var elBoard = document.querySelector('.board');
var elchessBoard = document.querySelector('.chessBoard');
var elBoardPlayerInfo = document.querySelector('.infoBoard');
var elBoardPlayerInfo = document.querySelector('.infoBoard');
var elGamePlayerInfo = document.querySelector('#gamePlayerInfo');
var elGamePlayerTopInfo = document.querySelector('#gamePlayerTopInfo');
var elGamePlayerBottomInfo = document.querySelector('#gamePlayerBottomInfo');
var startX, startY, startWidth, startHeight, startWidthCB, startHeightCB, startWidthGPI, startHeightGPI, startWidthGPTI, startWidthGPBI;
function initDrag(e) {
    startX = e.clientX;
    startY = e.clientY;   
    startWidth = parseInt(document.defaultView.getComputedStyle(elBoard).width, 10);
    startHeight = parseInt(document.defaultView.getComputedStyle(elBoard).height, 10);
    startWidthCB = parseInt(document.defaultView.getComputedStyle(elchessBoard).width, 10);
    startHeightCB = parseInt(document.defaultView.getComputedStyle(elchessBoard).height, 10);   
    
    document.documentElement.addEventListener('mousemove', doDrag, false);
    document.documentElement.addEventListener('mouseup', stopDrag, false);
}
function initDragPlayInfo(e) {
    startX = e.clientX;
    startY = e.clientY;
    startWidth = parseInt(document.defaultView.getComputedStyle(elBoardPlayerInfo).width, 10);
    startHeight = parseInt(document.defaultView.getComputedStyle(elBoardPlayerInfo).height, 10);
    startWidthGPI = parseInt(document.defaultView.getComputedStyle(elGamePlayerInfo).width, 10);
    startHeightGPI = parseInt(document.defaultView.getComputedStyle(elGamePlayerInfo).height, 10);    
    document.documentElement.addEventListener('mousemove', doDragInfo, false);
    document.documentElement.addEventListener('mouseup', stopDragInfo, false);
}
function doDrag(e) {
    elBoard.style.width = (startWidth + e.clientX - startX) + 'px';
    elBoard.style.height = (startHeight + e.clientY - startY) + 'px';
    elchessBoard.style.width = (startWidthCB + e.clientX - startX) + 'px';
    elchessBoard.style.height = (startHeightCB + e.clientY - startY) + 'px';    
}
function stopDrag(e) {
    document.documentElement.removeEventListener('mousemove', doDrag, false);
    document.documentElement.removeEventListener('mouseup', stopDrag, false);
}
function doDragInfo(e) {
    elBoardPlayerInfo.style.width = (startWidth + e.clientX - startX) + 'px';
    elBoardPlayerInfo.style.height = (startHeight + e.clientY - startY) + 'px';
    elGamePlayerInfo.style.width = (startWidthGPI + e.clientX - startX) + 'px';
    elGamePlayerInfo.style.height = (startHeightGPI + e.clientY - startY) + 'px';
}
function stopDragInfo(e) {
    document.documentElement.removeEventListener('mousemove', doDragInfo, false);
    document.documentElement.removeEventListener('mouseup', stopDragInfo, false);
}
function playSound(sound) {
    var sound = document.getElementById(sound);
    sound.volume = 0.1;
    sound.play();
}
function playTik(clockTik) {
    var sound = document.getElementById(clockTik);
    sound.volume = 0.5;
    sound.loop = true;
    sound.play();
}
function stopPlayTik(clockTik) {
    var sound = document.getElementById(clockTik);    
    sound.pause();
}
function SelectRatingGame() {    
    
    isRatingGame = !isRatingGame;
    switchRating.checked = isRatingGame ? "" : "checked";
    
    if (isRatingGame) {
        isRating.innerText = "Товарищеская";
        typeRating.innerText = "Товарищеская";
    }
    else {
        isRating.innerText = "Рейтинговая";
        typeRating.innerText = "Рейтинговая";
    }
}
function addResizeBtn(el) {
    let resizeBtn = document.createElement("div");
    resizeBtn.classList.add("resize");
    el.appendChild(resizeBtn);
    resizeBtn.addEventListener('mousedown', initDrag, false);
}
function addResizeInfoBtn(el) {
    let resizeBtn = document.createElement("div");
    resizeBtn.classList.add("resize");
    el.appendChild(resizeBtn);
    resizeBtn.addEventListener('mousedown', initDragPlayInfo, false);
}