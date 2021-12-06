export function showAlert(msg){
    console.log("showAlert()");
    alert(`msg : ${msg}`);
};

export let user = {
    nickName : 'clann',
    age : 33
}

export function sayHi(user) {
  alert(`Hello, ${user}!`);
}