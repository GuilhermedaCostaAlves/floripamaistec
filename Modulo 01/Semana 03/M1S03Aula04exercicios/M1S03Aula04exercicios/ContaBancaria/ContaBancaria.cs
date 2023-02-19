using M1S03Aula04exercicios;
namespace M1S02Aula4.ContaBancaria
{
    public class ContaBancaria

    {
        /* numeros alterado de "long" para "int" e " váriavel alterado para estrutura mais convencional*/

        private int _numeros;
        private int _agencia;
        private string _nomeTitular;
        private decimal _saldo = 0;
        private Tipocontaenum _tipoConta;

        public ContaBancaria(int numeros, int agencia, string nomeTitular, Tipocontaenum tipoConta)
        {
            _numeros = numeros;
            _agencia = agencia;
            _nomeTitular = nomeTitular;
            _tipoConta = tipoConta;
        }

        public ContaBancaria(string nomeTitular, Tipocontaenum tipoConta)
        {
           Random random = new Random();
            _numeros = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);
            _nomeTitular = nomeTitular;
            _tipoConta = tipoConta;
        }

        public void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que 0.");
                return;
            }
            if (valor > _saldo)
            {
                Console.WriteLine("Transação negada, saldo insuficiente");
                return;
            }
            
            
            _saldo = _saldo - valor;
            conta.Depositar(valor);
            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que 0.");
                return;
            }
            
            else
            {
                _saldo = _saldo + valor;
            }
        }
        public void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor deve ser maior que 0.");
                return;

            }
            
            else if (valor > _saldo)
            {
                Console.WriteLine("O valor digitado é maior que seu saldo atual!");
                return;

            }
            else
            {
                _saldo = _saldo - valor;
            }
        }
        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da sua conta é: {_saldo}");
        }
    }
}
