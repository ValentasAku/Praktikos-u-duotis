using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using System;
using iText.Layout;
using iText.Pdfa;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using System.Configuration;

namespace PraktikaC
{
    public partial class Form2 : Form
    {
        string connectionString = @"Data Source=localhost;Initial Catalog=Praktika;User ID=sa;Password=sa";

        public Form2()
        {
            InitializeComponent();
        }

        public void qwerty (string query, string X)
        {
            string kas = X;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DataTable dt = new DataTable();
                    

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@startdate", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@enddate", dateTimePicker2.Value);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    connection.Close();

                    chart1.Series.Clear();
                    chart1.ChartAreas.Clear();

                    // Create a new chart area
                    ChartArea chartArea = new ChartArea();
                    chart1.ChartAreas.Add(chartArea);

                    // Set titles for the axes
                    chartArea.AxisX.Title = kas;
                    chartArea.AxisY.Title = "Kaina";

                    // Create a dictionary to hold series for each Saltinis
                    Dictionary<string, Series> seriesDict = new Dictionary<string, Series>();

                    foreach (DataRow row in dt.Rows)
                    {
                        string saltinis = row[kas].ToString();
                        decimal kaina = Convert.ToDecimal(row["Suma"]);

                        // If the series for this Saltinis doesn't exist, create it
                        if (!seriesDict.ContainsKey(saltinis))
                        {
                            Series series = new Series(saltinis)
                            {
                                ChartType = SeriesChartType.Column // You can change the chart type as needed
                            };
                            seriesDict[saltinis] = series;
                            chart1.Series.Add(series);
                        }

                        // Add the data point to the correct series
                        seriesDict[saltinis].Points.AddY(kaina);
                    }

                    chart1.Titles.Clear();
                    chart1.Titles.Add("Kaina per " + kas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Saltinis.Saltinis, SUM(Pinigai.Kaina) AS Suma
                 FROM Pinigai
                 INNER JOIN Saltinis ON Pinigai.SaltinisID = Saltinis.ID
                 WHERE Data BETWEEN @startdate AND @enddate GROUP BY Saltinis.Saltinis ";
            string X = "Saltinis";
            qwerty(query, X);
        }




        private void button3_Click(object sender, EventArgs e)
        {
            string query = @"SELECT Srautas.Srautas, SUM(Pinigai.Kaina) AS Suma 
                                    FROM Pinigai 
                                    INNER JOIN Srautas ON Pinigai.SrautoID = Srautas.ID 
                                    WHERE Data BETWEEN @startdate AND @enddate GROUP BY Srautas.Srautas";
            string X = "Srautas";
            qwerty(query, X);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kur saugoti
            string filePath = "C:\\Users\\15666\\C#\\demo.pdf";

            try
            {
                // Gauti duomenis
                DataTable dt = new DataTable();
                string queryString = @"SELECT Pinigai.ID, Data, Kaina, Srautas, Tipas, Saltinis, Komentaras 
                               FROM Pinigai 
                               INNER JOIN Saltinis ON Pinigai.SaltinisID = Saltinis.ID 
                               INNER JOIN Srautas ON Pinigai.SrautoID = Srautas.ID 
                               INNER JOIN Tipas ON Srautas.TipasID = Tipas.ID 
                               WHERE Data BETWEEN @startdate AND @enddate";
                using (SqlConnection sql = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, sql);
                    command.Parameters.AddWithValue("@startdate", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@enddate", dateTimePicker2.Value);
                    sql.Open();
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    da.Fill(dt);
                    sql.Close();
                }


                PdfWriter writer = new PdfWriter(filePath);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                /////////////////////////RASIMAS//////////////////////////
                Paragraph header = new Paragraph("Finansinių ataskaitų lentele").SetFontSize(20);
                Paragraph subheader = new Paragraph("-----").SetFontSize(15).SetTextAlignment(TextAlignment.CENTER);

                document.Add(header);
                document.Add(subheader);

                // Create a PDF table and populate it with the data from the DataTable
                Table pdfTable = new Table(dt.Columns.Count);
                foreach (DataColumn column in dt.Columns)
                {
                    pdfTable.AddHeaderCell(new Cell().Add(new Paragraph(column.ColumnName).SetBold()));
                }
                foreach (DataRow row in dt.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        pdfTable.AddCell(new Cell().Add(new Paragraph(item.ToString())));
                    }
                }
                document.Add(pdfTable);

                // Close the document
                document.Close();

                MessageBox.Show("PDF dokumentas sukurtas");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klaida: " + ex.Message);
            }
        }





        ////////////////////// KODO PABAIGA ////////////////////////////
    }
}
