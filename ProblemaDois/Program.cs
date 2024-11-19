using System.Globalization;

namespace ProblemaDois
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do produto:");
            Console.Write("Nome: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto produto = new(nomeProduto, preco, quantidade);

            var valorTotal = produto.ValorTotalEmEstoque();
            Console.WriteLine($"Dados do produto: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {produto.Quantidade} unidades, Total: $ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            var quantidadeDeProdutoAdicionado = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(quantidadeDeProdutoAdicionado);
            valorTotal = produto.ValorTotalEmEstoque();

            Console.WriteLine($"Dados atualizados: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {produto.Quantidade} unidades, Total: $ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            var quantidadeDeProdutoRemovido = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(quantidadeDeProdutoRemovido);
            valorTotal = produto.ValorTotalEmEstoque();

            Console.WriteLine($"Dados atualizados: {produto.Nome}, $ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}," +
                $" {produto.Quantidade} unidades, Total: $ {valorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}