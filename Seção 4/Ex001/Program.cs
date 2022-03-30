using System;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoPessoal p1, p2;

            p1 = new InfoPessoal();
            p2 = new InfoPessoal();

            Console.WriteLine(" Informe os dados da primeira pessoa: ");
            Console.Write(" Nome: ");
            p1.Nome = Console.ReadLine();

            Console.Write(" Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine(" Informe os dados da segunda pessoa: ");
            Console.Write(" Nome: ");
            p2.Nome = Console.ReadLine();

            Console.Write(" Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($" {p1.Nome} é mais velho");
            }
            else if(p1.Idade == p2.Idade)
            {
                Console.WriteLine(" Os dois tem a mesma idade");
            }
            else
            {
                Console.WriteLine($" {p2.Nome} é mais velho");
            }
        }
    }
}
