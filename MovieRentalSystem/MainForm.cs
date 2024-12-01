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
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LoadScreen(UserControl screen)
        {
            panelMainContent.Controls.Clear(); // Clear existing controls
            screen.Dock = DockStyle.Fill; // Make the UserControl fill the panel
            panelMainContent.Controls.Add(screen); // Add the new UserControl
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            LoadScreen(new CustomerControl());
        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            LoadScreen(new MoviesControl());
        }

        private void btnRentals_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            LoadScreen(new RentalsControl());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            HighlightActiveButton((Button)sender);
            LoadScreen(new ReportsControl());
        }
        private void HighlightActiveButton(Button activeButton)
        {
            foreach (Control control in panelSidebar.Controls)
            {
                if (control is Button)
                {
                    control.BackColor = SystemColors.Control; // Default color
                }
            }
            activeButton.BackColor = Color.LightBlue; // Highlighted color
        }
        
    }
}
