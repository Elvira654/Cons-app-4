using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*Sportista je planirao da u toku n dana priprema prvi dan pretrči a kilometara a sledećeg 10%
više od norme predhodnog dana. Napisati program koji prikazuje koliko sportista treba da
pretrči svakog dana u toku priprema, kao i koliko će ukupno pretrčati u toku priprema*/
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, a;
            Console.WriteLine("Broj pripremnih dana: ");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Sportista prvi dan pretrci ? - ");
            a = double.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sportista je prvi dan pretrcao " + a + " kilometara.");
                a *= 1.1;
            }
            Console.ReadKey();
        }
    }
}
