﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivetel
{
    class Program
    {
        static void Main(string[] args)
        {
            // osztály példányosítása
            KivetelOsztaly k = new KivetelOsztaly();

            k.KivKezNincs();

            //k.KivKezNincs();

            k.KivKezAlt();

            k.KivKezOs();
        }
    }
}
