using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kolkoIkrzyzykBadowski4c
{
    public partial class glowneOkno : Form
    {
        bool[] aktywny = new bool[10] { true, true, true, true, true, true, true, true, true, true };
            
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
            label1.Text = "X: " + (e.X).ToString() + ", Y: " + (e.Y).ToString();
        }

        private void pole(int x, int y, int numer)
        {
            if (aktywny[numer] == true)
            {
                aktywny[numer] = false;
                Graphics g = this.CreateGraphics();
                Pen p = new Pen(new SolidBrush(Color.Red), 5);
                Rectangle r = new Rectangle(x, y, 90, 90);
                g.DrawEllipse(p, r);
            } else
            {
                return;
            }
        }

        private void ruchGracza(object sender, MouseEventArgs e)
        {
            if (e.X < 350 && e.Y < 200 && e.X > 200 && e.Y > 50)
            {
                pole(220, 80, 1);
            }
            else if (e.X < 350 && e.X > 200 && e.Y > 200 && e.Y < 350)
            {
                pole(220, 220, 2);
            }
            else if (e.X < 350 && e.X > 200 && e.Y > 350 && e.Y < 500)
            {
                pole(220, 380, 3);
            }
            else if (e.X > 350 && e.Y < 200 && e.X < 500 && e.Y > 50)
            {
                pole(380, 80, 4);
            }
            else if (e.X > 350 && e.Y < 350 && e.X < 500 && e.Y > 200)
            {
                pole(380, 220, 5);
            }
            else if (e.X > 350 && e.Y < 500 && e.X < 500 && e.Y > 350)
            {
                pole(380, 380, 6);
            }
            else if (e.X > 500 && e.X < 650 && e.Y > 50 && e.Y < 200)
            {
                pole(520, 80, 7);
            }
            else if (e.X > 500 && e.X < 650 && e.Y < 350 && e.Y > 200)
            {
                pole(520, 220, 8);
            }
            else if (e.X > 500 && e.X < 650 && e.Y > 350 && e.Y < 500)
            {
                pole(520, 380, 9);
            }
        }

        private void poleKomputer(int x, int y, int numer)
        {
            Pen p = new Pen(Color.Black, 2);
            Point punkt1 = new Point(220, 70);
        }

        private void ruchKomputera(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            int counter = 0;
            int iloscMiejsc = 0;
            for(int i = 0; i < 10; i++)
            {
                if (aktywny[i] == true)
                {
                    counter++;
                }
            }
            int[] aktywnePola = new int[counter];
            for (int i = 0; i < 10; i++)
            {
                if (aktywny[i] == true)
                {
                    aktywnePola[iloscMiejsc] = i;
                    iloscMiejsc++;
                }
            }
            rand.Next(iloscMiejsc+1);

        }

        private void glowneOkno_MouseDown(object sender, MouseEventArgs e)
        {
            ruchGracza(sender, e);
        }
    }
}
