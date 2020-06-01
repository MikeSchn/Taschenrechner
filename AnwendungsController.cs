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
            // Konvertiert String in Gleitkommazahl Double um
            double zahlA = Convert.ToDouble(view.BenutzerEingabe("Bitte gib die erste Zahl ein: "));
            double zahlB = Convert.ToDouble(view.BenutzerEingabe("Bitte gib die zweite Zahl ein: "));

            //Abfrage der Operatoren + - * /
            string operation = view.BenutzerEingabe("Bitte gib den auszuführenden Operator(+, -, * oder /) ein: ");

            //Berechnung Ausführen

            model.Berechne(zahlA, zahlB, operation);

            // Ausgabe
            view.GibSummeAus(operation);

            //Beenden

            view.BenutzerEingabe("Zum Beenden eine Taste Drücken!");
        }

    }
}
