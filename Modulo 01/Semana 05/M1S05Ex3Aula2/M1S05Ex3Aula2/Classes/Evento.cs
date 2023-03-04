namespace M1S05Ex3Aula2.Classes
{
    internal class Evento
    {
        int qtdLugares;
        int qtdIngressoVendidos;

        public Evento()
        {  
        }
        public int QtdLugares { get; set; }
        public int QtdIngressosVendidos { get; set; }

        public void ingressoVendido()
        {
            Console.WriteLine("Ingresso vendido com sucesso!!");
        }
    }
}
