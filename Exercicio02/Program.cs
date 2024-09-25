using System.Globalization;

namespace Exercicio02
{
    class Program
    {
        /* Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
        médio dos funcionários. */
        static void Main(String[] args)
        {
            Funcionario funcionarioUm = new();
            Funcionario funcionarioDois = new();

            Console.WriteLine("Digite os dados do primeiro funcionário:");
            string entradaDeDados = Console.ReadLine();

            string[] dadosFuncionario = entradaDeDados.Split(',');
            funcionarioUm.Nome = dadosFuncionario[0];
            funcionarioUm.Salario = double.Parse(dadosFuncionario[1]);

            Console.WriteLine("Digite os dados do segundo funcionário:");
            entradaDeDados = Console.ReadLine();

            dadosFuncionario = entradaDeDados.Split(',');
            funcionarioDois.Nome = dadosFuncionario[0];
            funcionarioDois.Salario = double.Parse(dadosFuncionario[1]);

            var salarioMedio = (funcionarioUm.Salario + funcionarioDois.Salario) / 2;

            Console.WriteLine($"Dados do primeiro funcionário: \r\nNome: {funcionarioUm.Nome}\r\nSalário: {funcionarioUm.Salario.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\r\nDados do segundo funcionário: \r\nNome: {funcionarioDois.Nome}\r\nSalário: {funcionarioDois.Salario.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\r\nSalário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}