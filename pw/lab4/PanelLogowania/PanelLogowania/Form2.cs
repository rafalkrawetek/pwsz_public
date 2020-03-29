using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelLogowania
{
    public partial class Form2 : Form
    {
        public string login;
        public bool logged = false;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (logged)
            {
                show.ForeColor = Color.Green;
                show.Text = "Zalogowano jako: " + login;
            }
            else
            {
                show.ForeColor = Color.Red;
                show.Text = "Logowanie nie powiodło się";
            }
        }
    }
}
