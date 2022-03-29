using System;
using System.Globalization;

namespace Ex004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Informe seu número de funcionário: ");
            int nF = int.Parse(Console.ReadLine());

            Console.Write(" Informe as horas trabalhadas: ");
            double hT = double.Parse(Console.ReadLine());

            Console.Write(" Informe o valor recebido por hora: ");
            double vR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double vT = hT * vR;

            Console.WriteLine($" Number: {nF}");
            Console.WriteLine(" Salary: U$" + vT.ToString("F2"));
        }
    }
}
