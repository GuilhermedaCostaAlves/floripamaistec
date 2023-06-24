function SomarNumeros(){
    var numero = document.getElementById('numero').value
    var numero2 = document.getElementById('numero2').value
    numero = parseFloat(numero)
    numero2 = parseFloat(numero2)

    var result = numero + numero2

    document.getElementById("result").textContent = "Resultado: " + result;
}