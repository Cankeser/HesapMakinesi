using System;
using System.Data;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool optDurum = false;
        double sonuc = 0;
        string opt = "";

        public Form1()
        {
            InitializeComponent();
            txtGirilenDeger.Text = "0";
        }



        private void SayiButtonClick(object sender, EventArgs e)
        {
            if (txtGirilenDeger.Text == "0" || optDurum)
                txtGirilenDeger.Clear();

            optDurum = false;
            Button btn = (Button)sender;
            txtGirilenDeger.Text += btn.Text;

        }

        private void IslemButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string yeniOpt = btn.Text;
            lblSonuc.Text = lblSonuc.Text + " " + txtGirilenDeger.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+": txtGirilenDeger.Text = (sonuc + Double.Parse(txtGirilenDeger.Text)).ToString(); break;
                case "-": txtGirilenDeger.Text = (sonuc - Double.Parse(txtGirilenDeger.Text)).ToString(); break;
                case "/": txtGirilenDeger.Text = (sonuc / Double.Parse(txtGirilenDeger.Text)).ToString(); break;
                case "x": txtGirilenDeger.Text = (sonuc * Double.Parse(txtGirilenDeger.Text)).ToString(); break;
                default: break;
            }
            sonuc = Double.Parse(txtGirilenDeger.Text);
            optDurum = true;
            opt = yeniOpt;

        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {

            lblSonuc.Text = "";
            optDurum = true;
            switch (opt)
            {
                case "+": txtGirilenDeger.Text = (sonuc + Double.Parse(txtGirilenDeger.Text)).ToString(); break;
                case "-": txtGirilenDeger.Text = (sonuc - Double.Parse(txtGirilenDeger.Text)).ToString(); break;
                case "/": txtGirilenDeger.Text = (sonuc / Double.Parse(txtGirilenDeger.Text)).ToString(); break;
                case "x": txtGirilenDeger.Text = (sonuc * Double.Parse(txtGirilenDeger.Text)).ToString(); break;
                default: break;
            }
            sonuc = Double.Parse(txtGirilenDeger.Text);

            txtGirilenDeger.Text = sonuc.ToString("0.00");
            sonuc = 0; //atama yaptıktan sonra belleği boşaltıyor.
            opt = "";



        }

        private void bVirgul_Click(object sender, EventArgs e)
        {
            if (txtGirilenDeger.Text == "0")
            {
                txtGirilenDeger.Text = "0";
            }
            else if (optDurum)
            {
                txtGirilenDeger.Text = "0";
            }

            if (!txtGirilenDeger.Text.Contains(","))
            {
                txtGirilenDeger.Text += ",";
            }

            optDurum = false;

        }


        private void btnC_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text = "0";
            lblSonuc.Text = "";
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtGirilenDeger.Text = "0";

        }
    }
}
