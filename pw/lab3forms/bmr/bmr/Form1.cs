using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if((m.Checked || k.Checked) && !String.IsNullOrEmpty(waga.Text) && !String.IsNullOrEmpty(wzrost.Text) && !String.IsNullOrEmpty(wiek.Text))
                {
                    wynik.ForeColor = Color.Blue;
                    if (m.Checked) wynik.Text = "BMR = " + (9.99*Convert.ToDouble(waga.Text)+6.25*Convert.ToDouble(wzrost.Text)-4.92*Convert.ToDouble(wiek.Text)+5);
                    else wynik.Text = "BMR = " + (9.99 * Convert.ToDouble(waga.Text) + 6.25 * Convert.ToDouble(wzrost.Text) - 4.92 * Convert.ToDouble(wiek.Text) - 161);
                }
                else
                {
                    wynik.ForeColor = Color.Red;
                    wynik.Text = "Uzupełnij wszystkie pola!";
                }

            }
            catch
            {
                wynik.ForeColor = Color.Red;
                wynik.Text = "Wprowadź poprawne dane!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            waga.Text = "";
            wzrost.Text = "";
            wiek.Text = "";
            m.Checked = false;
            k.Checked = false;
            wynik.Text = "";
        }
    }
}
