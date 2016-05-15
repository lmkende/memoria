using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memoria
{
    public partial class KartyaControl : UserControl
    {
        Kartya k;
        public KartyaControl(Kartya k1)
        {
            InitializeComponent();
            pictureBox1.Hide();
            k = k1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Program.MunkaKartyak.Count == 2)
            {
                pictureBox1.Hide();
                k.felforditva = false;
            }

            int c = 0;
            foreach (Kartya k1 in Program.MunkaKartyak){
                if (k1.felforditva)
                    c++;
            }
            if (c == 0)
                Program.MunkaKartyak.Clear();
   
        }

        private void KartyaControl_Click(object sender, EventArgs e)
        {
            if (Program.MunkaKartyak.Count < 2)
            {
                Program.MunkaKartyak.Add(k);
                pictureBox1.Show();
                k.felforditva = true;
            }
            if (Program.MunkaKartyak.Count == 2)
            {
                if (Program.MunkaKartyak[0].ID == Program.MunkaKartyak[1].ID)
                {
                    Program.MunkaKartyak[0].megoldva = true;
                    Program.MunkaKartyak[1].megoldva = true;
                    Program.MunkaKartyak[0].KartyaMegjelenites.pictureBox1.Enabled = false;
                    Program.MunkaKartyak[1].KartyaMegjelenites.pictureBox1.Enabled = false;
                    Program.MunkaKartyak.Clear();
                }
            }
                        
        }
    }
}
