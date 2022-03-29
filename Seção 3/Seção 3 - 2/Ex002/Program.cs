using System;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Informe um valor: ");
            double n = double.Parse(Console.ReadLine());

            if (n%2 == 0)
            {
                Console.WriteLine(" Par");   
            }
            else
            {
                Console.WriteLine(" Ímpar");
            }
        }
    }
}
