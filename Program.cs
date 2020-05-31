using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Gieb den ersten Summanden ein:");
            string zahl1 = Console.ReadLine();
            int zahlA = int.Parse(zahl1);

            Console.Write("Gieb den zweiten Summanden ein:");
            string zahl2 = Console.ReadLine();
            int zahlB = int.Parse(zahl2);


            int summe = zahlA + zahlB;

            Console.WriteLine("Die Addition von: " + zahl1 + " + " + zahl2 + " = {0}", summe);
            Console.Write("Zum Beenden eine Taste Drücken!");
            Console.ReadKey();
        }


    }
}
