var ws = null;
window.onload = function () {
    if (Modernizr.websockets) {
        WriteMessage('support', 'да')
        document.getElementById('bstart').disabled = false;
        document.getElementById('bstop').disabled = true;
    }
}

function WriteMessage(idspan, txt) {
    document.getElementById(idspan).innerHTML = txt;
}

function exe_start() {
    if (ws == null) {
        ws = new WebSocket('ws://localhost:62306/websockets.websocket');
        ws.onopen = function () {
            ws.send('Соединение')
        }
        ws.onclose = function (s) {
            console.log('onclose', s);
        }
        ws.onmessage = function (evt) {
            ta.innerHTML += '\n' + evt.data;
        }
        document.getElementById('bstart').disabled = true;
        document.getElementById('bstop').disabled = false;
    }
}

function exe_stop() {
    ws.close(3001, 'stopapplication');
    ws = null;
    document.getElementById('bstart').disabled = false;
    document.getElementById('bstop').disabled = true;
}