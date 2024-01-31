using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dobokocka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] tomb = new int[20];

        private void Form1_Load(object sender, EventArgs e)
        {                
            bool talalat = false;

            int k = 0;
            int ev = tomb[0];
            int vv = tomb[k];
            int akt = 69;
            for (int i = 1; i < tomb.Length; i++)
            {
                Random rnd = new Random();
                tomb[i - 1] = tomb[i - 1] + rnd.Next(1, 101);
            }

            while(talalat = false)
            {             
                k = (ev + vv)/2;
                if(tomb[k] == akt)
                { 
                    talalat = true;
                }
                if(akt < tomb[k])
                {
                    vv = k - 1;
                }
                if (akt > tomb[k])
                {
                    vv = k - 1;
                }
            }
            // szeretlek nagyon <3
        }
        // valasztok egy szamot 
        // tartomany eleje es vege valtozo ev = [0] vv = [tomb.Length] kozepe = (ev + vv)/2; aktualis = 68 talalat(bool) = true or false; 
    }
    // az erem es a megcsinalom kozott galaktikus tavlsag van
    // rendezett halmaz 
    // a tomb kozepe megegyezik e a szammal

}
