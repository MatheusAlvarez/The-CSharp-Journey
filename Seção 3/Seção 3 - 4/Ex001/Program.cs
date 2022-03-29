using System;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe um valor: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
    }
}
