using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging; // kvůli screenshotu

namespace SnakeGameZapocet2
{
    public partial class Form1 : Form
    {
        private List<Kolecko> Had = new List<Kolecko>(); // list typu kolecko, hlavu a ostatní části těla budu přidávat sem
        private Kolecko jablko = new Kolecko(); // class// konstruktor vytvořím novou instanci 

        int score;
        int highscore= Nastaveni.NejvyssiScore1;
        public Form1()
        {
            InitializeComponent();

            new Nastaveni(); // potřebujeme přístup ke všem předem
                            // připraveným statiským proměnným a jejich hodnotám 


            // rychlost hry
            SnakeTimer.Interval = 1000 / Nastaveni.Rychlost;
            SnakeTimer.Tick += UpdateObrazovky;
            SnakeTimer.Start();

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            Klavesnice.ZmenaStavu(e.KeyCode, true);

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            Klavesnice.ZmenaStavu(e.KeyCode, false);
        }

        private void StartHry(object sender, EventArgs e)
        {
            UVODNIlabell.Visible = false;
            GAMEOVERlabell.Visible = false;
            STARTbutton.Enabled = false;
            PHOTObutton.Enabled = false;
            RESTARTbutton.Enabled = false;

            Had.Clear(); // vymaže všechny části hada nacházející se v listu 

            new Nastaveni();

            Random random = new Random();
            int maxX = HraciPlocha.Size.Width / Nastaveni.Sirka;
            int maxY = HraciPlocha.Size.Height / Nastaveni.Vyska;

            Kolecko hlava = new Kolecko();
            hlava.X = random.Next(10, maxX - 10); // ty 10 tam jsou aby začal někde normálně ve středu a ne úplně na kraji
            hlava.Y = random.Next(10, maxY - 10);
            Had.Add(hlava);// přidání 1.  části hada do listu 

            AktualniScore.Text = Nastaveni.nula.ToString();

            NejvyssiScore.Text = highscore.ToString();

            VygenerujJablko();
        }

        private void HraciPlochaPaint(object sender, PaintEventArgs e)
        {
            Graphics plocha = e.Graphics; //Graphics je třída 

            if (!Nastaveni.GameOver)
            {
                Brush snakeColour; // díky tomu vybarvíme halvu a i celé tělo 

                for (int i = 0; i < Had.Count; i++)
                {
                    if (i == 0) // hlava má index 0
                    {
                        snakeColour = Brushes.Black;
                    }
                    else if (i % 2 == 0) // sudé části 
                    {
                        snakeColour = Brushes.Yellow;
                    }
                    else snakeColour = Brushes.White; // liché části 

                    // vykreslení hada, jelikož se jeho souřadnice pořád mění tak se musí opakovně překreslovat na obrazovce
                    plocha.FillEllipse(snakeColour , new Rectangle(Had[i].X * Nastaveni.Sirka, Had[i].Y * Nastaveni.Vyska, Nastaveni.Sirka, Nastaveni.Vyska)); //snakeColour je barva objektu záleží,
                                                                                                                                                               //jestli je to halva atd.. 
                    // uvnitř rectanglu definujeme hodnotu x, y  sirku a vysku objektu 

                }
                // vykreslení jídla
                plocha.FillEllipse(Brushes.Red,
                    new Rectangle(jablko.X * Nastaveni.Sirka,jablko.Y * Nastaveni.Vyska, Nastaveni.Sirka, Nastaveni.Vyska));
            }
            else
            {
                string gameOver = "Game over :( \n Vaše nejvyšší skóre je: " + highscore+ "  \n Chceteli pokračovat stiskněte START. Chcete-li novou hru stiskněte RESTART. pro vytvoření fotografie stiskněte PHOTO";
                GAMEOVERlabell.Text = gameOver;
                GAMEOVERlabell.Visible = true;

            }

        }

        private void RestartHry(object sender, EventArgs e)
        {
            GAMEOVERlabell.Visible = false;

            // vytvoření nového objektu pro hráče
            Had.Clear();
            STARTbutton.Enabled = false;
            PHOTObutton.Enabled = false;
            RESTARTbutton.Enabled = false;

            new Nastaveni();

            AktualniScore.Text = Nastaveni.nula.ToString();
            NejvyssiScore.Text = Nastaveni.nula.ToString();

            Had.Clear();

            Random random = new Random();
            int maxX = HraciPlocha.Size.Width / Nastaveni.Sirka;
            int maxY = HraciPlocha.Size.Height / Nastaveni.Vyska;

            Kolecko hlava = new Kolecko();
            hlava.X = random.Next(10, maxX-10);
            hlava.Y = random.Next(10, maxY-10);
            Had.Add(hlava);


            VygenerujJablko();

        }
        private void SnezeniJidla()
        {
            Kolecko jablko = new Kolecko();
            jablko.X = Had[Had.Count - 1].X;
            jablko.Y = Had[Had.Count - 1].Y;

            Had.Add(jablko); // přidáváme na konec 

            score += Nastaveni.Body;
            AktualniScore.Text = score.ToString();
            
            VygenerujJablko();
        }
        private void VygenerujJablko()
        {
            int maxX = HraciPlocha.Size.Width / Nastaveni.Sirka;
            int maxY = HraciPlocha.Size.Height / Nastaveni.Vyska;

            Random random = new Random();
            jablko = new Kolecko();
            jablko.X = random.Next(0, maxX);
            jablko.Y = random.Next(0, maxY);
        }


        private void UpdateObrazovky(object sender, EventArgs e)
        {
            if (Nastaveni.GameOver == true)
            {
                GAMEOVERlabell.Visible = false;
                STARTbutton.Enabled = true;
                PHOTObutton.Enabled = true;
                RESTARTbutton.Enabled = true;

            }
            else
            {
                if (Klavesnice.Zmacknuti(Keys.Right) && Nastaveni.direction != Direction.Leva) // had se nikdy nemůže otočit o 180° 
                {
                    Nastaveni.direction = Direction.Prava;
                }
                else if (Klavesnice.Zmacknuti(Keys.Left) && Nastaveni.direction != Direction.Prava)
                {
                    Nastaveni.direction = Direction.Leva;
                }
                else if (Klavesnice.Zmacknuti(Keys.Up) && Nastaveni.direction != Direction.Dolu)
                {
                    Nastaveni.direction = Direction.Nahoru;
                }
                else if (Klavesnice.Zmacknuti(Keys.Down) && Nastaveni.direction != Direction.Nahoru)
                {
                    Nastaveni.direction = Direction.Dolu;
                }

                PohybHrace();

            }

            HraciPlocha.Invalidate(); // aby se to mohlo v každém kroku překreslovat 
        }
        private void PohybHrace()
        {
            for (int i = Had.Count - 1; i >= 0; i--)
            {
                //pohyb hlavy
                if (i == 0)
                {
                    switch (Nastaveni.direction)
                    {
                        case Direction.Prava:
                            Had[i].X++;
                            break;
                        case Direction.Leva:
                            Had[i].X--;
                            break;
                        case Direction.Nahoru:
                            Had[i].Y--;
                            break;
                        case Direction.Dolu:
                            Had[i].Y++;
                            break;

                    }

                    int maxX = HraciPlocha.Size.Width / Nastaveni.Sirka;
                    int maxY = HraciPlocha.Size.Height / Nastaveni.Vyska;

                    // kolize s okraji
                    if (Had[i].X < 0 || Had[i].Y < 0 || Had[i].X >= maxX || Had[i].Y >= maxY)
                    {
                        GameOver();
                    }

                    // kolize s tělem
                    for (int k = 1; k < Had.Count; k++) // k = 1 protože 0 je hlava 
                    {
                        if (Had[i].X == Had[k].X && Had[i].Y == Had[k].Y)
                        {
                            GameOver();
                        }
                    }

                    // kolize s jídlem
                    if (Had[0].X == jablko.X && Had[0].Y == jablko.Y)
                    {
                        SnezeniJidla();
                    }

                }
                // pohyb těla
                else
                {
                    Had[i].X = Had[i - 1].X;
                    Had[i].Y = Had[i - 1].Y;
                }
            }
        }
        private void GameOver()
        {
    
           if (score>highscore)
            {
                highscore = score;
            }
            score = 0;
            Nastaveni.GameOver = true;

        }
        private void UdelejFotku(object sender, EventArgs e)
        {
            GAMEOVERlabell.Visible = false;
            Label titulek = new Label();
            titulek.Text = "Ve  hře Snake Game je moje skore: " + score + " a moje nejvyšší skore je: " + highscore;
            // tady jenom urcuju font, velikost, barvu atd.. 
            titulek.Font = new Font("Ariel", 15, FontStyle.Underline);
            titulek.TextAlign = ContentAlignment.TopCenter;
            titulek.AutoSize = true;
            titulek.ForeColor = Color.White;
            HraciPlocha.Controls.Add(titulek); // přidáme na hrací plochu 

            SaveFileDialog dialog = new SaveFileDialog(); // ukládání obrázku 
            // parametry nezbytné pro uložení
            dialog.FileName = "Snake Game Screenshot";           
            dialog.Filter = "JPG Image File | *.jpg";
            dialog.DefaultExt = "jpg";
            dialog.ValidateNames = true; // jméno musí být vždy stejné 
            if (dialog.ShowDialog() == DialogResult.OK) // co se stane když potvrdíme uložení - klikneme na Save
            {
                int vyska = Convert.ToInt32(HraciPlocha.Height); // velikost obrázku
                int sirka = Convert.ToInt32(HraciPlocha.Width);
                Bitmap bmp = new Bitmap(sirka, vyska);
                HraciPlocha.DrawToBitmap(bmp, new Rectangle(0, 0, sirka, vyska)); // všechno co je na hrací ploše nakreslíme do te bitmap
                bmp.Save(dialog.FileName, ImageFormat.Jpeg); // ulozime 
                HraciPlocha.Controls.Remove(titulek); // at muzeme hrat bez titulku 
            }

        }
    }
}


