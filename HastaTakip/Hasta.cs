using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaTakip
{
    class Hasta
    {
        public string adi;
        public int ucret;
        public int dogumyili;
        public string cinsiyet;

        public int yas;
        public int indirimliucret;

        public void YasHesapla()
        {
            yas = 2018 - dogumyili;

        }

        public void IndirimliUcretHesapla ()
        {
            if (yas>65)
            {
                indirimliucret = 0;
            }
            else if (cinsiyet=="Kadın")
            {
                indirimliucret = ucret * 80 / 100;
            }
            else if (yas<15)
            {
                indirimliucret = ucret * 50 / 100;
            }
            else 
            {
                indirimliucret = ucret;
            }
        }

    }
}
