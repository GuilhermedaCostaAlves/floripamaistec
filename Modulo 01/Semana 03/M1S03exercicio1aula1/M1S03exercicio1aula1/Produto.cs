﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace M1S03exercicio1aula1
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public Produto()
        {
            nome = "Sem nome";
            preco = 0;
            quantidade = 0;
        }
    }
}
