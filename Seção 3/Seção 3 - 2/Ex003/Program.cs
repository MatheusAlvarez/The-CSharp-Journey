using System;

namespace Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.Write(" Informe os valores de A e B: ");

            string[] valores = Console.ReadLine().Split(' ');
            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine(" São Múltiplos");
            }
            else
            {
                Console.WriteLine(" Não são Múltiplos");
            }
        }
    }
}
