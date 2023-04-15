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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void hastab_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Hasta hasta = new Hasta();
            hasta.TopLevel = false;
            scpanel.Controls.Add(hasta); 
            hasta.Show();
            hasta.Dock = DockStyle.Fill;
            hasta.BringToFront();

        }

        private void calisanb_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Calisan cls = new Calisan();
            cls.TopLevel = false;
            scpanel.Controls.Add(cls);
            cls.Show();
            cls.Dock = DockStyle.Fill;
            cls.BringToFront();
        }

        private void islemb_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Islem islm = new Islem();
            islm.TopLevel = false;
            scpanel.Controls.Add(islm);
            islm.Show();
            islm.Dock = DockStyle.Fill;
            islm.BringToFront();
        }

        private void kullanicib_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Kullanici kln = new Kullanici();
            kln.TopLevel = false;
            scpanel.Controls.Add(kln);
            kln.Show();
            kln.Dock = DockStyle.Fill;
            kln.BringToFront();
        }

        private void randb_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Randevu rdv = new Randevu();
            rdv.TopLevel = false;
            scpanel.Controls.Add(rdv);
            rdv.Show();
            rdv.Dock = DockStyle.Fill;
            rdv.BringToFront();
        }

        private void raporlarb_Click(object sender, EventArgs e)
        {
            scpanel.Controls.Clear();
            Rapor rpr = new Rapor();
            rpr.TopLevel = false;
            scpanel.Controls.Add(rpr);
            rpr.Show();
            rpr.Dock = DockStyle.Fill;
            rpr.BringToFront();
        }
    }
}
