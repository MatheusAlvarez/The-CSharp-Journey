using System;
using System.Globalization;

namespace Ex002
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoFuncionario f1, f2;

            f1 = new InfoFuncionario();
            f2 = new InfoFuncionario();

            Console.WriteLine(" Informe as informações do primeiro funcionário: ");
            Console.Write(" Nome: ");
            f1.Nome = Console.ReadLine();

            Console.Write(" Salário: R$");
            f1.Sal = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Informe as informações do segundo funcionário: ");
            Console.Write(" Nome: ");
            f2.Nome = Console.ReadLine();

            Console.Write(" Salário: R$");
            f2.Sal = double.Parse(Console.ReadLine().ToString(), CultureInfo.InvariantCulture);

            double media = (f1.Sal + f2.Sal) / 2.0;

            Console.WriteLine(" Salário médio dos funcionários: R$" + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
