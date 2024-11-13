using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace tegla

{

    class Program

    {

        static void Main(string[] args)

        {
            Teglalapszamitasok teglaszam = new Teglalapszamitasok();
            teglaszam.ReadAoldal(15);
            teglaszam.ReadBoldal(25);
            teglaszam.ReadColdal(10);
            teglaszam.FelszinSzam();
            teglaszam.TerfogatSzam();
            teglaszam.TeruletSzam();
            teglaszam.KeruletSzam();
            Console.WriteLine($"A kerület az : {teglaszam.GetKerulet()} A terület: {teglaszam.GetTerulet()} A felszín: {teglaszam.GetFelszin()} A térfogat {teglaszam.GetTerfogat()}");
            Console.ReadKey();
        }
    }
}

