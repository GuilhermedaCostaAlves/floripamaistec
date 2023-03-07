using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1S05Ex4ao6.Classes;

namespace M1S05Ex4ao6.Classe
{
    public static class ValidadorDeNumeros
    {
        /// <summary>
        /// Verifica se um número é primo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool EhNumeroPrimo(int numero)
        {
            int contador = 1;

            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador++;
                }
            }
            if (contador == 2)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica se um número é par ou ímpar
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static string ParOuImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                return "O número é par";
            }
            return "o número é impar";
        }

        /// <summary>
        /// Verifica se um número é divisível por outro
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static bool EhDivisivelPor(int dividendo, int divisor)
        {
            if ((dividendo % divisor) == 0)
            {
                return true;
            }
            return false;
        }
    }
}
