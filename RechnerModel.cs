using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        public double Resultat { get; private set; }
        public void Berechne(double zahlA, double zahlB, string operation)
        {
            //Berechnung Ausführen

            if (operation == "+")
            {
                Resultat = Addiere(zahlA, zahlB);
            }
            else if (operation == "-")
            {
                Resultat = Subtrahiere(zahlA, zahlB);
            }
            else if (operation == "*")
            {
                Resultat = Multiplizieren(zahlA, zahlB);
            }
            else if (operation == "/")
            {
                Resultat = Dividieren(zahlA, zahlB);
            }
        }

        private double Addiere(double ersterSummand, double zweiterSummand)
        {
            double summe = ersterSummand + zweiterSummand;
            return summe;
        }

        private double Subtrahiere(double minuend, double subtrahent)
        {
            double summe = minuend - subtrahent;
            return summe;
        }

        private double Multiplizieren(double multiplikant, double multiplikator)
        {
            double summe = multiplikant * multiplikator;
            return summe;
        }

        private double Dividieren(double dividend, double divisor)
        {
            double summe = dividend / divisor;
            return summe;
        }
    }
}


