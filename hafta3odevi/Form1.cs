using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hafta3odevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> Liste_AdSoyad = new List<string>();
        List<string> Liste_OgrenciNo = new List<string>();
        List<string> Liste_BolumAdi = new List<string>();
        int sayac = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_adsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_ogrno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_bolumadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ogrekle_Click(object sender, EventArgs e)
        {
            Liste_AdSoyad.Add(txtbx_adsoyad.Text);
            Liste_OgrenciNo.Add(txtbx_ogrno.Text);
            Liste_BolumAdi.Add(txtbx_bolumadi.Text);
            sayac++;
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayac; i++)
            {
                string deger = Liste_AdSoyad[i] + " " + Liste_OgrenciNo[i] + " " + Liste_BolumAdi[i];
                listBox1.Items.Add(deger);
                comboBox1.Items.Add(deger);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
        }

        private void txtbx_ara_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            int sonuc = Liste_AdSoyad.Where(ayse => ayse.Contains(txtbx_ara.Text)).Count();
            MessageBox.Show(txtbx_ara.Text + "'de aradığın isim listede " + sonuc + " kadar bulunmaktadır");

        }

        private void txt_hosgel_Click(object sender, EventArgs e)
        {

        }
    }
}
