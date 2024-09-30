using System.Globalization;

namespace ExercicioDeFixacao04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            var cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            var quantidadeDaCompraEmDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorASerPago = ConversorDeMoeda.CalculoValorAPagar(cotacaoDolar, quantidadeDaCompraEmDolar);

            Console.Write($"Valor a ser pago em reais = {valorASerPago.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}