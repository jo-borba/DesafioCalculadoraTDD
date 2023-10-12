namespace CalculadoraProject
{
    public class Calculadora
    {
        private readonly List<string> historico;
        private readonly DateTime data;

        public Calculadora(DateTime data)
        {
            historico = new List<string>();
            this.data = data;
        }

        public int Somar(int v1, int v2)
        {
            var resultado = v1 + v2;
            historico.Insert(0, $"Resultado em {data}: {resultado}");
            return v1 + v2;
        }

        public int Subtrair(int v1, int v2)
        {
            var resultado = v1 - v2;
            historico.Insert(0, $"Resultado em {data}: {resultado}");
            return resultado;
        }

        public int Multiplicar(int v1, int v2)
        {
            var resultado = v1 * v2;
            historico.Insert(0, $"Resultado em {data}: {resultado}");
            return resultado;
        }

        public int Dividir(int v1, int v2)
        {
            var resultado = v1 / v2;
            historico.Insert(0, $"Resultado em {data}: {resultado}");
            return resultado;
        }

        public List<string> ObtemHistorico()
        {
            historico.RemoveRange(3, historico.Count - 3);
            return historico;
        }
    }
}
