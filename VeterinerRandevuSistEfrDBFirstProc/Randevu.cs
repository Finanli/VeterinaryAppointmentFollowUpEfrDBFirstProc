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
    public partial class Randevu : Form
    {
        public Randevu()
        {
            InitializeComponent();
        }

        VeterinerRandevuEntities baglan = new VeterinerRandevuEntities();

        private void exitb_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listb_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglan.RandevuListele().ToList();
        }

        private void addb_Click(object sender, EventArgs e)
        {
            Randevular save = new Randevular();
            //string hstad = hastacbx.Text;
            //var hst = baglan.Hastalars.Where(x => x.hastaAdi == hstad).Select(x=> x.hastano).FirstOrDefault();
            //string clsad = calisancbx.Text;
            //var cls = baglan.Calisanlars.Where(x => x.calisanAdi == clsad).Select(x => x.calisanNo).FirstOrDefault();
            //string islad = islemcbx.Text;
            //var isl = baglan.Islemlers.Where(x => x.islemAd == clsad).Select(x => x.islemNo).FirstOrDefault();



            save.hastano = Convert.ToInt32(hastacbx.SelectedValue);
            save.calisanNo = Convert.ToInt32(calisancbx.SelectedValue);
            save.islemNo = Convert.ToInt32(islemcbx.SelectedValue);
            save.RandevuDate = Convert.ToDateTime(maskedTextBox1.Text);

            baglan.RandevuEkle(save.hastano, save.calisanNo, save.islemNo, save.RandevuDate);
            dataGridView1.DataSource = baglan.RandevuListele().ToList();



        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            hastacbx.DataSource = baglan.Hastalars.ToList();
            hastacbx.ValueMember = "hastaNo";
            hastacbx.DisplayMember = "hastaAdi";

            calisancbx.DataSource = baglan.Calisanlars.ToList();
            calisancbx.ValueMember = "calisanNo";
            calisancbx.DisplayMember = "calisanAdi";


            islemcbx.DataSource = baglan.Islemlers.ToList();
            islemcbx.ValueMember = "islemNo";
            islemcbx.DisplayMember = "islemAd";
        }

        private void updateb_Click(object sender, EventArgs e)
        {
            int randno = Convert.ToInt32(hastacbx.Tag);
            Randevular yenile = new Randevular();
            //string hstad = hastacbx.Text;
            //var hst = baglan.Hastalars.Where(x => x.hastaAdi == hstad).Select(x => x.hastano).FirstOrDefault();
            //string clsad = calisancbx.Text;
            //var cls = baglan.Calisanlars.Where(x => x.calisanAdi == clsad).Select(x => x.calisanNo).FirstOrDefault();
            //string islad = islemcbx.Text;
            //var isl = baglan.Islemlers.Where(x => x.islemAd == clsad).Select(x => x.islemNo).FirstOrDefault();

            
            yenile.hastano = Convert.ToInt32(hastacbx.SelectedValue);
            yenile.calisanNo = Convert.ToInt32(calisancbx.SelectedValue);
            yenile.islemNo = Convert.ToInt32(islemcbx.SelectedValue);
            yenile.RandevuDate = Convert.ToDateTime(maskedTextBox1.Text);

            baglan.RandevuGuncelle(randno,yenile.hastano, yenile.calisanNo, yenile.islemNo, yenile.RandevuDate);
            dataGridView1.DataSource = baglan.RandevuListele().ToList();
        }

        private void deleteb_Click(object sender, EventArgs e)
        {
            int randno = Convert.ToInt32(hastacbx.Tag);
            //Randevular yenile = new Randevular();
            baglan.RandevuSil(randno);
            dataGridView1.DataSource = baglan.RandevuListele().ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            hastacbx.Tag = satir.Cells["randevuNo"].Value.ToString();
            hastacbx.SelectedItem = satir.Cells["hastaNo"].Value.ToString();
            calisancbx.SelectedItem = satir.Cells["calisanNo"].Value.ToString();
            islemcbx.SelectedItem = satir.Cells["islemNo"].Value.ToString();
            maskedTextBox1.Text = satir.Cells["RandevuDate"].Value.ToString();
        }
    }
}
