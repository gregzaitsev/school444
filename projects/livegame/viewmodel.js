
// TODO: Редактирование начального состояния
function tableClickHandler(ev) {
    // Эти две строчки не нужны, их нужно удалить
    console.log('', ev.srcElement.id);
    ev.srcElement.style.backgroundColor = liveColor;

    // TODO: В переменной ev.srcElement.id приходит идентификатор ячейки.
    // Это порядковый номер ячейки как если бы их все пронумеровали слева направо
    // и затем в каждой строчке слева направо вот так:
    //
    //    0  1  2
    //    3  4  5
    //    6  7  8
    //
    // В этой функции нужно преобразовать этот ID (строку) в порядковый номер (число),
    // найти по этому порядковому номеру координаты ячейки x и y и поменять состояние
    // ячейки state[y][x]. Если состояние равно 1, то установить его в 0, а если оно равно 0,
    // то установить его в 1. (одним словом - поменять ;))


    // TODO:
    // А вот тут нужно вызвать вашу функцию отображения состояния. В этом примере она называется
    // displayState.



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
    body.appendChild(tbl);

    displayState();
}

// Отображение состояния
// TODO: Уже сделано, вам нужно только вызывать эту функцию в нужных местах
function displayState() {
    for (let i=0; i<N; i++) {
        for (let j=0; j<N; j++) {
            let cell = document.getElementById(`${i*N+j}`);
            if (state[i][j] == 1)
                cell.style.backgroundColor = liveColor;
            else
                cell.style.backgroundColor = deadColor;
        }
    }
}

// TODO: Запуск игры
// ... а вот тут нужно объявить функции - обработчики нажатий кнопок запуска и остановки игры
