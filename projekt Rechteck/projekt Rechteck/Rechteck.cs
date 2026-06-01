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
                if (value <= 0)
                {
                    throw new Exception("Breite muss größer als 0 sein!!");
                }

                breite = value;
            }
        }

        public double Hoehe
        {
            get { return hoehe; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Hoehe muss größer als 0 sein !!");
                }
                hoehe = value;
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
            return (breite + breite) * (hoehe + hoehe);
        }
    }
}