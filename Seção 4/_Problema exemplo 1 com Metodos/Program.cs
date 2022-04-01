using System;
using System.Globalization;

namespace Problema_exemplo_1_com_Metodos { 
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine(" Informe as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(" Informe as mediads do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine(" Área de X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(" Área de Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine(" Maior área: X");
            }
            else if (areaY > areaX)
            {
                Console.WriteLine(" Maior área: Y");
            }
            else
            {
                Console.WriteLine(" Mesmo tamanho");
            }
        }
    }
}
