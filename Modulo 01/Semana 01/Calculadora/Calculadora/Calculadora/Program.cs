// Importação de bibliotecas
// Nome da classe
// Declaração de método

// Declaração de variáveis

int opcao, numero1 = 0, numero2 = 0;
float resultado = 0;

// Emtradas

Console.WriteLine("Escolha uma operação: \n\n" +
    "1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\n5 - Resto\n" +
    "6 - Sair \n\nDigite a opção escolhida:");
opcao = int.Parse(Console.ReadLine());

// Processamento
switch (opcao)
{

    //Bloco de instruções da estrutura condicional
    case 1:
        Console.WriteLine("Operação somar.");
        Console.WriteLine("\nDigite o número 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o número 2:");
        numero2 = int.Parse(Console.ReadLine());
        Console.Write("\nO resultado da soma é:\n");
        resultado = numero1 + numero2;
        break;
    case 2:
        Console.WriteLine("Operação subtrair.");
        Console.WriteLine("\nDigite o número 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o número 2:");
        numero2 = int.Parse(Console.ReadLine());
        Console.Write("\nO resultado da subtração é:\n");
        resultado = numero1 - numero2;
        break;
    case 3:
        Console.WriteLine("\nDigite o número 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o número 2:");
        numero2 = int.Parse(Console.ReadLine());
        Console.Write("\nO resultado da multiplicação é:\n");
        resultado = numero1 * numero2;
        break;
    case 4:
        Console.WriteLine("\nDigite o número 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o número 2:");
        numero2 = int.Parse(Console.ReadLine());
        Console.Write("\nO resultado da divisão é:\n");
        resultado = numero1 / numero2;
        break;
    case 5:
        Console.WriteLine("\nDigite o número 1: ");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("\nDigite o número 2:");
        numero2 = int.Parse(Console.ReadLine());
        Console.Write("\nO resto é:\n");
        resultado = numero1 % numero2;
        break;
    case 6:
        Console.WriteLine("\nSaindo do sistema");
        break;
}
Console.WriteLine(resultado);
// Saídas

