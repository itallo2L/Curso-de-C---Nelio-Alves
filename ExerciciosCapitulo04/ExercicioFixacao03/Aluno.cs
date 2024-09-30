using System.Globalization;

namespace ExercicioFixacao03
{
    class Aluno
    {
        public string Nome;
        public double NotaUm, NotaDois, NotaTres;

        public Aluno(string nome, double notaUm, double notaDois, double notaTres)
        {
            Nome = nome;
            NotaUm = notaUm;
            NotaDois = notaDois;
            NotaTres = notaTres;
        }

        public double NotaFinal()
        {
            double notaFinal = NotaUm + NotaDois + NotaTres;
            return notaFinal;
        }

        public void ConsultarSeEstaAprovadoOuNao(double notaFinal)
        {
            double media = 60.00;
            if (notaFinal >= media)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                double quantidadeDeNotaFaltando = media - notaFinal;
                Console.WriteLine($"FALTARAM {quantidadeDeNotaFaltando.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
        }
    }
}