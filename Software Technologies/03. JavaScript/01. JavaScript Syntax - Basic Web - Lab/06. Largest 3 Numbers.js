/**
 * Created by Admin on 31.3.2017 г..
 */
function solve(args) {

args = args.map(Number).sort((a, b) => b - a);

let total = Math.min(args.length, 3);

for (let i = 0; i < total; i++){

    console.log(args[i]);
  }
}

solve([
    '10',
    '30',
    '15',
    '20',
    '50',
    '5'
]);