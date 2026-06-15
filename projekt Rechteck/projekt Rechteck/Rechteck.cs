using System;
using System.Collections.Generic;

using System.Drawing.Text;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_Rechteck
{
    internal class Rechteck
    {
        //Attribute
        private double breite;
        private double hoehe;

        // Eigenschaften
        public double Breite
        {
            get { return breite; }
            set
            {
                if (value <= 30 && value >= 1)
                {
                    breite = value;
                }
                else

                    throw new Exception("Breite muss größer als 0 sein !!");
            }
        }

        public double Hoehe
        {
            get { return hoehe; }
            set
            {
                if (value <= 25 && value >= 1)
                {
                    hoehe = value;
                }
                else
                    throw new Exception("Hoehe muss größer als 0 sein !!");

            }
        }

        //Flaeche Berechnen
        public double Flaeche()
        {
            return Breite * Hoehe;
        }

        //Umfang Berechnen
        public double Umfang()
        {
            return 2 * (Breite + Hoehe);
        }

        //Diagonal Berechnen
        public double Diagonal()
        {
            return (Breite + Breite) * (Hoehe + Hoehe);
        }

        public void Zoomen(double f)
        {
            Breite *= f;
            Hoehe *= f;
        }

        public void Drehen()
        {
            double speicher;
            speicher = Breite;
            Breite = Hoehe;
            Hoehe = speicher;
        }
    }
}
