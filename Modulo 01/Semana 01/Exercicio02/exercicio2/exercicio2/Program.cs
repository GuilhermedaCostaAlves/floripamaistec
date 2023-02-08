List<string> frutas = new List<string>();

bool continuar = true;

while (continuar)
{
    if (frutas.Count() == 15)
    {
        continuar = false;
        break;
    }
    Console.Write("Digite o nome de uma fruta: ");
    frutas.Add(Console.ReadLine());
    Console.Write("Você deja continuar? ");
    string resposta = Console.ReadLine();

    if (resposta == "nao" || resposta == "n")
    {
        continuar = false;
    }
}
frutas.Sort();

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}