using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Kor
    {
        // Az osztály feladata a sugárból kiszámítja a kör területét és kerületét

        // Osztályváltozók
        protected double sugar,
            kerulet,
            terulet;
        // Konstruktorok
        // a konstruktor szerepe a peldanyositas az osztalybol peldanyokat hoz letre
        public Kor(){}

        public Kor(double r) 
        {
            this.sugar = r;
        }

        public void ReadSugar(double r)
        {
            this.sugar = r;
        }

        public void SetKerulet()
        {
            this.kerulet = 2 * this.sugar * Math.PI;
        }

        public void SetTerulet()
        {
            double eredmeny1 = 0.0,
                   eredmeny2 = 0.0;
            this.terulet = this.sugar * this.sugar * Math.PI;

            this.terulet = Math.Pow(this.sugar, 2) * Math.PI;

            if (eredmeny1 == eredmeny2)
            {
                this.terulet = eredmeny1;
            }

            else
            {
                Console.WriteLine($"Eredmény1  ({eredmeny1} != eredmény2 ({eredmeny2})");
            }
        }

        public double GetKerulet() { return this.kerulet;}
        public double GetTerulet() { return this.terulet;}
        public double GetSugar() { return this.kerulet; }
    }
}
