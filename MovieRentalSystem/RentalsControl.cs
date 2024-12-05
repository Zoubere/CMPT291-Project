using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class RentalsControl : UserControl
    {
        private string connectionString = "Data Source=LAPTOP-DTDFVPFO\\MSSQLSERVER03;Initial Catalog=\"Movie Rental System\";Integrated Security=True";

        public RentalsControl()
        {
            InitializeComponent();
            LoadRentals();
            LoadEmployees();
            LoadCustomers();
            LoadMovies();
        }

        private void LoadRentals()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {      
                conn.Open();
                string query = @"
                    SELECT 
                        record.RentalRecordID,
                        e.FirstName + ' ' + e.LastName AS EmployeeName,
                        c.FirstName + ' ' + c.LastName AS CustomerName,
                        m.MovieName,
                        record.CheckoutTime,
                        record.ReturnTime
                    FROM RentalRecord record
                    INNER JOIN Employee e ON record.EmployeeID = e.EmployeeID
                    INNER JOIN Customer c ON record.CustomerID = c.CustomerID
                    INNER JOIN Movie m ON record.MovieID = m.MovieID";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvRentals.DataSource = table;

                    dgvRentals.Columns["RentalRecordID"].HeaderText = "Rental Record ID";
                    dgvRentals.Columns["EmployeeName"].HeaderText = "Employee Name";
                    dgvRentals.Columns["CustomerName"].HeaderText = "Customer Name";
                    dgvRentals.Columns["MovieName"].HeaderText = "Movie Name";
                    dgvRentals.Columns["CheckoutTime"].HeaderText = "Checkout Time";
                    dgvRentals.Columns["ReturnTime"].HeaderText = "Return Time";
            }
        }

        private void LoadEmployees()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT EmployeeID, FirstName + ' ' + LastName AS FullName FROM Employee";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                cmbEmployee.DataSource = table;
                cmbEmployee.DisplayMember = "FullName"; 
                cmbEmployee.ValueMember = "EmployeeID"; 
            }
        }


        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
            conn.Open();
            string query = "SELECT CustomerID, FirstName + ' ' + LastName AS FullName FROM Customer";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            cmbCustomer.DataSource = table;
            cmbCustomer.DisplayMember = "FullName"; 
            cmbCustomer.ValueMember = "CustomerID"; 
            }
        }

        private void LoadMovies()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
            string query = "SELECT MovieID, MovieName FROM Movie";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);

            cmbMovie.DataSource = table;
            cmbMovie.DisplayMember = "MovieName"; 
            cmbMovie.ValueMember = "MovieID";    
            }
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {

            // Get the input values
            int employeeID = cmbEmployee.SelectedValue as int? ?? 0;
            int customerID = cmbCustomer.SelectedValue as int? ?? 0;
            int movieID = cmbMovie.SelectedValue as int? ?? 0;
            DateTime ReturnTime = txtReturnTime.Value;
            int MovieRate = string.IsNullOrEmpty(txtMovieRate.Text) ? 0 : int.Parse(txtMovieRate.Text);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                try
                {  
                    // Insert Into Rental Record
                    string insert_query = "INSERT INTO RentalRecord (EmployeeID, CustomerID, MovieID, ReturnTime, MovieRate) " +
                                "VALUES (@EmployeeID, @CustomerID, @MovieID, @ReturnTime, @MovieRate)";
                    SqlCommand insert_cmd = new SqlCommand(insert_query, conn);
                    insert_cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    insert_cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    insert_cmd.Parameters.AddWithValue("@MovieID", movieID);
                    insert_cmd.Parameters.AddWithValue("@ReturnTime", ReturnTime);
                    insert_cmd.Parameters.AddWithValue("@MovieRate", MovieRate);
                    insert_cmd.ExecuteNonQuery();

                    // Update Count of Movie
                    string update_query = "UPDATE Movie " +
                                        "SET NumberOfCopies = NumberOfCopies - 1 " +
                                        "WHERE MovieID = @MovieID AND NumberOfCopies > 0";
                    SqlCommand update_cmd = new SqlCommand(update_query, conn);
                    update_cmd.Parameters.AddWithValue("@MovieID", movieID);
                    int rowsAffected = update_cmd.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        MessageBox.Show("Unable to decrement NumOfCopy. No copies available.");
                    }
                    else
                    {
                        MessageBox.Show("Rental added successfully, and movie stock updated.");
                        LoadRentals(); 
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void btnSearchRental_Click(object sender, EventArgs e)
        {
        }

        private void btnUpdateRental_Click(object sender, EventArgs e)
        {
        }

        private void btnDeleteRental_Click(object sender, EventArgs e)
        {
        }
    }
}
