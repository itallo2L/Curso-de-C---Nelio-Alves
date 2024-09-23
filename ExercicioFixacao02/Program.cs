using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace ExercicioDeFixacao02
{
    /*Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em
    seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o
    salário do funcionário com base em uma porcentagem dada (somente o salário bruto é
    afetado pela porcentagem) e mostrar novamente os dados do funcionário.*/

    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Nome:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("Salário bruto:");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Imposto:");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Funcionário: {funcionario.Nome}, $ {funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}\n");

            Console.WriteLine($"Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine($"\nDados atualizados: {funcionario.Nome}, $ {funcionario.SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}