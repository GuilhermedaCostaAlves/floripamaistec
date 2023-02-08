int[] numeros = new int[10];
int contador_impar = 0;
int contador_par = 0;

for (int i = 0; i < numeros.Length; i++)
{
    int numero;

    Console.WriteLine($"Digite o {i + 1} número: ");
    numero = int.Parse(Console.ReadLine());
    numeros[i] = numero;

    if (numero % 2 == 0)
    {
        contador_par++;
    }
    else
        contador_impar++;
}
int[] numeros_pares = new int[contador_par];
int[] numeros_impares = new int[contador_impar];
int contador_p = 0;
int contador_i = 0;

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        numeros_pares[contador_p] = numeros[i];
        contador_p++;
    }
    else
    {
        numeros_impares[contador_i] = numeros[i];
        contador_i++;
    }
}

if (contador_p == 0)
{
    Console.WriteLine("\nNenhum número foi digitado na lista de pares.\n");
}
else
{
    Console.WriteLine($"\nA soma dos numeros pares é: {numeros_pares.Sum()}.\n");
    Array.Sort(numeros_pares);
    for (int i = 0; i < numeros_pares.Length; i++)
    {
        Console.WriteLine(numeros_pares[i]);
    }
}
if (contador_i == 0)
{
    Console.WriteLine("\nNenhum número foi digitado na lista de impares.\n");
}
else
{
    Console.WriteLine($"\nA soma dos numeros impares é: {numeros_impares.Sum()}.\n");
    Array.Sort(numeros_impares);
    for (int i = 0; i < numeros_impares.Length; i++)
    {
        Console.WriteLine(numeros_impares[i]);
    }
}