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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace MovieRentalSystem
{
    public partial class ReportScreen : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public ReportScreen()
        {
            InitializeComponent();

            //string connectionString = "Server = DESKTOP-67E72SS; Database = Movie Rental System; Trusted_Connection = yes;";
            string connectionString = "Data Source=DESKTOP-67E72SS;Initial Catalog=\"Movie Rental System\";User ID=sa;Password=admin";
            SqlConnection myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();    // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;    // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FetchAvailable_Click(object sender, EventArgs e)
        {
            myCommand.CommandText = "SELECT M.MovieName, M.MovieType FROM Movie M WHERE M.MovieType = " + AvailableMovieType.Text + " AND M.MovieID NOT IN( SELECT RR.MovieID FROM RentalRecord RR WHERE " + DateTime.Now + " between RR.CheckoutTime AND RR.ReturnTime)";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                // Fill in table with results
                SalesQueryResult.Rows.Clear();
                while (myReader.Read())
                {
                    SalesQueryResult.Rows.Add(myReader["MovieName"].ToString(), myReader["MovieType"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void button_fetch_Sales(object sender, EventArgs e)
        {
            // send result message to the user
            // MUST CHECK TYPES FOR DATEFROM AND DATETO
            //string mes = "We made: $" + FetchSales.Text + " between " + DateFrom.Text + " and " + DateTo.Text;
            //MessageBox.Show(mes);

            myCommand.CommandText = "SELECT Movie.MovieType, sum(Movie.Fee) FROM RentalRecord, Movie WHERE RentalRecord.MovieID = Movie.MovieID AND RentalRecord.CheckoutTime between " + DateFrom.Text + " and " + DateTo.Text + " GROUP BY Movie.MovieType";

            try
            {
                MessageBox.Show(myCommand.CommandText);
                myReader = myCommand.ExecuteReader();

                // Fill in table with results
                SalesQueryResult.Rows.Clear();
                while (myReader.Read())
                {
                    SalesQueryResult.Rows.Add(myReader["MovieType"].ToString(), myReader["Sales"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString(), "Error");
            }
        }

        private void FetchStatsReport_Click(object sender, EventArgs e)
        {

        }

        private void ActorName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void SalesQueryResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
