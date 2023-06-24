function calcularMaior() {
    let numero = document.getElementById('numero').value
    let result = numero

    if (result < 10){
        document.getElementById('result').innerHTML =  "O número é menor que 10."
    } 
    else if (result == 10){
        document.getElementById('result').innerHTML =  "O número é 10."
    }
    else{
        document.getElementById('result').innerHTML = "O número é maior que 10."
    }
}