using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class KivetelOsztaly
    {
        public KivetelOsztaly() { }

        // Nincs kivétel kezelés
        public void KivKezNincs()
        {
            Console.WriteLine("Nincs kivételkezelés\nAdjon meg egy karaktert!");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A beírt szám: {szam}");
            Console.ReadKey();
        }

        public void KivKezAlt()
        {
            Console.WriteLine("\nhiba objektum nélküli kivételkezelés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Hibás adat!");
            }
            Console.ReadKey();
        }
        
        public void KivKezOs()
        {
            Console.WriteLine("\nős Hiba objektummal kivételezés\nAdjon meg egy karaktert!");
            try
            {
                int szam = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"A beírt szám: {szam}");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
