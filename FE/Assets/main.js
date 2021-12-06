// import {user} from "./alert";
import {sayHi} from "./alert.js";

sayHi("clann");

let incomes = [1000, 2000, 3000];

for(var income of incomes){
    income += 5000;
    console.log(income);
}
console.log(incomes)

// function showImportContent(){
//     console.log(user);
// }