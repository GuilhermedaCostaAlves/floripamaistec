using System.Security.Cryptography.X509Certificates;
using M1S02Aula4;
namespace M1S02Aula4.ContaBancaria
{
    public class ContaBancaria

    {
        public long numeros;
        public int agencia;
        public string nomeTitular;
        public decimal saldo = 0;
        public Tipocontaenum tipoConta;

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                {
                    Console.WriteLine("O valor deve ser maior que 0.");
                }
                else
                {
                    saldo = saldo + valor;
                }
            }
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que 0.");

            }
            else if(valor > saldo)
            {
                Console.WriteLine("O valor digitado é maior que seu saldo atual!");

            }
            else
            {
                saldo = saldo - valor;
            }
            }
       public void ExibirSaldo()
       {
            Console.WriteLine($"O saldo atual da sua conta é: {saldo}");
       }
    }
}
