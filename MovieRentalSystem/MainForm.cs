using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRentalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCustomerScreen_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm(); // Create an instance of CustomerForm
            customerForm.Show();
        }

        private void btnMovieScreen_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm(); // Create an instance of MovieForm
            movieForm.Show();
        }

        private void btnRentalScreen_Click(object sender, EventArgs e)
        {
            RentalForm rentalForm = new RentalForm(); // Create an instance of RentalForm
            rentalForm.Show();
        }

        private void btnReportScreen_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(); // Create an instance of ReportForm
            reportForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
