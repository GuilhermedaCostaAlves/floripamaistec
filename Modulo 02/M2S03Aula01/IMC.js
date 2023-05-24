
function calcularIMC(peso, altura) {
    altura = altura / 100;
    
    var imc = peso / (altura * altura);

    imc = imc.toFixed(2);
  
    return imc;
  }

  var peso = 140; 
  var altura = 185;
  
  var imc = calcularIMC(peso, altura);
  
  console.log("O seu IMC é: " + imc);
  