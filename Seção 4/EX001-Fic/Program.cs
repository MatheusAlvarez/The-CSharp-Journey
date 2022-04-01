using System;
using System.Globalization;

namespace EX001_Fic
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo dados = new Retangulo();

            Console.Write(" Informe a largura do triângulo: ");
            dados.Largura = double.Parse(Console.ReadLine());
            
            Console.Write(" Informe a alutra do triângulo: ");
            dados.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine(" ÁREA: " + dados.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" PERÍMETRO: " + dados.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(" DIAGONAL: " + dados.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
