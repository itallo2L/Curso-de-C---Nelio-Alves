using System.Globalization;

namespace ExercicioCapitulo05
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Entre com o número da conta:");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta:");
            string titularDaConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)?");
            string haDepositoInicial = Console.ReadLine();

            double valorDeDepositoInicial = 0.0;

            if (haDepositoInicial == "s")
            {
                Console.Write("Entre com o valor de depósito inicial:\n");
                valorDeDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            ContaBancaria contaBancaria = new ContaBancaria(numeroDaConta, titularDaConta, valorDeDepositoInicial);

            double saldo = contaBancaria.Saldo;

            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {numeroDaConta}, Titular: {titularDaConta}, Saldo $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}\n");
            
            Console.Write("Entre com um valor para depósito: ");
            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            saldo = contaBancaria.Deposito(entrada);

            Console.WriteLine($"Dados da conta atualizados:\nConta {numeroDaConta}, Titular: {titularDaConta}, Saldo $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Entre com um valor para saque: ");
            entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            saldo = contaBancaria.Saque(entrada);

            Console.WriteLine($"Dados da conta atualizados:\nConta {numeroDaConta}, Titular: {titularDaConta}, Saldo $ {saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}