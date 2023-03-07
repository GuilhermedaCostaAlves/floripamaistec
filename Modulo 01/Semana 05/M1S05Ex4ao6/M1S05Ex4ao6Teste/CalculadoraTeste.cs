using M1S05Ex4ao6.Classe;
using M1S05Ex4ao6.Classes;
using Xunit;

namespace M1S05Ex4ao6Teste
{
    public class CalculadoraTeste
    {
        [Fact]
        [Trait("Categoria", "Somar")]
        public void TesteMetodoSomarint()
        {
            int resultado = Calculadora.Somar(20, 20);
            int esperado = 40;
            Assert.Equal(esperado, resultado);
        }[Fact]
        [Trait("Categoria", "Somar")]
        public void TesteMetodoSomarDouble()
        {
            double resultado = Calculadora.Somar(8.5, 20);
            double esperado = 28.5;
            Assert.Equal(esperado, resultado);
        }[Fact]
        [Trait("Categoria", "Somar")]
        public void TesteMetodoSomarFloat()
        {
            float resultado = Calculadora.Somar(8.5f, 20f);
            float esperado = 28.5f;
            Assert.Equal(esperado, resultado);
        }[Fact]
        [Trait("Categoria", "Somar")]
        public void TesteMetodoSomarDecimal()
        {
            decimal resultado = Calculadora.Somar(8.5M, 20M);
            decimal esperado = 28.5M;
            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "Somar")]
        [InlineData(50000, 50000, 100000)]
        [InlineData(70000, 20000, 90000)]
        public void TesteMetodoSomarLong(long numero1, long numero2, long esperado)
        {
            long resultado = Calculadora.Somar(numero1, numero2);

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestMetodoSubtrairInt()
        {
            int resultado = Calculadora.Subtracao(10, 5);

            int esperado = 5;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestMetodoSubtrairDouble()
        {
            double resultado = Calculadora.Subtracao(5.5, 5.48);

            double esperado = 0.02;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestMetodoSubtrairFloat()
        {
            float resultado = Calculadora.Subtracao(5.5f, 5.48f);

            float esperado = 0.02f;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Subtrair")]
        public void TestMetodoSubtrairDecimal()
        {
            decimal resultado = Calculadora.Subtracao(5.5M, 5.48M);

            decimal esperado = 0.02M;

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "Subtrair")]
        [InlineData(120000, 50000, 70000)]
        [InlineData(70000, 20000, 50000)]
        public void TestMetodoSubtrairLong(long numero1, long numero2, long esperado)
        {
            long resultado = Calculadora.Subtracao(numero1, numero2);

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoInt()
        {
            int resultado = Calculadora.Multiplicacao(10, 5);

            int esperado = 50;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoDouble()
        {
            double resultado = Calculadora.Multiplicacao(5.5, 5.48);

            double esperado = 30.14;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoFloat()
        {
            float resultado = Calculadora.Multiplicacao(5.5f, 5.48f);

            float esperado = 30.14f;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Multiplicacao")]
        public void TestMetodoMultiplicacaoDecimal()
        {
            decimal resultado = Calculadora.Multiplicacao(5.5M, 5.48M);

            decimal esperado = 30.14M;

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "Multiplicacao")]
        [InlineData(120000, 50000, 6000000000)]
        [InlineData(70000, 20000, 1400000000)]
        public void TestMetodoMultiplicacaoLong(long numero1, long numero2, long esperado)
        {
            long resultado = Calculadora.Multiplicacao(numero1, numero2);

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoInt()
        {
            int resultado = Calculadora.Divisao(10, 5);

            int esperado = 2;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoDouble()
        {
            double resultado = Calculadora.Divisao(20.5, 5.00);

            double esperado = 4.1;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoFloat()
        {
            float resultado = Calculadora.Divisao(20.5f, 5.00f);

            float esperado = 4.1f;

            Assert.Equal(esperado, resultado);
        }

        [Fact]
        [Trait("Categoria", "Divisao")]
        public void TestMetodoDivisaoDecimal()
        {
            decimal resultado = Calculadora.Divisao(20.5M, 5.00M);

            decimal esperado = 4.1M;

            Assert.Equal(esperado, resultado);
        }

        [Theory]
        [Trait("Categoria", "Divisao")]
        [InlineData(100000, 50000, 2)]
        [InlineData(80000, 20000, 4)]
        public void TestMetodoDivisaoLong(long numero1, long numero2, long esperado)
        {
            long resultado = Calculadora.Divisao(numero1, numero2);

            Assert.Equal(esperado, resultado);
        }
    }
}