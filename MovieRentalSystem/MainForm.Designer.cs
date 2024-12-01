namespace MovieRentalSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSidebar = new Panel();
            label1 = new Label();
            btnReports = new Button();
            btnCustomer = new Button();
            btnRentals = new Button();
            btnMovies = new Button();
            panelMainContent = new Panel();
            panelSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = SystemColors.ActiveBorder;
            panelSidebar.Controls.Add(label1);
            panelSidebar.Controls.Add(btnReports);
            panelSidebar.Controls.Add(btnCustomer);
            panelSidebar.Controls.Add(btnRentals);
            panelSidebar.Controls.Add(btnMovies);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(250, 450);
            panelSidebar.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(5, 10);
            label1.Name = "label1";
            label1.Size = new Size(244, 20);
            label1.TabIndex = 8;
            label1.Text = "Welcome to Movie Rental System";
            // 
            // btnReports
            // 
            btnReports.Location = new Point(50, 330);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(145, 29);
            btnReports.TabIndex = 9;
            btnReports.Text = "Generate Reports";
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(50, 77);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(145, 29);
            btnCustomer.TabIndex = 6;
            btnCustomer.Text = "Manage Customers";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnRentals
            // 
            btnRentals.Location = new Point(50, 245);
            btnRentals.Name = "btnRentals";
            btnRentals.Size = new Size(145, 29);
            btnRentals.TabIndex = 8;
            btnRentals.Text = "Manage Rentals";
            btnRentals.UseVisualStyleBackColor = true;
            btnRentals.Click += btnRentals_Click;
            // 
            // btnMovies
            // 
            btnMovies.Location = new Point(50, 158);
            btnMovies.Name = "btnMovies";
            btnMovies.Size = new Size(145, 29);
            btnMovies.TabIndex = 7;
            btnMovies.Text = "Manage Movies";
            btnMovies.UseVisualStyleBackColor = true;
            btnMovies.Click += btnMovies_Click;
            // 
            // panelMainContent
            // 
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(250, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(550, 450);
            panelMainContent.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMainContent);
            Controls.Add(panelSidebar);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSidebar;
        private Button btnReports;
        private Button btnCustomer;
        private Button btnRentals;
        private Button btnMovies;
        private Panel panelMainContent;
        private Label label1;
    }
}