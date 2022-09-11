
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameZapocet2
{
    // třída pro Kolečko (tedy článek hada nebo jídlo)
    // nevykresluje ale díky ní mám přehled o souřadnicích

    class Kolecko
    {
        public int X { get; set; } // get a set (properties) jsou podobné proměnným ale máme nad nimi větší kontrolu 
        public int Y { get; set; }

        public Kolecko() // konstruktor at vime co delat s x a y jsou public at jsou prístupné i dalsím trídam 
        {
            X = 0; // defaultní hodnota
            Y = 0;
        }
    }
}