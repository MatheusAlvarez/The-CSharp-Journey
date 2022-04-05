using System;
using System.Globalization;

namespace EX001
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria conta;

            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial? (s/n): ");
            char opc = char.Parse(Console.ReadLine());

            if (opc == 's' || opc == 'S')
            {
                Console.Write("Entre com um valor para depósito inicial: ");
                double depInicio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depInicio);
            }
            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.WriteLine("Entre com um valor para depósito: ");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(dep);

            Console.WriteLine();
            Console.Write("Dados Atualizados");
            Console.WriteLine(conta);

            Console.Write("Entre com um valor para saque: ");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(saq);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);
        }
    }
}
