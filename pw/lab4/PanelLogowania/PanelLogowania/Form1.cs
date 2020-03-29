using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        ArrayList Users = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            Users.Add(new User("admin", "admin"));
            Users.Add(new User("user1", "password1"));
            Users.Add(new User("jankowalski", "kowalskijan"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            foreach(User user in Users)
            {
                if(String.Compare(user.login,loginbox.Text)==0)
                    if (String.Compare(user.passhash, Program.MD5(passbox.Text)) == 0)
                    {
                        f.login = user.login;
                        f.logged = true;
                    }
            }
            f.Show();
        }
    }
}
