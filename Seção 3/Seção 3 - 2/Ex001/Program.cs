using System;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Digite um número: ");
            double n = double.Parse(Console.ReadLine());

            if (n >= 0)
            {
                Console.WriteLine(" Positivo");
            }
            else
            {
                Console.WriteLine(" Negativo");
            }
        }
    }
}
