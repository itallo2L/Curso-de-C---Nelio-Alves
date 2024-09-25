using System.Net.NetworkInformation;

namespace Exercicio01
{
    class Program
    {
        /* Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
        velha. */
        static void Main(String[] args)
        {
            Pessoa pessoaUm = new();
            Pessoa pessoaDois = new();

            Console.WriteLine("Digite os dados da primeira pessoa:");
            string entrada = Console.ReadLine();

            string[] dadosPessoa = entrada.Split(' ');
            pessoaUm.Nome = dadosPessoa[0];
            pessoaUm.Idade = int.Parse(dadosPessoa[1]);

            Console.WriteLine("Digite os dados da segunda pessoa:");
            entrada = Console.ReadLine();

            dadosPessoa = entrada.Split(' ');
            pessoaDois.Nome = dadosPessoa[0];
            pessoaDois.Idade = int.Parse(dadosPessoa[1]);

            Console.WriteLine($"Dados da primeira pessoa: \r\nNome: {pessoaUm.Nome} \r\nIdade: {pessoaUm.Idade}\r\n" +
                $"Dados da segunda pessoa: \r\nNome: {pessoaDois.Nome} \r\nIdade: {pessoaDois.Idade}");

            if (pessoaUm.Idade > pessoaDois.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {pessoaUm.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {pessoaDois.Nome}");
            }
        }
    }
}