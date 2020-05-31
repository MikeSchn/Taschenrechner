using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        static string HoleSummanden(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string zahl1 = Console.ReadLine();

            return zahl1;
        }
        static void Main(string[] args)
        {

            // Konvertiert String in Gleitkommazahl
            double zahlA = Convert.ToDouble(HoleSummanden("Gieb den ersten Summanden ein:")); 
            double zahlB = Convert.ToDouble(HoleSummanden("Gieb den zweiten Summanden ein:"));

            //Berechnung Ausführen und Ausgabe
            double summe = Addiere(zahlA, zahlB);
            Console.WriteLine("Die Addition von: " + zahlA + " + " + zahlB + " = {0}", summe);
            
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
