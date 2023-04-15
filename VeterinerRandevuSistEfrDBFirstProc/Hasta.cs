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
    public partial class Hasta : Form
    {
        public Hasta()
        {
            InitializeComponent();
        }

        VeterinerRandevuEntities baglan = new VeterinerRandevuEntities();

        private void listb_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglan.HastaListele().ToList();
        }

        private void addb_Click(object sender, EventArgs e)
        {
            Hastalar save = new Hastalar();
            save.hastaAdi = haditxt.Text;
            save.hastaCinsi = hcinstxt.Text;
            save.hastaYas = Convert.ToInt32(hyastxt.Text);
            save.Ebeveyn = ebeveyntxt.Text;
            save.Tel = maskedTextBox1.Text;

            baglan.HastaEkle(save.hastaAdi, save.hastaCinsi, save.hastaYas, save.Ebeveyn, save.Tel);
            dataGridView1.DataSource = baglan.HastaListele().ToList();

            haditxt.Clear();
            hcinstxt.Clear();
            hyastxt.Clear();
            ebeveyntxt.Clear();
            maskedTextBox1.Clear();
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            int hastano = Convert.ToInt32(haditxt.Tag);
            Hastalar yenile = new Hastalar();
            yenile.hastaAdi = haditxt.Text;
            yenile.hastaCinsi = hcinstxt.Text;
            yenile.hastaYas = Convert.ToInt32(hyastxt.Text);
            yenile.Ebeveyn = ebeveyntxt.Text;
            yenile.Tel = maskedTextBox1.Text;
            baglan.HastaGuncelle(hastano, yenile.hastaAdi, yenile.hastaCinsi, yenile.hastaYas, yenile.Ebeveyn, yenile.Tel);
            dataGridView1.DataSource = baglan.HastaListele().ToList();
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            int hastano = Convert.ToInt32(haditxt.Tag);
            Hastalar sil = new Hastalar();
            baglan.HastaSil(hastano);
            dataGridView1.DataSource = baglan.HastaListele().ToList();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            haditxt.Tag = satir.Cells["hastaNo"].Value.ToString();
            haditxt.Text = satir.Cells["hastaAdi"].Value.ToString();
            hcinstxt.Text = satir.Cells["hastaCinsi"].Value.ToString();
            hyastxt.Text = satir.Cells["hastaYas"].Value.ToString();
            ebeveyntxt.Text = satir.Cells["ebeveyn"].Value.ToString();
            maskedTextBox1.Text = satir.Cells["tel"].Value.ToString();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hastalar ara = new Hastalar();
            if (haditxt.Text != null)
            {
                ara.hastaAdi = haditxt.Text;
                dataGridView1.DataSource = baglan.HastaAdAra(ara.hastaAdi).ToList();
            }
            else if (hcinstxt.Text != null)
            {
                ara.hastaCinsi = hcinstxt.Text;
                dataGridView1.DataSource = baglan.HastaCinsAra(ara.hastaCinsi).ToList();
            }
            else if (hyastxt.Text != null)
            {
                ara.hastaYas = Convert.ToInt32(hyastxt.Text);
                dataGridView1.DataSource = baglan.HastaYasAra(ara.hastaYas).ToList();
            }
            else if (ebeveyntxt.Text != null)
            {
                ara.Ebeveyn = ebeveyntxt.Text;
                dataGridView1.DataSource = baglan.HastaEbeveynAra(ara.Ebeveyn).ToList();
            }
            else if (maskedTextBox1.Text != null)
            {
                ara.Tel = maskedTextBox1.Text;
                dataGridView1.DataSource = baglan.EbeveynTelAra(ara.Tel).ToList();
            }
        }
    }
}
