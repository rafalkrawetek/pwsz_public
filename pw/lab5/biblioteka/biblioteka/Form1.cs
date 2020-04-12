using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace biblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=biblioteka;";
            string query = "SELECT * FROM ksiazki";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Połączenie nawiązane. Wyświetlanie wyników... ");
                    while (reader.Read())
                    {
                        string[] row = {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)};
                        listBox1.Items.Add(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4] + " " + row[5]);
                    }
                    databaseConnection.Close();
                }
                else
                {
                    MessageBox.Show("Połączenie nawiązane. Brak rekordów do wyświetlenia.");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
