using System.Formats.Asn1;

namespace ExercicioFixacao01
{
    class Program
    {
        /* Fazer um programa para ler os valores da largura e altura 
        de um retângulo. Em seguida, mostrar na tela o valor de 
        sua área, perímetro e diagonal. Usar uma classe como 
        mostrado no projeto ao lado.*/
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a altura do retângulo:");
            retangulo.Altura = double.Parse(Console.ReadLine());

            var area = retangulo.Area();
            Console.WriteLine($"AREA = {area}");

            var perimetro = retangulo.Perimetro();
            Console.WriteLine($"PERÍMETRO = {perimetro}");

            var diagonal = retangulo.Diagonal();
            Console.WriteLine($"DIAGONAL = {diagonal}");
        }
    }
}