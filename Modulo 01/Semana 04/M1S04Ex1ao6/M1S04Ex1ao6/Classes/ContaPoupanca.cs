using M1S04Ex1ao6.Classes;
namespace M1S04Ex1ao6.Classes
{
    internal class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != tipoPessoa.FISICA) 
            {
                throw new ArgumentException("Cliente deve ser do tipo física!");
            }
        }
        public override void Sacar(decimal valor) 
        {
            valor = valor + 0.10M;
            base.Sacar(valor);
        }
        public override void Transferir(ContaBancaria conta, decimal valor)
        {
            valor = valor + 0.05M;
            base.Transferir(conta, valor);
        }
    }
}
