using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinerRandevuSistEfrDBFirstProc
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

        VeterinerRandevuEntities baglan = new VeterinerRandevuEntities();
        private void listb_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglan.KullaniciListele().ToList();  

        }

        private void addb_Click(object sender, EventArgs e)
        {
            Kullanicilar save = new Kullanicilar();
            save.kullaniciAd = aditxt.Text;
            save.sifre = sifretxt.Text;

            baglan.KullaniciEkle(save.kullaniciAd, save.sifre);
            dataGridView1.DataSource = baglan.KullaniciListele().ToList();

            aditxt.Clear();
            sifretxt.Clear();

        }

        private void updateb_Click(object sender, EventArgs e)
        {
            int kulno = Convert.ToInt32(aditxt.Tag);
            Kullanicilar yenile = new Kullanicilar();
            yenile.kullaniciAd = aditxt.Text;
            yenile.sifre = sifretxt.Text;
            
            baglan.KullaniciGuncelle(kulno, yenile.kullaniciAd, yenile.sifre);
            dataGridView1.DataSource = baglan.KullaniciListele().ToList();
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            int kulno = Convert.ToInt32(aditxt.Tag);
            //Kullanicilar sil = new Kullanicilar();

            baglan.KullaniciSil(kulno);
            dataGridView1.DataSource = baglan.KullaniciListele().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            aditxt.Tag = satir.Cells["kullaniciNo"].Value.ToString();
            aditxt.Text = satir.Cells["kullaniciAd"].Value.ToString();
            sifretxt.Text = satir.Cells["sifre"].Value.ToString();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kullanicilar ara = new Kullanicilar();
            ara.kullaniciAd = aditxt.Text;

            dataGridView1.DataSource = baglan.KullaniciAra(ara.kullaniciAd).ToList(); ;
        }
    }
}
