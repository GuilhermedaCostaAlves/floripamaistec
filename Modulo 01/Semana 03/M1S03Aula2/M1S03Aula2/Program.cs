using M1S03Aula2;
using M1S03Aula2.Entidades;

Produto produto1 = new Produto();

produto1.nome = "Calculadora";
produto1.verificarEstoque();

Console.WriteLine("O nome do produto é: " + produto1.nome);

Console.WriteLine("----- Abaixo será valores e ações de uma classe filha-----\n\n");

ProdutoFinaceiro classeFilha = new ProdutoFinaceiro();

classeFilha.nome = "Produto Financeiro";
classeFilha.verificarEstoque();

classeFilha.acesso();
