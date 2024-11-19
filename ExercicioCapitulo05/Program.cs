using System.Globalization;

namespace ExercicioCapitulo05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titularDaConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char haDepositoInicial = char.Parse(Console.ReadLine());

            double valorDeDepositoInicial = 0.0;

            if (haDepositoInicial == 's' || haDepositoInicial == 'S')
            {
                Console.Write("Entre com o valor de depósito inicial: ");
                valorDeDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBancaria contaBancaria = new ContaBancaria(numeroDaConta, titularDaConta, valorDeDepositoInicial);

            double saldo = contaBancaria.Saldo;

            Console.Write($"\nDados da conta:\nConta {numeroDaConta}, Titular: {titularDaConta}, Saldo $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}");
            
            Console.Write("\n\nEntre com um valor para depósito: ");
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            saldo = contaBancaria.Deposito(entrada);

            Console.Write($"Dados da conta atualizados:\nConta {numeroDaConta}, Titular: {titularDaConta}, Saldo $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("\n\nEntre com um valor para saque: ");
            entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            saldo = contaBancaria.Saque(entrada);

            Console.Write($"Dados da conta atualizados:\nConta {numeroDaConta}, Titular: {titularDaConta}, Saldo $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}