using System;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite o valor de A: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write(" Digite o valor de B: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write(" Digite o valor de C: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write(" Digite o valor de D: ");
            int d = int.Parse(Console.ReadLine());

            int diferenca = ((a * b) - (c * d));

            Console.WriteLine();
            Console.WriteLine(" Diferença = " + diferenca);
        }
    }
}
