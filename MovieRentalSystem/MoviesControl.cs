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
            LoadMoviesDataGrid();  // This method loads the movie data into the DataGridView
            LoadMovieComboBox();   // This method loads movie options into ComboBox
            LoadActors();          // This method loads actors into ComboBox
        }

        // Load movie data into the DataGridView
        private void LoadMoviesDataGrid()
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

                    dgvMovies.DataSource = table;

                    dgvMovies.Columns["MovieID"].HeaderText = "Movie ID";
                    dgvMovies.Columns["MovieName"].HeaderText = "Movie Name";
                    dgvMovies.Columns["MovieType"].HeaderText = "Movie Type";
                    dgvMovies.Columns["DistributionFee"].HeaderText = "Fee";
                    dgvMovies.Columns["NumberOfCopies"].HeaderText = "Number Of Copies";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading movies: " + ex.Message);
            }
        }

        // Load movie options into ComboBox for selection
        private void LoadMovieComboBox()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT MovieID, MovieName FROM Movie";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbMovies.DataSource = table;
                cmbMovies.DisplayMember = "MovieName";  // Name to display
                cmbMovies.ValueMember = "MovieID";      // Value to use (MovieID)
            }
        }

        // Load Actors for ComboBox
        // Load Actors for ComboBox
        private void LoadActors()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ActorID, ActorName FROM Actor";  // Use ActorName instead of Name
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbActors.DataSource = table;
                cmbActors.DisplayMember = "ActorName";  // Use ActorName to display
                cmbActors.ValueMember = "ActorID";  // Value to use (ActorID)
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
                    LoadMoviesDataGrid();  // Refresh the DataGridView
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
                    LoadMoviesDataGrid();  // Refresh the DataGridView
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
                    LoadMoviesDataGrid();  // Refresh the DataGridView
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Assign actor to movie
        private void btnAssignActor_Click(object sender, EventArgs e)
        {
            int selectedMovieID = (int)cmbMovies.SelectedValue;
            int selectedActorID = (int)cmbActors.SelectedValue;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO ActorAppear (MovieID, ActorID) VALUES (@MovieID, @ActorID)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MovieID", selectedMovieID);
                cmd.Parameters.AddWithValue("@ActorID", selectedActorID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Actor assigned to movie successfully!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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
