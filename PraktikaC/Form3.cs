using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PraktikaC
{
    public partial class Form3 : Form
    {

        public string connectionString = @"Data Source=localhost;Initial Catalog=Praktika;User ID=sa;Password=sa";

        public Form3()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(1) FROM prisijungimas WHERE naudotojo_vardas=@naudotojo_vardas AND slaptazodis=@slaptazodis";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@naudotojo_vardas", textBox1.Text);
                cmd.Parameters.AddWithValue("@slaptazodis", textBox2.Text);
                con.Open();
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 1)
                {
                    // Paslėpti prisijungimo formą

                    // Rodyti pagrindinę formą



                    this.Hide();
                    Form1 sistema = new Form1();
                    sistema.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Įvestas neteisingas naudotojo vardas arba slaptažodis.", "Įspėjimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

    }
}