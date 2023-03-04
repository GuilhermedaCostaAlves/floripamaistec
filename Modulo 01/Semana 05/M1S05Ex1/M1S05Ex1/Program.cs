int numero1 = 0;
int numero2 = 0;
float resultado = 0;

try
{

    Console.WriteLine("Digite o primeiro número: ");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    numero2 = int.Parse(Console.ReadLine());
    resultado = numero1 / numero2;
    Console.WriteLine($"O resultado da divisão é: {resultado}");
}

catch (DivideByZeroException ex)
{
    Console.WriteLine($"O número informado não pode ser zero, informe outro número");
}
catch (FormatException ex)
{
    Console.WriteLine($"O formato de número informado é invalido. Informe outro valor");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

finally
{
    Console.WriteLine("Fim do programa.");
    numero1 = 0;
    numero2 = 0;
}
