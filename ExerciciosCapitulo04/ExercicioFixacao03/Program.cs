using System.Globalization;

namespace ExercicioFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Escrever("Nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Escrever("Digite as três notas do aluno:\n");
            double notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notaTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Aluno aluno = new(nomeAluno, notaUm, notaDois, notaTres);

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