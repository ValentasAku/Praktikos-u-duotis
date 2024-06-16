using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;
using System.Windows.Markup;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Windows.Input;
using System.ComponentModel.Design;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PraktikaC
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=Praktika;User ID=sa;Password=sa";

        public Form1()
        {
            InitializeComponent();
        }

        ////////////////// ATNAUJINTI //////////////////////////////////
        private void button1_Click(object sender, EventArgs e)
        {
            //Rodyti baze
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string Query = "SELECT Pinigai.ID, Kaina, Data, Komentaras, Srautas, Tipas, Saltinis FROM Pinigai inner join Saltinis on Pinigai.SaltinisID=Saltinis.ID inner join Srautas on Pinigai.SrautoID=Srautas.ID inner join Tipas on Srautas.TipasID=Tipas.ID ";
            SqlCommand cmd = new SqlCommand(Query, connection);
            var reader = cmd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            dataGridView1.DataSource = table;
            connection.Close();
            skaiciai(sender, e);

        }
        /////////////////// ATNAUJINTI ////////////////////////////////////


        private void Form1_Load(object sender, EventArgs e)
        {
           
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string srautasidgauti = "SELECT ID, Srautas FROM dbo.Srautas";
            using (SqlCommand cmd = new SqlCommand(srautasidgauti, connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable kategorijaTable = new DataTable();
                kategorijaTable.Load(reader);
                srautas.DataSource = kategorijaTable;
                srautas.DisplayMember = "Srautas";
                srautas.ValueMember = "ID";
            }


            string saltinisgauti = "SELECT ID, Saltinis FROM dbo.Saltinis";
            using (SqlCommand cmd = new SqlCommand(saltinisgauti, connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable kategorijaTable = new DataTable();
                kategorijaTable.Load(reader);
                saltinis.DataSource = kategorijaTable;
                saltinis.DisplayMember = "Saltinis";
                saltinis.ValueMember = "ID";
            }

            
            string Srautasgauti = "SELECT ID, Tipas, Daugiklis FROM dbo.Tipas";
            using (SqlCommand cmd = new SqlCommand(Srautasgauti, connection))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                DataTable kategorijaTable = new DataTable();
                kategorijaTable.Load(reader);
                listBox1.DataSource = kategorijaTable;
                listBox1.DisplayMember = "Tipas";
                listBox1.ValueMember = "ID";
            }
            
            ///////////////////////////////////////////////////////////////







            string Komentarasgauti = "SELECT value FROM dbo.Prisiminimai WHERE pavadinimas = @pavad";
            using (SqlCommand cmd = new SqlCommand(Komentarasgauti, connection))
            {
                cmd.Parameters.AddWithValue("@pavad", "Komentaras");

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // Ensure there is a result
                    {
                        int reiksme = reader.GetInt32(0); // Get the value as an integer
                        combox.Checked = (reiksme == 1); // Set combox.Checked based on the value
                    }
                }
            }



            /////////////////////// Ikelti tekstas //////////////////////////////////
            if (combox.Checked)
            {
                string Komentarastekstasgauti = "SELECT text FROM dbo.Prisiminimai WHERE pavadinimas = @pavad";
                using (SqlCommand cmd = new SqlCommand(Komentarastekstasgauti, connection))
                {
                    cmd.Parameters.AddWithValue("@pavad", "komentarastekstas");
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Ensure there is a result
                        {
                            string textValue = reader.GetString(0); // Get the value as a string
                            komentaras.Text = textValue; // Set the text to komentaras.Text
                        }
                    }
                }
            }


            //Rodyti baze
            string tablerodys = "SELECT Pinigai.ID, Kaina, Data, Komentaras, Srautas, Tipas, Saltinis FROM Pinigai inner join Saltinis on Pinigai.SaltinisID=Saltinis.ID inner join Srautas on Pinigai.SrautoID=Srautas.ID inner join Tipas on Srautas.TipasID=Tipas.ID ";
            SqlCommand baze = new SqlCommand(tablerodys, connection);
            var tablerodymas = baze.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(tablerodymas);
            dataGridView1.DataSource = table;
            connection.Close();







            skaiciai(sender, e);


        }







        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////OBJEKTINIS/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////// ON LOAD //////////////////////

        public void skaiciai(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Kaina FROM Pinigai";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        decimal totalSum = 0;
                        decimal positiveSum = 0;
                        decimal negativeSum = 0;

                        while (reader.Read())
                        {
                            decimal kaina = reader.GetDecimal(0); // Read as Decimal

                            totalSum += kaina;

                            if (kaina > 0)
                            {
                                positiveSum += kaina;
                            }
                            else if (kaina < 0)
                            {
                                negativeSum += kaina;
                            }
                        }

                        sum.Text = totalSum.ToString();
                        gain.Text = positiveSum.ToString();
                        lost.Text = negativeSum.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }
            }
        }





        

        public void trinimas(int id)
        {
            string sql = "DELETE FROM dbo.Pinigai WHERE ID = @rowID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand deleteRecord = new SqlCommand(sql, connection))
                {
                    deleteRecord.Parameters.AddWithValue("@rowID", id);
                    connection.Open();
                    deleteRecord.ExecuteNonQuery();
                }
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////////////////////////////////////OBJEKTINIS/////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////












        /////////////////// SEND DATA /////////////////////////////////////

        public void send_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();


            string sumaszod = suma.Text;
            float sumaskaic;
            float.TryParse(sumaszod, out sumaskaic);
            DataRowView selectedRow = listBox1.SelectedItem as DataRowView;

            int daugiklis = Convert.ToInt32(selectedRow["Daugiklis"]);
            sumaskaic *= daugiklis;


            string query = "INSERT INTO dbo.Pinigai (SrautoID, SaltinisID, Kaina, Data, Komentaras) VALUES (@idsrauto, @saltiniolaukas, @kainalaukas, @datalaukas, @komentaraslaukas)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@idsrauto", (int)srautas.SelectedValue);
            command.Parameters.AddWithValue("@saltiniolaukas", (int)saltinis.SelectedValue);
            command.Parameters.AddWithValue("@kainalaukas", sumaskaic);
            command.Parameters.AddWithValue("@datalaukas", data.Value);
            command.Parameters.AddWithValue("@komentaraslaukas", komentaras.Text);





            string komcheck = "UPDATE dbo.Prisiminimai SET value = @value WHERE pavadinimas = @pavad";
            SqlCommand commanda = new SqlCommand(komcheck, connection);
            commanda.Parameters.AddWithValue("@value", combox.Checked);
            commanda.Parameters.AddWithValue("@pavad", "komentaras");
            commanda.ExecuteNonQuery();




            ///////////SAUGOTI KOMENTARA TIK PAZIMEJUS 
            if (combox.Checked == true)
            {
                // Update existing record
                string updateQuery = "UPDATE dbo.Prisiminimai SET text = @value WHERE pavadinimas = @pavad";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                {
                    updateCmd.Parameters.AddWithValue("@value", komentaras.Text);
                    updateCmd.Parameters.AddWithValue("@pavad", "komentarastekstas");
                    updateCmd.ExecuteNonQuery();
                }
            }


            if (combox.Checked == false)
            {
                komentaras.Text = "";
            }



            command.ExecuteNonQuery();
            MessageBox.Show("Nuskrido sëkmingai", "Siuntimas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }















        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                DataRowView selectedRow = listBox1.SelectedItem as DataRowView;
                if (selectedRow != null)
                {
                    int selectedTipasId = Convert.ToInt32(selectedRow["ID"]);

                    SqlConnection connection = new SqlConnection(connectionString);
                    {
                        connection.Open();

                        // Query gauti geras kategorijas pagal pasirinktà tipà (pajamos ar iðlaidos)
                        string queryKategorija = "SELECT ID, Srautas FROM Srautas WHERE TipasID = @TipasID";
                        SqlCommand cmd = new SqlCommand(queryKategorija, connection);
                        {
                            cmd.Parameters.AddWithValue("@TipasID", selectedTipasId);
                            SqlDataReader reader = cmd.ExecuteReader();
                            {
                                DataTable kategorijaTable = new DataTable();
                                kategorijaTable.Load(reader);
                                srautas.DataSource = kategorijaTable;
                                srautas.DisplayMember = "Pavadinimas";
                                srautas.ValueMember = "ID";

                                connection.Close();

                            }
                        }
                    }
                }
            }
        }









        private void delete_Click_1(object sender, EventArgs e)
        {
            //Trinti irasa (pasirenkant visa eilute)
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

            trinimas(rowID);

            dataGridView1.Rows.RemoveAt(selectedIndex);
        }





















        ///////////////////////// UPDATE //////////////////////////////////
        public void update_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            UPDATE dbo.Pinigai 
            SET SrautoID = @idsrauto, 
                SaltinisID = @saltiniolaukas, 
                Kaina = @kainalaukas, 
                Data = @datalaukas, 
                Komentaras = @komentaraslaukas 
            WHERE ID = @rowID";

                string sumaszod = suma.Text;
                int sumaskaic;
                int.TryParse(sumaszod, out sumaskaic);
                DataRowView selectedRow = listBox1.SelectedItem as DataRowView;
                int daugiklis = Convert.ToInt32(selectedRow["Daugiklis"]);
                sumaskaic *= daugiklis;

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idsrauto", (int)srautas.SelectedValue);
                    command.Parameters.AddWithValue("@saltiniolaukas", (int)saltinis.SelectedValue);
                    command.Parameters.AddWithValue("@kainalaukas", sumaskaic);
                    command.Parameters.AddWithValue("@datalaukas", data.Value);
                    command.Parameters.AddWithValue("@komentaraslaukas", komentaras.Text);
                    command.Parameters.AddWithValue("@rowID", rowID);

                    command.ExecuteNonQuery();
                }
            }

            // Call the method to update sum, gain, and lost values

            MessageBox.Show("Áraðas atnaujintas sëkmingai.", "Atnaujinta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        ///////////////////////// UPDATE //////////////////////////////////







        //////////////////// PASIRINKUS PERKELTI DUOMENIS I LAULKELIUS ////////////////////////////
        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;

            int selectedIndex = dataGridView1.SelectedRows[0].Index;
            int rowID = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT Pinigai.SrautoID, Pinigai.SaltinisID, Pinigai.Kaina, Pinigai.Data, Pinigai.Komentaras, Srautas.TipasID 
            FROM Pinigai 
            INNER JOIN Srautas ON Pinigai.SrautoID = Srautas.ID 
            WHERE Pinigai.ID = @rowID";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@rowID", rowID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int selectedTipasId = Convert.ToInt32(reader["TipasID"]);
                            srautas.SelectedValue = reader["SrautoID"];
                            saltinis.SelectedValue = reader["SaltinisID"];
                            //.suma.Text = reader["Kaina"];
                            data.Value = Convert.ToDateTime(reader["Data"]);
                            komentaras.Text = reader["Komentaras"].ToString();

                            // Load Srautas by Tipas after closing the first reader
                            reader.Close();
                            LoadSrautasByTipas(selectedTipasId, connection);
                        }
                    }
                }
            }
        }

        private void LoadSrautasByTipas(int tipasID, SqlConnection connection)
        {
            string query = "SELECT ID, Srautas FROM Srautas WHERE TipasID = @TipasID";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@TipasID", tipasID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Load(reader);
                    srautas.DataSource = table;
                    srautas.DisplayMember = "Srautas";
                    srautas.ValueMember = "ID";
                }
            }

            // Set the listBox1 SelectedValue
            foreach (DataRowView item in listBox1.Items)
            {
                if ((int)item["ID"] == tipasID)
                {
                    listBox1.SelectedValue = item["ID"];
                    break;
                }
            }
        }

        private void ataskaitos_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            
        }


        ///
    }
}
