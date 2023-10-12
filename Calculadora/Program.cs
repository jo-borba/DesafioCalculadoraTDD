using CalculadoraProject;


var calc = new Calculadora(DateTime.Now);

calc.Somar(3, 20);
calc.Subtrair(3, 1);
calc.Multiplicar(3, 3);
calc.Dividir(15, 3);
calc.Dividir(27, 3);
calc.Subtrair(27, 3);

List<string> lista = calc.ObtemHistorico();

foreach (var item in lista)
{
    Console.WriteLine(item);
}