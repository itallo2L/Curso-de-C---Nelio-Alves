using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        /* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
        médio dos funcionários. */
        static void Main(String[] args)
        {
            Console.WriteLine("Digite os dados do primeiro funcionário:");
            string entradaDeDados = Console.ReadLine();

            string[] dadosFuncionario = entradaDeDados.Split(',');
            string nomeFuncionarioUm = dadosFuncionario[0];
            double salarioFuncionarioUm = double.Parse(dadosFuncionario[1]);

            Funcionario funcionarioUm = new(nomeFuncionarioUm, salarioFuncionarioUm);

            Console.WriteLine("Digite os dados do segundo funcionário:");
            entradaDeDados = Console.ReadLine();

            dadosFuncionario = entradaDeDados.Split(',');
            string nomeFuncionarioDois = dadosFuncionario[0];
            double salarioFuncionarioDois = double.Parse(dadosFuncionario[1]);

            Funcionario funcionarioDois = new(nomeFuncionarioDois, salarioFuncionarioDois);

            var salarioMedio = (funcionarioUm.Salario + funcionarioDois.Salario) / 2;

            Console.WriteLine($"Dados do primeiro funcionário: \r\nNome: {funcionarioUm.Nome}\r\nSalário: {funcionarioUm.Salario.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\r\nDados do segundo funcionário: \r\nNome: {funcionarioDois.Nome}\r\nSalário: {funcionarioDois.Salario.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\r\nSalário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}