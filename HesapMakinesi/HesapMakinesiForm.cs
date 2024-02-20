using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesiForm : Form
    {
        private double sayi1 = 0;
        private double sayi2 = 0;
        private string islem = "";
        private bool yeniSayiGiris = true;

        public HesapMakinesiForm()
        {
            InitializeComponent();
        }

        private void HesapMakinesiForm_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler...
        }

        private void SayiButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (yeniSayiGiris)
            {
                txtGirilenDeger.Text = btn.Text;
                yeniSayiGiris = false;
            }
            else
            {
                txtGirilenDeger.Text += btn.Text;
            }
        }

        private void IslemButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            islem = btn.Text;
            sayi1 = double.Parse(txtGirilenDeger.Text);
            yeniSayiGiris = true;
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(txtGirilenDeger.Text);

            switch (islem)
            {
                case "+":
                    lblSonuc.Text = (sayi1 + sayi2).ToString();
                    break;
                case "-":
                    lblSonuc.Text = (sayi1 - sayi2).ToString();
                    break;
                case "x":
                    lblSonuc.Text = (sayi1 * sayi2).ToString();
                    break;
                case "/":
                    if (sayi2 != 0)
                        lblSonuc.Text = (sayi1 / sayi2).ToString();
                    else
                        lblSonuc.Text = "Hata";
                    break;
                default:
                    break;
            }

            yeniSayiGiris = true;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            txtGirilenDeger.Clear();
            sayi1 = 0;
            sayi2 = 0;
            islem = "";
            yeniSayiGiris = true;
        }
    }
}
