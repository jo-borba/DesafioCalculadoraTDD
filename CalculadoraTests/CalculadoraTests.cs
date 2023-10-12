using CalculadoraProject;

namespace CalculadoraTests
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;

        public CalculadoraTests()
        {
            _calculadora = new Calculadora(DateTime.Now);
        }

        [Theory]
        [InlineData(1,2,3)]
        [InlineData(8,1,9)]
        [InlineData(2,2,4)]
        public void Somar(int v1, int v2, int resultadoEsperado)
        {
            Assert.Equal(_calculadora.Somar(v1, v2), resultadoEsperado);
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(10, 1, 9)]
        [InlineData(6, 2, 4)]
        public void Subtrair(int v1, int v2, int resultadoEsperado)
        {
            Assert.Equal(_calculadora.Subtrair(v1,v2), resultadoEsperado);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(3, 3, 9)]
        [InlineData(6, 3, 18)]
        public void Multiplicar(int v1, int v2, int resultadoEsperado)
        {
            Assert.Equal(_calculadora.Multiplicar(v1,v2), resultadoEsperado);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(8, 2, 4)]
        [InlineData(9, 3, 3)]
        public void Dividir(int v1, int v2, int resultadoEsperado)
        {
            Assert.Equal(_calculadora.Dividir(v1,v2), resultadoEsperado);
        }

        [Fact]
        public void DividirPorZero()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(3,0));
        }

        [Fact]
        public void ObterHistorico()
        {
            _calculadora.Somar(3, 5);
            _calculadora.Dividir(20, 5);
            _calculadora.Subtrair(20, 5);
            _calculadora.Multiplicar(8, 8);
            _calculadora.Multiplicar(2, 8);
            _calculadora.Multiplicar(9, 8);

            var lista = _calculadora.ObtemHistorico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}