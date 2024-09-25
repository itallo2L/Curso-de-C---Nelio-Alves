using System.Globalization;

namespace ExercicioFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new();

            Escrever("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Escrever("Digite as três notas do aluno:\n");
            aluno.NotaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal();

            Escrever($"\nNOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}\n");
            aluno.ConsultarSeEstaAprovadoOuNao(notaFinal);
        }

        static void Escrever(string texto)
        {
            Console.Write(texto);
        }
    }
}