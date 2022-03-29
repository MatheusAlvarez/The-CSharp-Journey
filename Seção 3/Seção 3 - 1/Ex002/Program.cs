using System;
using System.Globalization;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Informe o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double area = 3.14159 * raio*raio;

            Console.WriteLine(" A =" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
