using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KAFE
{
    public partial class Form1 : Form
    {
        int caySayisi=0;
        int kahveSayisi=0;
        int kolaSayisi=0;
        int limonataSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cayArtiButton_Click(object sender, EventArgs e)
        {
            caySayisi++;
            caySayisiLabel.Text = Convert.ToString(caySayisi);
            
        }

        private void cayEksiButton_Click(object sender, EventArgs e)
        {
            
            if (caySayisi>0)
            {
                caySayisi--;
                caySayisiLabel.Text = Convert.ToString(caySayisi);
            }
            
        }

        private void kahveArtiButton_Click(object sender, EventArgs e)
        {
           
            kahveSayisi++;
            kahveSayisiLabel.Text = Convert.ToString(kahveSayisi);
        }

        private void kahveEksiButton_Click(object sender, EventArgs e)
        {
          
            if (kahveSayisi>0)
            {
                kahveSayisi--;
                kahveSayisiLabel.Text = Convert.ToString(kahveSayisi);
            }
            
        }

        private void kolaArtiButton_Click(object sender, EventArgs e)
        {

            kolaSayisi++;
            kolaSayisiLabel.Text = Convert.ToString(kolaSayisi);
        }

        private void kolaEksiButton_Click(object sender, EventArgs e)
        {
            
            if (kolaSayisi>0)
            {
                kolaSayisi--;
                kolaSayisiLabel.Text = Convert.ToString(kolaSayisi);
            }
            
        }
        private void limonataArtiButton_Click(object sender, EventArgs e)
        {
            limonataSayisi++;
            limonataSayisiLabel.Text = Convert.ToString(limonataSayisi);
        }

        private void limonataEksiButton_Click(object sender, EventArgs e)
        {
            if (limonataSayisi > 0)
            {
                limonataSayisi--;
                limonataSayisiLabel.Text = Convert.ToString(limonataSayisi);
            }
        }

        private void sifirlaButton_Click(object sender, EventArgs e)
        {
            caySayisi = 0;
            kahveSayisi = 0;
            kolaSayisi = 0;
            limonataSayisi = 0;


            caySayisiLabel.Text = "0";
            kahveSayisiLabel.Text = "0";
            kolaSayisiLabel.Text = "0";
            limonataSayisiLabel.Text = "0";
        }

        private void siparisiTamamlaButton_Click(object sender, EventArgs e)
        {
            if (caySayisi==0 && kahveSayisi==0 && kolaSayisi==0 && limonataSayisi==0)
            {
                MessageBox.Show("Lütfen Siparişinizi Eksiksiz Giriniz.", "Hatalı Sipariş!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show( "Siparişiniz Alındı!", "Afiyet Olsun...", MessageBoxButtons.OK, MessageBoxIcon.Information );
                caySayisiLabel.Text = "0";
                kahveSayisiLabel.Text = "0";
                kolaSayisiLabel.Text = "0";
                limonataSayisiLabel.Text = "0";

            }
           
            
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void siparisGroupBox_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
