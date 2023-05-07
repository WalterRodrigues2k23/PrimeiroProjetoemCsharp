using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string name = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o preço de um produto: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vt = Console.ReadLine().Split(' ');
            Console.WriteLine();
            Console.WriteLine();
            string nome2 = vt[0];
            int z = int.Parse(vt[1]);
            double x = double.Parse(vt[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Nome completo: " + name);
            Console.WriteLine("Quartos na casa: " + a);
            Console.WriteLine("Preço do produto: " + b.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Seu último nome, idade e altura: " + nome2 + " " + z + " " + x.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}