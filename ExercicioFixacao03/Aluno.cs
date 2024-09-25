using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacao03
{
    class Aluno
    {
        public string Nome;
        public double NotaUm;
        public double NotaDois;
        public double NotaTres;

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