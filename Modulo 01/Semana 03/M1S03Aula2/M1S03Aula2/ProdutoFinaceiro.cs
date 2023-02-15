using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1S03Aula2.Entidades;

namespace M1S03Aula2
{
    internal class ProdutoFinaceiro : Produto
    {
        public void acesso() 
        {
            ProdutoFinaceiro PF1 = new ProdutoFinaceiro();
            PF1.nome = "Produto dentro classe produto financeiro";
            PF1.cor = "Verde";
            Console.WriteLine("Nome: " + PF1.nome + "\nCor: " + PF1.cor);
            PF1.vender();
            PF1.verificarEstoque();
            PF1.alteraAtributosPrivados(99, 100.0);
        }
    }
}
