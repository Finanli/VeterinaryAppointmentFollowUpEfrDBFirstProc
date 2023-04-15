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
    public partial class Calisan : Form
    {
        public Calisan()
        {
            InitializeComponent();
        }
        VeterinerRandevuEntities baglan = new VeterinerRandevuEntities();

        private void listb_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglan.CalisanListele().ToList();
        }

        private void addb_Click(object sender, EventArgs e)
        {
            Calisanlar save = new Calisanlar();
            save.calisanAdi = caditxt.Text;
            save.statu = statutxt.Text;

            baglan.CalisanEkle(save.calisanAdi, save.statu);
            dataGridView1.DataSource = baglan.CalisanListele().ToList();

            caditxt.Clear();
            statutxt.Clear();
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            int calno = Convert.ToInt32(caditxt.Text);
            Calisanlar yenile = new Calisanlar();
            yenile.calisanAdi = caditxt.Text;
            yenile.statu = statutxt.Text;

            baglan.CalisanGuncelle(calno,yenile.calisanAdi, yenile.statu);
            dataGridView1.DataSource = baglan.CalisanListele().ToList();
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            int calno = Convert.ToInt32(caditxt.Text);
            Calisanlar sil = new Calisanlar();

            baglan.CalisanSil(calno);
            dataGridView1.DataSource = baglan.CalisanListele().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            caditxt.Tag = satir.Cells["calisanNo"].Value.ToString();
            caditxt.Text = satir.Cells["calisanAdi"].Value.ToString();
            statutxt.Text = satir.Cells["statu"].Value.ToString();

        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisanlar ara = new Calisanlar();
            ara.calisanAdi = caditxt.Text;

            dataGridView1.DataSource = baglan.CalAdiAra(ara.calisanAdi).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calisanlar ara = new Calisanlar();
            ara.statu = statutxt.Text;

            dataGridView1.DataSource = baglan.CalStatAra(ara.statu).ToList();
        }
    }
}
