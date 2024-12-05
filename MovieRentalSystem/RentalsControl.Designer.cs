namespace MovieRentalSystem
{
    partial class RentalsControl
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code


        private void InitializeComponent()
        {
            cmbEmployee = new ComboBox();
            cmbCustomer = new ComboBox();
            cmbMovie = new ComboBox();
            txtReturnTime = new DateTimePicker();
            txtMovieRate = new TextBox();
            btnAddRental = new Button();
            btnSearchRental = new Button();
            btnUpdateRental = new Button();
            btnDeleteRental = new Button();
            dgvRentals = new DataGridView();
            lblEmployee = new Label();
            lblCustomer = new Label();
            lblMovie = new Label();
            lblReturnTime = new Label();
            lblMovieRate = new Label();
            lblRentalID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRentals).BeginInit();
            SuspendLayout();
            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(300, 50);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(250, 28);
            cmbEmployee.TabIndex = 0;
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(300, 100);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(250, 28);
            cmbCustomer.TabIndex = 1;
            // 
            // cmbMovie
            // 
            cmbMovie.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new Point(300, 150);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new Size(250, 28);
            cmbMovie.TabIndex = 2;
            // 
            // txtReturnTime
            // 
            txtReturnTime.Location = new Point(300, 200);
            txtReturnTime.Name = "txtReturnTime";
            txtReturnTime.Size = new Size(250, 27);
            txtReturnTime.TabIndex = 3;
            // 
            // txtMovieRate
            // 
            txtMovieRate.Location = new Point(300, 250);
            txtMovieRate.Name = "txtMovieRate";
            txtMovieRate.Size = new Size(125, 27);
            txtMovieRate.TabIndex = 4;
            txtMovieRate.Text = "0";
            // 
            // btnAddRental
            // 
            btnAddRental.Location = new Point(600, 50);
            btnAddRental.Name = "btnAddRental";
            btnAddRental.Size = new Size(128, 29);
            btnAddRental.TabIndex = 5;
            btnAddRental.Text = "Add Rental";
            btnAddRental.UseVisualStyleBackColor = true;
            btnAddRental.Click += btnAddRental_Click;
            // 
            // btnSearchRental
            // 
            btnSearchRental.Location = new Point(600, 100);
            btnSearchRental.Name = "btnSearchRental";
            btnSearchRental.Size = new Size(128, 29);
            btnSearchRental.TabIndex = 6;
            btnSearchRental.Text = "Search Rental";
            btnSearchRental.UseVisualStyleBackColor = true;
            btnSearchRental.Click += btnSearchRental_Click;
            // 
            // btnUpdateRental
            // 
            btnUpdateRental.Location = new Point(600, 150);
            btnUpdateRental.Name = "btnUpdateRental";
            btnUpdateRental.Size = new Size(138, 29);
            btnUpdateRental.TabIndex = 7;
            btnUpdateRental.Text = "Update Rental";
            btnUpdateRental.UseVisualStyleBackColor = true;
            btnUpdateRental.Click += btnUpdateRental_Click;
            // 
            // btnDeleteRental
            // 
            btnDeleteRental.Location = new Point(600, 200);
            btnDeleteRental.Name = "btnDeleteRental";
            btnDeleteRental.Size = new Size(128, 29);
            btnDeleteRental.TabIndex = 8;
            btnDeleteRental.Text = "Delete Rental";
            btnDeleteRental.UseVisualStyleBackColor = true;
            btnDeleteRental.Click += btnDeleteRental_Click;
            // 
            // dgvRentals
            // 
            dgvRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentals.Location = new Point(239, 310);
            dgvRentals.Name = "dgvRentals";
            dgvRentals.RowHeadersWidth = 51;
            dgvRentals.Size = new Size(400, 300);
            dgvRentals.TabIndex = 9;
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new Point(80, 50);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(122, 20);
            lblEmployee.TabIndex = 0;
            lblEmployee.Text = "Select Employee:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(80, 100);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(119, 20);
            lblCustomer.TabIndex = 10;
            lblCustomer.Text = "Select Customer:";
            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.Location = new Point(80, 150);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new Size(97, 20);
            lblMovie.TabIndex = 11;
            lblMovie.Text = "Select Movie:";
            // 
            // lblReturnTime
            // 
            lblReturnTime.AutoSize = true;
            lblReturnTime.Location = new Point(80, 200);
            lblReturnTime.Name = "lblReturnTime";
            lblReturnTime.Size = new Size(129, 20);
            lblReturnTime.TabIndex = 12;
            lblReturnTime.Text = "Enter Return Date:";
            // 
            // lblMovieRate
            // 
            lblMovieRate.AutoSize = true;
            lblMovieRate.Location = new Point(80, 250);
            lblMovieRate.Name = "lblMovieRate";
            lblMovieRate.Size = new Size(83, 20);
            lblMovieRate.TabIndex = 13;
            lblMovieRate.Text = "MovieRate:";
            // 
            // lblRentalID
            // 
            lblRentalID.Location = new Point(0, 0);
            lblRentalID.Name = "lblRentalID";
            lblRentalID.Size = new Size(100, 23);
            lblRentalID.TabIndex = 0;
            // 
            // RentalsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblRentalID);
            Controls.Add(lblMovieRate);
            Controls.Add(lblReturnTime);
            Controls.Add(lblMovie);
            Controls.Add(lblCustomer);
            Controls.Add(lblEmployee);
            Controls.Add(dgvRentals);
            Controls.Add(btnDeleteRental);
            Controls.Add(btnUpdateRental);
            Controls.Add(btnSearchRental);
            Controls.Add(btnAddRental);
            Controls.Add(txtMovieRate);
            Controls.Add(txtReturnTime);
            Controls.Add(cmbMovie);
            Controls.Add(cmbCustomer);
            Controls.Add(cmbEmployee);
            Name = "RentalsControl";
            Size = new Size(926, 621);
            ((System.ComponentModel.ISupportInitialize)dgvRentals).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.DateTimePicker txtReturnTime;
        private System.Windows.Forms.TextBox txtMovieRate;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Button btnSearchRental;
        private System.Windows.Forms.Button btnUpdateRental;
        private System.Windows.Forms.Button btnDeleteRental;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblMovie;
        private System.Windows.Forms.Label lblReturnTime;
        private System.Windows.Forms.Label lblMovieRate;
        private System.Windows.Forms.Label lblRentalID;
        private System.Windows.Forms.Label lblEmployee;
    }
}
