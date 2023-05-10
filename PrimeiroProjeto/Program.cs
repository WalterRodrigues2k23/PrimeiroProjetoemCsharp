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
            Console.WriteLine("Qual sua idade? ");
            int a = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("digite o preço de um produto: ");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu último nome, idade e altura (mesma linha): ");
            string[] vt = Console.ReadLine().Split(' ');
            Console.WriteLine();
            Console.WriteLine();
            string nome2 = vt[0];
            int z = int.Parse(vt[1]);
            double x = double.Parse(vt[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Nome completo: " + name);
            Console.WriteLine("Sua idade é: " + a);
            Console.WriteLine("Preço do produto: " + b.ToString(CultureInfo.InvariantCulture));
            Console.WriteLine("Seu último nome, idade e altura: " + nome2 + " " + z + " " + x.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
