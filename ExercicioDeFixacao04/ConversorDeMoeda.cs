namespace ExercicioDeFixacao04
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.00;

        public static double CalculoValorAPagar(double cotacaoDolar, double quantidadeDaCompraEmDolar)
        {
            double valorAPagar = cotacaoDolar * quantidadeDaCompraEmDolar;
            valorAPagar += valorAPagar * (Iof / 100.00);
            return valorAPagar;
        }
    }
}