using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tegla
{
    class Teglalapszamitasok
    {
        private double aoldal,
                    boldal,
                    coldal,
                    terulet,
                    felszin,
                    terfogat,
                    kerulet;

        public Teglalapszamitasok()
        {

        }
        public Teglalapszamitasok(double a, double b, double c)
        {
            this.aoldal = a;
            this.boldal = b;
            this.coldal = c;
        }
        public void ReadAoldal(double aoldal)
        {
            this.aoldal = aoldal;
        }
        public void ReadBoldal(double boldal)
        {
            this.boldal = boldal;
        }

        public void ReadColdal(double coldal)
        {
            this.coldal = coldal;
        }

        public void FelszinSzam()
        {
            this.felszin = 2 * (this.aoldal * this.boldal + this.boldal * this.coldal + this.coldal * this.aoldal);
        }

        public void TerfogatSzam()
        {
            this.terfogat = (this.aoldal * this.boldal * this.coldal);
        }
        public void TeruletSzam()
        {
            this.terulet = this.aoldal * this.boldal;
        }
        public void KeruletSzam()
        {
            this.kerulet = (this.aoldal + this.boldal) * 2;
        }
        public double GetKerulet() { return kerulet; }
        public double GetTerulet() { return terulet; }

        public double GetFelszin() { return felszin; }
        public double GetTerfogat() { return terfogat; }
    }
}
