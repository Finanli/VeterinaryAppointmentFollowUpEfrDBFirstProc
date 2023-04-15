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
    public partial class Islem : Form
    {
        public Islem()
        {
            InitializeComponent();
        }

        VeterinerRandevuEntities baglan = new VeterinerRandevuEntities();   
        private void listb_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglan.IslemListele().ToList();


        }

        private void addb_Click(object sender, EventArgs e)
        {
            Islemler save = new Islemler();
            save.islemAd = aditxt.Text;
            save.islemUcret = Convert.ToDecimal(ucrettxt.Text);

            baglan.IslemEkle(save.islemAd, save.islemUcret);
            dataGridView1.DataSource = baglan.IslemListele().ToList();

            aditxt.Clear();
            ucrettxt.Clear();
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            int ino = Convert.ToInt32(aditxt.Tag);
            Islemler yenile = new Islemler();
            yenile.islemAd = aditxt.Text;
            yenile.islemUcret = Convert.ToDecimal(ucrettxt.Text);

            baglan.IslemGuncelle(ino,yenile.islemAd, yenile.islemUcret);
            dataGridView1.DataSource = baglan.IslemListele().ToList();
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            int ino = Convert.ToInt32(aditxt.Tag);
            Islemler sil = new Islemler();
            baglan.IslemSil(ino);
            dataGridView1.DataSource = baglan.IslemListele().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            aditxt.Tag = satir.Cells["islemNo"].Value.ToString();
            aditxt.Text = satir.Cells["islemAd"].Value.ToString();
            ucrettxt.Text = satir.Cells["islemUcret"].Value.ToString();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Islemler ara = new Islemler();
            ara.islemAd = aditxt.Text;

            dataGridView1.DataSource = baglan.IslemAdAra(ara.islemAd).ToList();
        }
    }
}
