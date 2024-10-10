using System.Globalization;

namespace ExercicioCapitulo05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número da conta:");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta:");
            string titularDaConta = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            string haDepositoInicial = Console.ReadLine();

            if (haDepositoInicial == "s")
            {
                Console.WriteLine("Entre com o valor de depósito inicial:");
                double valorDeDepositoInicial = double.Parse(Console.ReadLine());
            }
        }
    }
}