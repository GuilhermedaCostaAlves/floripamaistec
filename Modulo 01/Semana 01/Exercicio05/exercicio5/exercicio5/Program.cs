int numero;
int x = 1,y = 0, z = 0;

Console.Write("Digite a quantidade de somas que deseja fazer: ");

numero = int.Parse(Console.ReadLine());

for (int i = 0; i < numero; i++)
{
    z = x + y;
    Console.WriteLine(z);
    y = x;
    x = z;
}