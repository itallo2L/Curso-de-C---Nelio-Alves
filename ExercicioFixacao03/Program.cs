using System.Globalization;

namespace ExercicioFixacao03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Escrever("Nome do aluno:");
            aluno.Nome = Console.ReadLine();

            Escrever("Digite as três notas do aluno:");
            aluno.NotaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaTres = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal();

            Escrever($"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
            aluno.ConsultarSeEstaAprovadoOuNao(notaFinal);
        }

        public static void Escrever(string texto)
        {
            Console.WriteLine(texto);
        }

        //public static void LerLinhaDouble(double variavel)
        //{
        //    variavel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        //}

        //public static double LerDados(double notaUm, Aluno notaDois, Aluno notaTres)
        //{
        //    LerLinhaDouble(notaUm);
        //    return notaUm;
        //}
    }
}