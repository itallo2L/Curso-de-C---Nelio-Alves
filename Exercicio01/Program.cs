using System.Net.NetworkInformation;

namespace Exercicio01
{
    class Program
    {
        /* Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
        velha. */
        static void Main(String[] args)
        {
            Console.WriteLine("Digite os dados da primeira pessoa:");
            string entrada = Console.ReadLine();

            string[] dadosPessoa = entrada.Split(' ');
            string nomePessoaUm = dadosPessoa[0];
            int idadePessoaUm = int.Parse(dadosPessoa[1]);

            Pessoa pessoaUm = new(nomePessoaUm, idadePessoaUm);

            Console.WriteLine("Digite os dados da segunda pessoa:");
            entrada = Console.ReadLine();

            dadosPessoa = entrada.Split(' ');
            string nomePessoaDois = dadosPessoa[0];
            int idadePessoaDois = int.Parse(dadosPessoa[1]);

            Pessoa pessoaDois = new(nomePessoaDois, idadePessoaDois);

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