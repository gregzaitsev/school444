
function tableClickHandler(ev) {
    console.log('', ev.srcElement.id);
    ev.srcElement.style.backgroundColor = liveColor;
}

function createUniverse() {
    var body = document.getElementById('container');
    var tbl = document.createElement('table');
    tbl.style.width = cellSize*N + 'px';
    tbl.style.height = cellSize*N + 'px';
    tbl.className = "universeTable";
    tbl.setAttribute('border', '1');
    var tbdy = document.createElement('tbody');
    for (var i = 0; i < N; i++) {
        var tr = document.createElement('tr');
        for (var j = 0; j < N; j++) {
            var td = document.createElement('td');
            td.id = `${i*N + j}`;
            td.onclick = tableClickHandler;
            tr.appendChild(td)
        }
        tbdy.appendChild(tr);
    }
    tbl.appendChild(tbdy);
    body.appendChild(tbl)
}
