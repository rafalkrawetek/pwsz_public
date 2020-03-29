using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KostkaDoGry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 'r')
            {
                Random random = new Random();
                wynik.Text = "Wylosowano liczbę: " + Convert.ToString(random.Next(1, 7));
            }
        }

        private void ToClipboard(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = (Label)sender;
                Clipboard.SetText(label.Text);
            }
        }
    }
}
