using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class ConsoleView
    {
        //Konstruktor
        private RechnerModel model;
        public ConsoleView(RechnerModel model)
        {
            this.model = model;
           
        }

        public bool BenutzterWillBeenden = true;

        public string BenutzerEingabe(string ausgabeText)
        {
            Console.Write(ausgabeText);
            string number = Console.ReadLine();
            if(number == "exit")
            {
                BenutzterWillBeenden = false;
                
            }
            return number;
        }

        public void GibSummeAus(string operation)
        {
            if (operation == "+")
            {
                Console.WriteLine("Das Ergebnis der Addition(Summe) ist: {0}", model.Resultat);
            }
            else if (operation == "-")
            {
                Console.WriteLine("Das Ergebnis der Subtraktion(Differenz) ist: {0}", model.Resultat);
            }
            else if (operation == "*")
            {
                Console.WriteLine("Das Ergebnis der Multiplikation(Produkt) ist: {0}", model.Resultat);
            }
            else if (operation == "/")
            {
                Console.WriteLine("Das Ergebnis der Division(Quotient) ist: {0}", model.Resultat);
            }
            else
            {
                Console.WriteLine("Falsche Eingabe");
            }
        }

    }


    
}
