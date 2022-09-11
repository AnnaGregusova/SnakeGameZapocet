using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameZapocet2
{
    // třída pro nastavení hry

    public enum Direction
    {
        Nahoru, Dolu, Leva, Prava
    };
    class Nastaveni
    {
        public static int Sirka { get; set; }
        public static int Vyska { get; set; }
        public static int Rychlost { get; set; }
        public static int AktualniScore1 { get; set; }
        public static int NejvyssiScore1 { get; set; }
        public static int Body { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }
        public static int nula { get; set; }


        Random random = new Random();
        public Nastaveni()
        {
            Sirka = 15; // sirka kolecka
            Vyska = 15; // vyska kolecka
            Rychlost = 15;
            AktualniScore1 = 0;
            NejvyssiScore1 = 0;
            Body = 10; // kolik bodu se připočítá za snězení jablka
            GameOver = false;
            direction = (Direction)random.Next(0, 3); // náhodně se vybere směr ve kterém bude had začínat 
            nula = 0;
           
        }

    }
}

