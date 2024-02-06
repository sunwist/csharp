using System;
using System.Globalization;

namespace exemploEstoque
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            p.nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            p.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Dados do produto: " + p);

            Console.WriteLine(); Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + p);

            Console.WriteLine(); Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido ao estoque: ");
            qtd = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qtd);

            Console.WriteLine();
            Console.Write("Dados atualizados: " + p);

        }
    }

}
