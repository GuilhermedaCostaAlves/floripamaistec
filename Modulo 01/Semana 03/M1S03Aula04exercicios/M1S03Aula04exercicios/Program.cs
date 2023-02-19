using M1S02Aula4.ContaBancaria;
using M1S03Aula04exercicios;


ContaBancaria contaBancaria1 = new ContaBancaria(1234,5678,"Oz Ozborne", Tipocontaenum.POUPANCA);
ContaBancaria contaBancaria2 = new ContaBancaria(1287, 1558,"Oz Ozborne", Tipocontaenum.POUPANCA);

/*contaBancaria.numeros = 1234;
contaBancaria.agencia = 5678;
contaBancaria.nomeTitular = "Oz Ozborne";
contaBancaria.tipoConta = Tipocontaenum.POUPANCA;

contaBancaria.Depositar(500);

contaBancaria.Sacar(150);

contaBancaria.ExibirSaldo();*/

contaBancaria1.Depositar(255.67M);

contaBancaria1.Transferir(contaBancaria2, 55.67M);

contaBancaria1.ExibirSaldo();

contaBancaria2.ExibirSaldo();


