using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void HastaEkle_Click(object sender, EventArgs e)
        {
            DateTime dogumtarihi = datedogumtarihi.Value;
            
            Hasta hasta = new Hasta
            {
                adi = txtAdi.Text,
                ucret = Convert.ToInt32(txtUcret.Text),
                dogumyili = dogumtarihi.Year,
                cinsiyet = cmdCinsiyet.Text
            };

            hasta.YasHesapla();
            hasta.IndirimliUcretHesapla();
            dataGridView1.Rows.Add(hasta.adi, hasta.dogumyili, hasta.cinsiyet, hasta.ucret, hasta.indirimliucret, hasta.yas);
        }

        private void Hesapla_Click(object sender, EventArgs e)
        {
           
        }
    }
}
