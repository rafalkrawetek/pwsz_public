using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] mnoznik = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 0 };
            try
            {
                if (pesel.Text.Length == 11)
                {
                    int suma = 0;
                    for(int i = 0; i < 10; i++)
                    {
                        if (pesel.Text[i] < 48 || pesel.Text[i] > 57)
                        {
                            Debug.WriteLine(pesel.Text[i]);
                            throw new Exception();
                        }
                        suma += (pesel.Text[i]-48)*mnoznik[i];
                    }
                    if ((10 - suma % 10) == (pesel.Text[10] - 48))
                    {
                        wynik.ForeColor = Color.Green;
                        wynik.Text = "Wprowadzony pesel jest prawidłowy!";
                    }
                    else
                    {
                        wynik.ForeColor = Color.Red;
                        wynik.Text = "Wprowadzony pesel jest nieprawidłowy!";
                    }
                }
                else
                {
                    wynik.ForeColor = Color.Red;
                    wynik.Text = "Wprowadź pesel o prawidłowej długości (11 cyfr)!";
                }

            }
            catch
            {
                wynik.ForeColor = Color.Red;
                wynik.Text = "Wprowadź poprawne dane (11 cyfr)!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesel.Text = "";
            wynik.Text = "";
        }
    }
}
