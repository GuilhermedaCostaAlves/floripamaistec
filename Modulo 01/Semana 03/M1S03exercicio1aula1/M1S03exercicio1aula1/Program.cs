using M1S03exercicio1aula1;

Produto produto1 = new Produto("Calculadora", 5.75, 199);

Produto produto2 = new Produto();

Console.WriteLine($"O produto 1 tem nome: {produto1.nome}.\n\nValor: {produto1.preco}.\n\nQuantidade: {produto1.quantidade}.");

Console.WriteLine($"\nO produto 2 tem nome: {produto2.nome}.\n\nValor: {produto2.preco}.\n\nQuantidade: {produto2.quantidade}.");