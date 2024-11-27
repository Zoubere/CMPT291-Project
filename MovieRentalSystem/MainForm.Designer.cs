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
            label1 = new Label();
            btnCustomerScreen = new Button();
            btnMovieScreen = new Button();
            btnRentalScreen = new Button();
            btnReportScreen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 54);
            label1.Name = "label1";
            label1.Size = new Size(331, 28);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Movie Rental System";
            // 
            // btnCustomerScreen
            // 
            btnCustomerScreen.Location = new Point(304, 106);
            btnCustomerScreen.Name = "btnCustomerScreen";
            btnCustomerScreen.Size = new Size(145, 29);
            btnCustomerScreen.TabIndex = 1;
            btnCustomerScreen.Text = "Manage Customers";
            btnCustomerScreen.UseVisualStyleBackColor = true;
            btnCustomerScreen.Click += btnCustomerScreen_Click;
            // 
            // btnMovieScreen
            // 
            btnMovieScreen.Location = new Point(304, 141);
            btnMovieScreen.Name = "btnMovieScreen";
            btnMovieScreen.Size = new Size(145, 29);
            btnMovieScreen.TabIndex = 2;
            btnMovieScreen.Text = "Manage Movies";
            btnMovieScreen.UseVisualStyleBackColor = true;
            btnMovieScreen.Click += btnMovieScreen_Click;
            // 
            // btnRentalScreen
            // 
            btnRentalScreen.Location = new Point(304, 176);
            btnRentalScreen.Name = "btnRentalScreen";
            btnRentalScreen.Size = new Size(145, 29);
            btnRentalScreen.TabIndex = 3;
            btnRentalScreen.Text = "Manage Rentals";
            btnRentalScreen.UseVisualStyleBackColor = true;
            btnRentalScreen.Click += btnRentalScreen_Click;
            // 
            // btnReportScreen
            // 
            btnReportScreen.Location = new Point(304, 211);
            btnReportScreen.Name = "btnReportScreen";
            btnReportScreen.Size = new Size(145, 29);
            btnReportScreen.TabIndex = 4;
            btnReportScreen.Text = "Generate Report";
            btnReportScreen.UseVisualStyleBackColor = true;
            btnReportScreen.Click += btnReportScreen_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReportScreen);
            Controls.Add(btnRentalScreen);
            Controls.Add(btnMovieScreen);
            Controls.Add(btnCustomerScreen);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCustomerScreen;
        private Button btnMovieScreen;
        private Button btnRentalScreen;
        private Button btnReportScreen;
    }
}