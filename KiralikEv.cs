using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP.EmlakLib
{
    public class KiralikEv : Ev
    {
        private double kiraFiyati;
        private double depozito;

        public double KiraFiyati
        {
            get { return kiraFiyati; }
            set { kiraFiyati = Math.Abs(value); }
        }

        public double Depozito
        {
            get { return depozito; }
            set { depozito = Math.Abs(value); }
        }

        public override string ToString()
        {
            return base.ToString() + $", Kira Fiyatı: {KiraFiyati}, Depozito: {Depozito}";
        }
    }
}
