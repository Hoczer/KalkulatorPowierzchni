using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorPowierzchni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PowierzchniaLiczButt_Click(object sender, EventArgs e)
        {
            decimal wysokosc=0;
            decimal szerokosc=0;
            decimal mnoznik=1;
            decimal wynik = 0;
            string result1 = null;
            string wysokoscString = wysokoscTextBoxPo.Text.Replace(".", ",");
            string szerokoscString = szerokoscTextBoxPo.Text.Replace(".", ",");
            string mnoznikString = mnoznikTextBoxPo.Text.Replace(".", ",");

            if (Decimal.TryParse(wysokoscString, out wysokosc))
            {

            }
            else
            {
                MessageBox.Show("Błędna wartość Wysokości", "Błąd");
                return;
            }
            if (Decimal.TryParse(szerokoscString, out szerokosc))
            {

            }
            else
            {
                MessageBox.Show("Błędna wartość Szerokości", "Błąd");
                return;
            }
            if (Decimal.TryParse(mnoznikString, out mnoznik))
            {

            }
            else
            {
                MessageBox.Show("Błędna wartość Mnożnika", "Błąd");
                return;
            }
            
            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        result1 = radio.Text;
                    }
                }
            }
            
            
            switch (result1)
            {
                
                case "mm":
                    wynik = (wysokosc * szerokosc) / 1000000;
                    wynik *= mnoznik;
                    wynikTextBoxPo.Text = wynik.ToString()+" m2";
                    break;
                case "cm":
                    wynik = (wysokosc * szerokosc) / 10000;
                    wynik *= mnoznik;
                    wynikTextBoxPo.Text = wynik.ToString()+" m2";
                    break;
                case "m":
                    wynik = wysokosc * szerokosc;
                    wynik *= mnoznik;
                    wynikTextBoxPo.Text = wynik.ToString()+ " m2";
                    break;
                default:
                    break;
            }
        }

        private void liczButtPr_Click(object sender, EventArgs e)
        {
            decimal scianka1 = 0;
            decimal scianka2 = 0;
            decimal dlugosc = 1;
            decimal wynik = 0;
            string result1 = null;
            string scianka1String = scianka1TBox.Text.Replace(".", ",");
            string scianka2String = scianka2TBox.Text.Replace(".", ",");
            string dlugoscString = dlugoscPrTBox.Text.Replace(".", ",");

            if (Decimal.TryParse(scianka1String, out scianka1))
            {

            }
            else
            {
                MessageBox.Show("Błędna wartość Wysokości", "Błąd");
                return;
            }
            if (Decimal.TryParse(scianka2String, out scianka2))
            {

            }
            else
            {
                MessageBox.Show("Błędna wartość Szerokości", "Błąd");
                return;
            }
            if (Decimal.TryParse(dlugoscString, out dlugosc))
            {

            }
            else
            {
                MessageBox.Show("Błędna wartość Długości", "Błąd");
                return;
            }

            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        result1 = radio.Text;
                    }
                }
            }


            switch (result1)
            {

                case "mm":
                    wynik = ((scianka1 * 2 +  scianka2 * 2) * dlugosc) / 1000000;
                    
                    wynikTextBoxPR.Text = wynik.ToString() + " m2";
                    break;
                case "cm":
                    wynik = ((scianka1 * 2 + scianka2 * 2) * dlugosc) / 10000;
                    
                    wynikTextBoxPR.Text = wynik.ToString() + " m2";
                    break;
                case "m":
                    wynik = ((scianka1 * 2 + scianka2 * 2) * dlugosc);
                    
                    wynikTextBoxPR.Text = wynik.ToString() + " m2";
                    break;
                default:
                    break;
            }
        }

        private void ruraLiczButton_Click(object sender, EventArgs e)
        {
            decimal srednica = 0;
            decimal pi = (decimal)Math.PI;
            decimal dlugosc = 1;
            decimal wynik = 0;
            string result1 = null;
            string srednicaString = srednicaTBox.Text.Replace(".", ",");
            
            string dlugoscString = dlugoscTboxRura.Text.Replace(".", ",");

            if (Decimal.TryParse(srednicaString, out srednica))
            {

            }
            else
            {
                MessageBox.Show("Błędna wartość Średnica", "Błąd");
                return;
            }
            
            if (Decimal.TryParse(dlugoscString, out dlugosc))
            {

            }
            else
            {
                MessageBox.Show("Błędna wartość Długości", "Błąd");
                return;
            }

            foreach (Control control in this.groupBox1.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        result1 = radio.Text;
                    }
                }
            }


            switch (result1)
            {

                case "mm":
                    wynik = ((srednica * pi) * dlugosc) / 1000000;

                    wynikTextBoxRura.Text = wynik.ToString() + " m2";
                    break;
                case "cm":
                    wynik = ((srednica * pi) * dlugosc) / 10000;

                    wynikTextBoxRura.Text = wynik.ToString() + " m2";
                    break;
                case "m":
                    wynik = ((srednica * pi) * dlugosc);

                    wynikTextBoxRura.Text = wynik.ToString() + " m2";
                    break;
                default:
                    break;
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tabControl1.SelectedTab == tabControl1.TabPages["PowierzchniaPage"])
                {
                    PowierzchniaLiczButt.PerformClick();
                }
                if (tabControl1.SelectedTab == tabControl1.TabPages["ProfilPage"])
                {
                    liczButtPr.PerformClick();
                }
                if (tabControl1.SelectedTab == tabControl1.TabPages["RuraPage"])
                {
                    ruraLiczButton.PerformClick();
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
