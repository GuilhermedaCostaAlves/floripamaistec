class Animal {
    constructor(tipo, nome, tamanho, cor, idade){
    this.tipo = tipo;
    this.nome = nome;
    this.tamanho = tamanho;
    this.cor = cor;
    this.idade = idade;
    }
    dormir(){
        console.log(this.nome,  "Está dormindo.");
    }

    comer(comida){
        console.log(this.nome,'está comendo ',comida)
    }
    static respirar (){
        console.log('O animal está respirando.')
    }
}

var cachorro = new Animal('cachorro','Agatha','Médio','Branca','2')
var gato = new Animal('gato','suki','pequeno','Branca','2')

cachorro.dormir();
gato.comer(arroz);
Animal.respirar();