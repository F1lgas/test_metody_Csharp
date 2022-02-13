using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_metody_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Faktorial(short vstup2)
        {
            int cislo = 1;

            for (int i = 1; i <= vstup2; i++)
            {
                cislo = cislo* i;
            }

            short vysledek = short.Parse(Convert.ToString(cislo));

            MessageBox.Show("Faktoriál čísla " + vstup2 + " je " + vysledek, "Výsledek");
        }

        public long Faktorial(long vstup2)
        {
            if (vstup2 == 0)
            {
                return 1;
            }
            return vstup2 * Faktorial((vstup2 - (long)1));
        }

        public void Faktorial(int x, int y)
        {
            long vysledek = 0;

            for (int i = x; i <= y; i++)
            {
                vysledek = Faktorial((long)i);

                MessageBox.Show("Faktoriál čísla " + i + " je " + vysledek, "Výsledek");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Faktorial((short)Convert.ToInt32(vstup.Text));
            }
            catch
            {
                MessageBox.Show("Musíš zadat hodnoty!", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Faktorial((long)Convert.ToInt32(vstup.Text));

                MessageBox.Show("Faktoriál čísla " + (long)Convert.ToInt32(vstup.Text) + " je " + Faktorial((long)Convert.ToInt32(vstup.Text)), "Výsledek");
            }
            catch
            {
                MessageBox.Show("Musíš zadat hodnoty!", "Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Faktorial(Convert.ToInt32(x.Text), Convert.ToInt32(y.Text));
            }
            catch
            {
                MessageBox.Show("Musíš zadat hodnoty!", "Error");
            }
        }
    }
}