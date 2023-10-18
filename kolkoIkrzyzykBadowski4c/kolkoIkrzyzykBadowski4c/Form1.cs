using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;

namespace kolkoIkrzyzykBadowski4c
{
    public partial class glowneOkno : Form
    {
        bool[] aktywny = new bool[10] { true, true, true, true, true, true, true, true, true, true };
        string[] symbole = new string[10] { "z", "z", "z", "z", "z", "z", "z", "z", "z", "z" };
        bool czyMoznaGrac = true;
        public glowneOkno()
        {
            InitializeComponent();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gdi = this.CreateGraphics();
            gdi.DrawLine(Pens.Black, new Point(350, 50), new Point(350, 500));
            gdi.DrawLine(Pens.Black, new Point(500, 50), new Point(500, 500));
            gdi.DrawLine(Pens.Black, new Point(200, 200), new Point(650, 200));
            gdi.DrawLine(Pens.Black, new Point(200, 350), new Point(650, 350));
        }
        private void glowneOkno_MouseMove(object sender, MouseEventArgs e)
        {
            
        }
        private void pole(int x, int y, int numer, string symbol)
        {
            if (aktywny[numer] == true)
            {
                aktywny[numer] = false;
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(new SolidBrush(Color.Red), 5);
                Rectangle r = new Rectangle(x, y, 100, 100);
                g.DrawEllipse(p, r);
                symbole[numer] = symbol;
            } else
            {
                return;
            }
        }
        private void ruchGracza(object sender, MouseEventArgs e)
        {
            if (e.X < 350 && e.Y < 200 && e.X > 200 && e.Y > 50)
            {
                pole(220, 70, 1, "o");
            }
            else if (e.X < 350 && e.X > 200 && e.Y > 200 && e.Y < 350)
            {
                pole(220, 220, 2, "o");
            }
            else if (e.X < 350 && e.X > 200 && e.Y > 350 && e.Y < 500)
            {
                pole(220, 380, 3, "o");
            }
            else if (e.X > 350 && e.Y < 200 && e.X < 500 && e.Y > 50)
            {
                pole(370, 70, 4, "o");
            }
            else if (e.X > 350 && e.Y < 350 && e.X < 500 && e.Y > 200)
            {
                pole(370, 220, 5, "o");
            }
            else if (e.X > 350 && e.Y < 500 && e.X < 500 && e.Y > 350)
            {
                pole(370, 380, 6, "o");
            }
            else if (e.X > 500 && e.X < 650 && e.Y > 50 && e.Y < 200)
            {
                pole(520, 70, 7, "o");
            }
            else if (e.X > 500 && e.X < 650 && e.Y < 350 && e.Y > 200)
            {
                pole(520, 220, 8, "o");
            }
            else if (e.X > 500 && e.X < 650 && e.Y > 350 && e.Y < 500)
            {
                pole(520, 380, 9, "o");
            }
        }
        private void poleKomputer(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4, int numer, string symbol)
        {
            aktywny[numer] = false;
            Graphics gdi = this.CreateGraphics();
            Pen p = new Pen(Color.Black, 5);
            Point punkt1 = new Point(x1, y1);
            Point punkt2 = new Point(x2, y2);
            Point punkt3 = new Point(x3, y3);
            Point punkt4 = new Point(x4, y4);
            gdi.DrawLine(p, punkt1, punkt2);
            gdi.DrawLine(p, punkt3, punkt4);
            symbole[numer] = symbol;
        }
        private void ruchKomputera(object sender, MouseEventArgs e)
        {
            int counter = 1;
            for (int i = 1; i < aktywny.Length; i++)
            {
                if (aktywny[i] == false)
                {
                    counter++;
                }
            }
            if (counter == aktywny.Length)
            {
                return;
            } else {
                Random rand = new Random();
                int miejsce = rand.Next(1, 10);
                while (aktywny[miejsce] == false)
                {
                    miejsce = rand.Next(1, 10);
                }
                if (miejsce == 1)
                {
                    poleKomputer(220, 70, 330, 180, 330, 70, 220, 180, 1, "x");
                }
                else if (miejsce == 2)
                {
                    poleKomputer(220, 220, 330, 330, 330, 220, 220, 330, 2, "x");
                }
                else if (miejsce == 3)
                {
                    poleKomputer(220, 370, 330, 480, 330, 370, 220, 480, 3, "x");
                }
                else if (miejsce == 4)
                {
                    poleKomputer(370, 70, 480, 180, 480, 70, 370, 180, 4, "x");
                }
                else if (miejsce == 5)
                {
                    poleKomputer(370, 220, 480, 330, 480, 220, 370, 330, 5, "x");
                }
                else if (miejsce == 6)
                {
                    poleKomputer(370, 370, 480, 480, 480, 370, 370, 480, 6, "x");
                }
                else if (miejsce == 7)
                {
                    poleKomputer(520, 70, 630, 180, 630, 70, 520, 180, 7, "x");
                }
                else if (miejsce == 8)
                {
                    poleKomputer(520, 220, 630, 330, 630, 220, 520, 330, 8, "x");
                }
                else if (miejsce == 9)
                {
                    poleKomputer(520, 370, 630, 480, 630, 370, 520, 480, 9, "x");
                }
            }
        }

        private int Wynik()
        {
            int wynik = 0;
            if (symbole[1] == "o" && symbole[2] == "o" && symbole[3] == "o")
            {
                wynik = 1;
                Pen p = new Pen(Color.Blue, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(275, 70);
                Point p2 = new Point(275, 480);
                gdi.DrawLine(p, p1, p2);
            } 
            else if (symbole[4] == "o" && symbole[5] == "o" && symbole[6] == "o")
            {
                wynik = 1;
                Pen p = new Pen(Color.Blue, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(425, 70);
                Point p2 = new Point(425, 480);
                gdi.DrawLine(p, p1, p2);
            } 
            else if (symbole[7] == "o" && symbole[8] == "o" && symbole[9] == "o")
            {
                wynik = 1;
                Pen p = new Pen(Color.Blue, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(575, 70);
                Point p2 = new Point(575, 480);
                gdi.DrawLine(p, p1, p2);
            } 
            else if (symbole[1] == "o" && symbole[4] == "o" && symbole[7] == "o")
            {
                wynik = 1;
                Pen p = new Pen(Color.Blue, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 125);
                Point p2 = new Point(630, 125);
                gdi.DrawLine(p, p1, p2);
            } 
            else if (symbole[2] == "o" && symbole[5] == "o" && symbole[8] == "o")
            {
                wynik = 1;
                Pen p = new Pen(Color.Blue, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 275);
                Point p2 = new Point(630, 275);
                gdi.DrawLine(p, p1, p2);
            } 
            else if (symbole[3] == "o" && symbole[6] == "o" && symbole[9] == "o")
            {
                wynik = 1;
                Pen p = new Pen(Color.Blue, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 425);
                Point p2 = new Point(630, 425);
                gdi.DrawLine(p, p1, p2);
            } 
            else if (symbole[1] == "o" && symbole[5] == "o" && symbole[9] == "o")
            {
                wynik = 1;
                Pen p = new Pen(Color.Blue, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 70);
                Point p2 = new Point(630, 480);
                gdi.DrawLine(p, p1, p2);
            } 
            else if (symbole[3] == "o" && symbole[5] == "o" && symbole[7] == "o")
            {
                wynik = 1;
                Pen p = new Pen(Color.Blue, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 480);
                Point p2 = new Point(630, 70);
                gdi.DrawLine(p, p1, p2);
            }
            else if (symbole[1] == "x" && symbole[2] == "x" && symbole[3] == "x")
            {
                wynik = 2;
                Pen p = new Pen(Color.Red, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(275, 70);
                Point p2 = new Point(275, 480);
                gdi.DrawLine(p, p1, p2);
            }
            else if (symbole[4] == "x" && symbole[5] == "x" && symbole[6] == "x")
            {
                wynik = 2;
                Pen p = new Pen(Color.Red, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(425, 70);
                Point p2 = new Point(425, 480);
                gdi.DrawLine(p, p1, p2);
            }
            else if (symbole[7] == "x" && symbole[8] == "x" && symbole[9] == "x")
            {
                wynik = 2;
                Pen p = new Pen(Color.Red, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(575, 70);
                Point p2 = new Point(575, 480);
                gdi.DrawLine(p, p1, p2);
            }
            else if (symbole[1] == "x" && symbole[4] == "x" && symbole[7] == "x")
            {
                wynik = 2;
                Pen p = new Pen(Color.Red, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 125);
                Point p2 = new Point(630, 125);
                gdi.DrawLine(p, p1, p2);
            }
            else if (symbole[2] == "x" && symbole[5] == "x" && symbole[8] == "x")
            {
                wynik = 2;
                Pen p = new Pen(Color.Red, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 275);
                Point p2 = new Point(630, 275);
                gdi.DrawLine(p, p1, p2);
            }
            else if (symbole[3] == "x" && symbole[6] == "x" && symbole[9] == "x")
            {
                wynik = 2;
                Pen p = new Pen(Color.Red, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 425);
                Point p2 = new Point(630, 425);
                gdi.DrawLine(p, p1, p2);
            }
            else if (symbole[1] == "x" && symbole[5] == "x" && symbole[9] == "x")
            {
                wynik = 2;
                Pen p = new Pen(Color.Red, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 70);
                Point p2 = new Point(630, 480);
                gdi.DrawLine(p, p1, p2);
            }
            else if (symbole[3] == "x" && symbole[5] == "x" && symbole[7] == "x")
            {
                wynik = 2;
                Pen p = new Pen(Color.Red, 7);
                Graphics gdi = this.CreateGraphics();
                Point p1 = new Point(220, 480);
                Point p2 = new Point(630, 70);
                gdi.DrawLine(p, p1, p2);
            } 
            else
            {
                if(aktywny[1] == false && aktywny[2] == false && aktywny[3] == false && aktywny[4] == false && aktywny[5] == false && aktywny[6] == false && aktywny[7] == false && aktywny[8] == false && aktywny[9] == false)
                {
                    wynik = 3;
                }
            }

            return wynik;
        }

        private bool checker()
        {
                int kto = Wynik();
                if (kto == 1)
                {
                    napis.Visible = true;
                napis.BackColor = Color.FromArgb(128, 128, 128, 128);
                    napis.Text = "Wygrałeś!";
                Graphics gdi = this.CreateGraphics();
                Pen p = new Pen(Color.FromArgb(255, 128, 128, 128), 3);
                Rectangle rect = new Rectangle(200, 50, 450, 450);
                Brush brush = new SolidBrush(Color.FromArgb(128, 128, 128, 128));
                gdi.FillRectangle(brush, rect);
                gdi.DrawRectangle(p, rect);
                return false;
            }
                else if (kto == 2)
                {
                napis.Visible = true;
                napis.BackColor = Color.FromArgb(128, 128, 128, 128);
                napis.Text = "Przegrałeś!";
                Graphics gdi = this.CreateGraphics();
                Pen p = new Pen(Color.FromArgb(255, 128, 128, 128), 3);
                Rectangle rect = new Rectangle(200, 50, 450, 450);
                Brush brush = new SolidBrush(Color.FromArgb(128, 128, 128, 128));
                gdi.FillRectangle(brush, rect);
                gdi.DrawRectangle(p, rect);
                return false;
            }
            else if (kto == 3)
                {
                napis.BackColor = Color.FromArgb(128, 128, 128, 128);
                napis.Visible = true;
                napis.Text = "Remis!";
                Graphics gdi = this.CreateGraphics();
                Pen p = new Pen(Color.FromArgb(255, 128, 128, 128), 3);
                Rectangle rect = new Rectangle(200, 50, 450, 450);
                Brush brush = new SolidBrush(Color.FromArgb(128, 128, 128, 128));
                gdi.FillRectangle(brush, rect);
                gdi.DrawRectangle(p, rect);
                return false;
            }
            else
                {
                return true;
                }
        }
        private void glowneOkno_MouseDown(object sender, MouseEventArgs e)
        {
            if (czyMoznaGrac == false)
            {
                return;
            }
            if (e.X > 200 && e.X < 650 && e.Y > 50 && e.Y < 500)
            {
                ruchGracza(sender, e);
                Thread.Sleep(250);
                ruchKomputera(sender, e);
                if (aktywny[1] == false && aktywny[2] == false && aktywny[3] == false && aktywny[4] == false && aktywny[5] == false && aktywny[6] == false && aktywny[7] == false && aktywny[8] == false && aktywny[9] == false)
                {
                    czyMoznaGrac = checker();
                }
                else if (aktywny[1] == false && aktywny[2] == false && aktywny[3] == false)
                {
                    czyMoznaGrac = checker();
                }
                else if (aktywny[4] == false && aktywny[5] == false && aktywny[6] == false)
                {
                    czyMoznaGrac = checker();
                }
                else if (aktywny[7] == false && aktywny[8] == false && aktywny[9] == false)
                {
                    czyMoznaGrac = checker();
                }
                else if (aktywny[1] == false && aktywny[4] == false && aktywny[7] == false)
                {
                    czyMoznaGrac = checker();
                }
                else if (aktywny[2] == false && aktywny[5] == false && aktywny[8] == false)
                {
                    czyMoznaGrac = checker();
                }
                else if (aktywny[3] == false && aktywny[6] == false && aktywny[9] == false)
                {
                    czyMoznaGrac = checker();
                }
                else if (aktywny[1] == false && aktywny[5] == false && aktywny[9] == false)
                {
                    czyMoznaGrac = checker();
                }
                else if (aktywny[3] == false && aktywny[5] == false && aktywny[7] == false)
                {
                    czyMoznaGrac = checker();
                }
            }
        }

        private void glowneOkno_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        private void clear()
        {
            this.Invalidate();
            Graphics gdi = this.CreateGraphics();
            gdi.Clear(Color.White);
        }
        private void reset_Click(object sender, EventArgs e)
        {
            for(int i = 1; i < aktywny.Length; i++)
            {
                aktywny[i] = true;
                symbole[i] = "z";
            }
            czyMoznaGrac = true;
            this.clear();
            napis.Hide();
            napis.Text = "";
        }
    }
}
