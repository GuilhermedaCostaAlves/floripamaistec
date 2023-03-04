try
{
    string texto = "Teste";

    int numero = Convert.ToInt32(texto);

    int resultado = 100 / numero;

    Console.Write($"O resultado de 100 dividido por {numero} é: {resultado}");
}

catch(DivideByZeroException ex)
{
    Console.WriteLine($"O número informado não pode ser zero, informe outro número");
}

catch (FormatException ex)
{
    Console.WriteLine($"O formato de número informado é invalido. Informe outro valor");
}

catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}