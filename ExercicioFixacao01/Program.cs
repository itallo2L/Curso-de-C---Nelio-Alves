using System.Formats.Asn1;
using System.Globalization;

namespace ExercicioFixacao01
{
    class Program
    {
        /* Fazer um programa para ler os valores da largura e altura 
        de um retângulo. Em seguida, mostrar na tela o valor de 
        sua área, perímetro e diagonal.*/
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            string entrada = Console.ReadLine();

            string[] dadosRetangulo = entrada.Split(' ');
            retangulo.Largura = double.Parse(dadosRetangulo[0], CultureInfo.InvariantCulture);
            retangulo.Altura = double.Parse(dadosRetangulo[1], CultureInfo.InvariantCulture);

            var area = retangulo.Area();
            Console.WriteLine($"AREA = {area.ToString("F2", CultureInfo.InvariantCulture)}");

            var perimetro = retangulo.Perimetro();
            Console.WriteLine($"PERÍMETRO = {perimetro.ToString("F2", CultureInfo.InvariantCulture)}");

            var diagonal = retangulo.Diagonal();
            Console.WriteLine($"DIAGONAL = {diagonal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}