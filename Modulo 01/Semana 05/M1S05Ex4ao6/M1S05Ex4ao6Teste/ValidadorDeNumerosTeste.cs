using M1S05Ex4ao6;
using M1S05Ex4ao6.Classes;
using Xunit;
using M1S05Ex4ao6.Classe;

namespace M1S05Ex4ao6Teste
{
    public class ValidadorDeNumerosTeste
    {
        [Fact]
        public void TesteEhNumeroPrimo()
        {
            bool resultado = ValidadorDeNumeros.EhNumeroPrimo(29);
            Assert.True(resultado);
        }
        [Fact]
        public void TesteParOuImpar()
        {
            string resultado = ValidadorDeNumeros.ParOuImpar(29);
            string esperado = "Impar";
            Assert.Equal(esperado, resultado);
        }
        [Fact]
        public void TesteEhDivisivelPor()
        {
            bool resultado = ValidadorDeNumeros.EhDivisivelPor(81, 9);
            Assert.True(resultado);
        }
    }
}