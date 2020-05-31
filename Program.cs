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

            // Konvertiert String in Gleitkommazahl Double um
            double zahlA = Convert.ToDouble(BenutzerEingabe("Bitte gib die erste Zahl ein: ")); 
            double zahlB = Convert.ToDouble(BenutzerEingabe("Bitte gib die zweite Zahl ein: "));
            string operation = BenutzerEingabe("Bitte gib die auszuführenden Operator(+, -, * oder /) ein: ");

            //Berechnung Ausführen
            
            if (operation == "+")
            {
                double summe = Addiere(zahlA, zahlB);
                Console.WriteLine("Das Ergebnis der Addition(Summe) ist: {0}", summe);
            }
            else if (operation == "-")
            {
                double summe = Subtrahiere(zahlA, zahlB);
                Console.WriteLine("Das Ergebnis der Subtraktion(Differenz) ist: {0}", summe);
            }
            else if (operation == "*")
            {
                double summe = Multiplizieren(zahlA, zahlB);
                Console.WriteLine("Das Ergebnis der Multiplikation(Produkt) ist: {0}", summe);
            }
            else if (operation == "/")
            {
                double summe = Dividieren(zahlA, zahlB);
                Console.WriteLine("Das Ergebnis der Division(Quotient) ist: {0}", summe);
            }
            else
            {
                Console.WriteLine("Die eingabe war Falsch");
            }

            BenutzerEingabe("Zum Beenden eine Taste Drücken!");
        }

        static string BenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string number = Console.ReadLine();

            return number;
        }

        static double Addiere(double ersterSummand, double zweiterSummand) 
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }

        static double Subtrahiere(double minuend, double subtrahent)
        {
            double summe = minuend - subtrahent;
            return summe;
        }

        static double Multiplizieren(double multiplikant, double multiplikator)
        {
            double summe = multiplikant * multiplikator;
            return summe;
        }
        
        static double Dividieren(double dividend, double divisor)
        {
            double summe = dividend / divisor;
            return summe;
        }
    }
}
