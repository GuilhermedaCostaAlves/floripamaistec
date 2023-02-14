using System.Security.Cryptography.X509Certificates;
using M1S02Aula4.ContaBancaria;
using M1S02Aula4;

ContaBancaria contaBancaria = new ContaBancaria();

contaBancaria.numeros = 1234;
contaBancaria.agencia = 5678;
contaBancaria.nomeTitular = "Oz Ozborne";
contaBancaria.tipoConta = Tipocontaenum.POUPANCA;

contaBancaria.Depositar(500);

contaBancaria.Sacar(150);

contaBancaria.ExibirSaldo();


