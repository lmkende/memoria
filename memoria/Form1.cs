using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoria
{
    public partial class Jatekter : Form
    {
        Kartya ideiglenesKartya;
        public List<Kartya> Kartyak;
        public List<Kartya> KartyakTemp;
        

        public Jatekter()
        {
            InitializeComponent();
            Kartyak = new List<Kartya>();
            KartyakTemp = new List<Kartya>();
            Program.MunkaKartyak = new List<Kartya>();


            for (int i = 0; i < 12; i++ )
            {
                ideiglenesKartya = new Kartya();
                KartyakTemp.Add(ideiglenesKartya);
                if (i<6){
                    ideiglenesKartya.KartyaMegjelenites.pictureBox1.Load("../../../kepek/" + (i + 1).ToString() + ".jpg");
                    ideiglenesKartya.ID = i + 1;
                }

                else
                {
                    ideiglenesKartya.KartyaMegjelenites.pictureBox1.Load("../../../kepek/" + (i + 1-6).ToString() + ".jpg");
                    ideiglenesKartya.ID = i + 1-6;
                }
                
                Kartyak.Add(null);
            }

            Random rnd1 = new Random();

            for (int i = 0; i < 12; i++)
            {
                int a = rnd1.Next(0,12);
                if (Kartyak[a] == null)
                {
                    Kartyak[a] = KartyakTemp[i];
                }
                else
                    i--;
            }

            for (int i = 0; i < 12; i++)
            {
                tableLayoutPanel1.Controls.Add(Kartyak[i].KartyaMegjelenites);
            }


            //
        }
    }
}
