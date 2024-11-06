using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KorHasab
{
    class Program
    {
        static void Main(string[] args)
        {
            // A kor osztaly felhasznalasa

            // 1.objektumunk
            #region #region 1.objektum
            Kor k1 = new Kor(); // objektum peldany letrehozasa uresen

            k1.ReadSugar(15.0); // A sugár megadása
            k1.SetKerulet(); // kiszámoltatjuk a kerületet
            k1.SetTerulet(); // kiszámoltatjuk a kerületet

            Console.WriteLine($"A {k1.GetSugar()} sguarú kör kerülete: {k1.GetKerulet()}, területe: {k1.GetTerulet()}");
            #endregion EOf 1. objektum

            #region 2.objektum
            Kor k2 = new Kor(28.7);
            k2.SetKerulet();
            k2.SetTerulet();

            Console.WriteLine($"A {k2.GetSugar()} sguarú kör kerülete: {k2.GetKerulet()}, területe: {k2.GetTerulet()}");
            #endregion EOf 2.objektum

            #region kor2 hasznalata
            kor2 k21 = new kor2(24.5);
            Console.WriteLine($"\n\nA kor2 adatai: \nsugar = {k21.GetSugar()}, \nkerulet = {k21.GetKerulet()}, \nterulet = {k21.GetTerulet()} ");
            #endregion Eof kor2
            Console.ReadKey();
        }
    }
}
