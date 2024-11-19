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
            Console.WriteLine("Entre com a largura e altura do retângulo: ");

            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Retangulo retangulo = new(largura, altura);

            double area = retangulo.Area();
            Console.Write($"AREA = {area.ToString("F2", CultureInfo.InvariantCulture)}");

            double perimetro = retangulo.Perimetro();
            Console.Write($"\nPERÍMETRO = {perimetro.ToString("F2", CultureInfo.InvariantCulture)}");

            double diagonal = retangulo.Diagonal();
            Console.Write($"\nDIAGONAL = {diagonal.ToString("F2", CultureInfo.InvariantCulture)}\n");
        }
    }
}