using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memoria
{
    public class Kartya
    {
        public bool felforditva;
        public bool megoldva;
        public KartyaControl KartyaMegjelenites;
        public int ID;

        public Kartya()
        {
            felforditva = false;
            megoldva = false;
            KartyaMegjelenites = new KartyaControl(this);
        }
    }
}
