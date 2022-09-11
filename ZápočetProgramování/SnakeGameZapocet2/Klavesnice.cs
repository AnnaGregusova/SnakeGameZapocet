using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGameZapocet2
{

    // třída pro input stisknutých tlačítek z klávesnice

    class Klavesnice
    {
        private static Hashtable hasovacitabulka = new Hashtable();
       
        public static bool Zmacknuti(Keys key)
        {
            if (hasovacitabulka[key] == null)
            {
                return false;
            }

            return (bool)hasovacitabulka[key];

        }

        public static void ZmenaStavu(Keys key, bool state)
        {
            hasovacitabulka[key] = state;
        }

    }
}
