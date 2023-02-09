string[] nomes_alunos = new string[5];
int[,] notas_aluno = new int[5,2] ;
int[] medias = new int[5] ;


for (int i = 0; i <5 ;i++ )
{
    
    Console.WriteLine($"Digite o nome do {i+1}º aluno: ");
    nomes_alunos[i] = Console.ReadLine();
}
for (int i = 0; i < 5; i++)
{
    for (int j =0; j<2; j++)
    {
        Console.WriteLine($"Digite a {j+1} nota do aluno {nomes_alunos[i]}: ");
        notas_aluno[i,j] = int.Parse( Console.ReadLine() );
        
    }
}
for (int i = 0;i < 5;i++)
{
    medias[i] = (notas_aluno[i,0] + notas_aluno[i, 1]) / 2;
    if (medias[i] < 6)
    {
        Console.WriteLine($"Aluno {nomes_alunos[i]} reprovou. A média dele foi {medias[i]}.");
    }
    else
    {
        Console.WriteLine($"Aluno {nomes_alunos[i]} aprovado. A média dele foi {medias[i]}.");
    }
}