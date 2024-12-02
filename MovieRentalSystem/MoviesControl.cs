using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class MoviesControl : UserControl
    {
        private string connectionString = "Data Source=LAPTOP-DTDFVPFO\\MSSQLSERVER03;Initial Catalog=\"Movie Rental System\";Integrated Security=True";

        public MoviesControl()
        {
            InitializeComponent();
            LoadMovies();
        }

        // Load all movies into the DataGridView
        private void LoadMovies()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Movie";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvMovies.DataSource = table; // Bind data to the DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading movies: " + ex.Message);
            }
        }

        // Add a new movie
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string movieName = txtMovieName.Text.Trim();
            string movieType = txtMovieType.Text.Trim();
            if (!decimal.TryParse(txtFee.Text.Trim(), out decimal distributionFee))
            {
                MessageBox.Show("Please enter a valid fee.");
                return;
            }

            if (!int.TryParse(txtNumOfCopy.Text.Trim(), out int numberOfCopies))
            {
                MessageBox.Show("Please enter a valid number of copies.");
                return;
            }
;

            // Validate inputs
            if (string.IsNullOrEmpty(movieName) || string.IsNullOrEmpty(movieType))
            {
                MessageBox.Show("Movie Name and Type are required.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Movie (MovieID, MovieName, MovieType, DistributionFee, NumberOfCopies) " +
               "VALUES (NEXT VALUE FOR Movie_MovieID_Seq, @MovieName, @MovieType, @DistributionFee, @NumberOfCopies)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieName", movieName);
                cmd.Parameters.AddWithValue("@MovieType", movieType);
                cmd.Parameters.AddWithValue("@DistributionFee", distributionFee);
                cmd.Parameters.AddWithValue("@NumberOfCopies", numberOfCopies);


                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie added successfully!");
                    LoadMovies(); // Refresh the DataGridView
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Search for movies
        private void btnSearchMovie_Click(object sender, EventArgs e)
        {
            string movieName = txtMovieName.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Movie WHERE MovieName LIKE @MovieName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieName", "%" + movieName + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvMovies.DataSource = table;
            }
        }


        // Update selected movie
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie to update.");
                return;
            }

            int movieID = (int)dgvMovies.SelectedRows[0].Cells["MovieID"].Value;
            string movieName = txtMovieName.Text.Trim();
            string movieType = txtMovieType.Text.Trim();
            if (!decimal.TryParse(txtFee.Text.Trim(), out decimal distributionFee))
            {
                MessageBox.Show("Please enter a valid fee.");
                return;
            }

            if (!int.TryParse(txtNumOfCopy.Text.Trim(), out int numberOfCopies))
            {
                MessageBox.Show("Please enter a valid number of copies.");
                return;
            }


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Movie SET MovieName = @MovieName, MovieType = @MovieType, DistributionFee = @DistributionFee, NumberOfCopies = @NumberOfCopies WHERE MovieID = @MovieID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieName", movieName);
                cmd.Parameters.AddWithValue("@MovieType", movieType);
                cmd.Parameters.AddWithValue("@DistributionFee", distributionFee);
                cmd.Parameters.AddWithValue("@NumberOfCopies", numberOfCopies);
                cmd.Parameters.AddWithValue("@MovieID", movieID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie updated successfully!");
                    LoadMovies(); // Refresh the DataGridView
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Delete selected movie
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a movie to delete.");
                return;
            }

            int movieID = (int)dgvMovies.SelectedRows[0].Cells["MovieID"].Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Movie WHERE MovieID = @MovieID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieID", movieID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Movie deleted successfully!");
                    LoadMovies();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        // Validate input fields
        private bool ValidateInputs(out string movieName, out string movieType, out decimal fee, out int numOfCopy)
        {
            movieName = txtMovieName.Text.Trim();
            movieType = txtMovieType.Text.Trim();
            fee = 0;
            numOfCopy = 0;

            if (string.IsNullOrEmpty(movieName) || string.IsNullOrEmpty(movieType))
            {
                MessageBox.Show("Movie Name and Type are required.");
                return false;
            }

            if (!decimal.TryParse(txtFee.Text.Trim(), out fee))
            {
                MessageBox.Show("Invalid Fee value.");
                return false;
            }

            if (!int.TryParse(txtNumOfCopy.Text.Trim(), out numOfCopy))
            {
                MessageBox.Show("Invalid Number of Copies.");
                return false;
            }

            return true;
        }

        // Clear input fields
        private void ClearInputs()
        {
            txtMovieName.Clear();
            txtMovieType.Clear();
            txtFee.Clear();
            txtNumOfCopy.Clear();
        }
    }
}
