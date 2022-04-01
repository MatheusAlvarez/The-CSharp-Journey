using System;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto dados = new Produto();

            Console.WriteLine(" Entre com os dados do produto:");
            Console.Write(" Nome: ");
            dados.Nome = Console.ReadLine();

            Console.Write(" Preço: ");
            dados.Preco = double.Parse(Console.ReadLine());

            Console.Write(" Quantidade no estoque: ");
            dados.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(" Dados do produto: " + dados);

            Console.WriteLine();
            Console.Write(" Digite o número de produtos a ser adicionados ao estoque: ");
            int qteA = int.Parse(Console.ReadLine());

            Console.WriteLine();

            dados.AdicionarProdutos(qteA);
            Console.WriteLine(" Dados atualizados: " + dados);

            Console.WriteLine();

            Console.Write(" Digite o número de produtos a ser removido ao estoque: ");
            int qteR = int.Parse(Console.ReadLine());

            Console.WriteLine();

            dados.RemoverProdutos(qteR);
            Console.WriteLine(" Dados atualizados: " + dados);
        }
    }
}
