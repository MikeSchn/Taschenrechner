using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class AnwendungsController
    {
        private ConsoleView view;
        private RechnerModel model;

        public AnwendungsController(ConsoleView view, RechnerModel model)
        {
            this.view = view;
            this.model = model;
        }

        public void Ausfuehren()
        {
            while (view.BenutzterWillBeenden)
            {
                // Konvertiert String in Gleitkommazahl Double um
                
                double zahlA = Convert.ToDouble(view.BenutzerEingabe("Bitte gib die erste Zahl ein: "));
                string operation = view.BenutzerEingabe("Bitte gib den auszuführenden Operator(+, -, * oder /) ein: ");
                double zahlB = Convert.ToDouble(view.BenutzerEingabe("Bitte gib die zweite Zahl ein: "));

                //Berechnung Ausführen
                model.Berechne(zahlA, zahlB, operation);

                // Ausgabe
                view.GibSummeAus(operation);

                //Beenden
                view.BenutzerEingabe("Für noch eine Berechnung drücke Enter oder gib exit zum Beenden ein: ");
                
            }
        }
    }
}
