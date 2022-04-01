using System;

namespace Ex003_Fic
{
    class Program
    {
        static void Main(string[] args)
        {
            RelacaoEscolar dados = new RelacaoEscolar();

            Console.Write("Nome do aluno: ");
            dados.Nome = Console.ReadLine();

            Console.Write("Informe a 1º nota: ");
            dados.N1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a 2º nota: ");
            dados.N2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a 3º nota: ");
            dados.N3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final: " + dados.NotaFinal());

            if (dados.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
            }

            Console.WriteLine("Faltaram " + dados.NotaRestante() + " pontos");

        }
    }
}
