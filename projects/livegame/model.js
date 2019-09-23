const N = 20;
const cellSize = 20;
const deadColor = "#000";
const liveColor = "#0F0"

let state = [];

for (let i=0; i<N; i++) {
    state.push([]);
    for (let j=0; j<N; j++) {
        state[i][j] = 0;
    }
}

state[1][1] = 1;
