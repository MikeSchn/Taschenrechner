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
            double zahlA = Convert.ToDouble(zahl1); // Konvertiert String in Gleitkommazahl

            Console.Write("Gieb den zweiten Summanden ein:");
            string zahl2 = Console.ReadLine();
            double zahlB = Convert.ToDouble(zahl2); // Konvertiert String in Gleitkommazahl

            double summe = Addiere(zahlA, zahlB);
            

            Console.WriteLine("Die Addition von: " + zahl1 + " + " + zahl2 + " = {0}", summe);
            
            WarteAufBenutzerEingabe();
        }

        static double Addiere(double ersterSummand, double zweiterSummand) 
        {

            double summe = ersterSummand + ersterSummand;

            return summe;
        }

        static void WarteAufBenutzerEingabe()
        {
            Console.Write("Zum Beenden eine Taste Drücken!");
            Console.ReadLine();        
        }

    }
}
