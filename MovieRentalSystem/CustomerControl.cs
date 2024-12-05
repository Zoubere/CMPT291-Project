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

namespace MovieRentalSystem
{
    public partial class CustomerControl : UserControl
    {
        private string connectionString = "Data Source=LAPTOP-DTDFVPFO\\MSSQLSERVER03;Initial Catalog=\"Movie Rental System\";Integrated Security=True";
        public CustomerControl()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Customer";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvCustomers.DataSource = table;
            }
        }


        private void CustomerControl_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string ssn = txtSSN.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string province = txtProvince.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();
            string email = txtEmail.Text.Trim();
            string accountNum = txtAccountNum.Text.Trim();
            string creditCardNum = txtCreditCardNum.Text.Trim();
            string creditCardExp = txtCreditCardExp.Text.Trim();
            string creditCardCvv = txtCreditCardCvv.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(ssn) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(accountNum) || string.IsNullOrEmpty(creditCardNum) ||
                string.IsNullOrEmpty(creditCardExp) || string.IsNullOrEmpty(creditCardCvv))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Customer (SSN, LastName, FirstName, Address, City, Province, PostalCode, Email, AccountNum, CreditCardNum, CreditCardExp, CreditCardCvv) " +
                               "VALUES (@SSN, @LastName, @FirstName, @Address, @City, @Province, @PostalCode, @Email, @AccountNum, @CreditCardNum, @CreditCardExp, @CreditCardCvv)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SSN", ssn);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@AccountNum", accountNum);
                cmd.Parameters.AddWithValue("@CreditCardNum", creditCardNum);
                cmd.Parameters.AddWithValue("@CreditCardExp", creditCardExp);
                cmd.Parameters.AddWithValue("@CreditCardCvv", creditCardCvv);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully!");
                    LoadCustomers(); // Refresh the DataGridView
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string lastName = txtLastName.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Customer WHERE LastName LIKE @LastName";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@LastName", "%" + lastName + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvCustomers.DataSource = table; // Bind data to DataGridView
            }
        }


        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.");
                return;
            }

            int customerID = (int)dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value;

            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string province = txtProvince.Text.Trim();
            string postalCode = txtPostalCode.Text.Trim();
            string email = txtEmail.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Customer SET Address = @Address, City = @City, Province = @Province, PostalCode = @PostalCode, Email = @Email WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Address", address);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Province", province);
                cmd.Parameters.AddWithValue("@PostalCode", postalCode);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer updated successfully!");
                    LoadCustomers(); // Refresh the DataGridView
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.");
                return;
            }

            int customerID = (int)dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CustomerID", customerID);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer deleted successfully!");
                    LoadCustomers();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}