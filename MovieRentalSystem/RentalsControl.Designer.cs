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
            cmbEmployee = new System.Windows.Forms.ComboBox();
            cmbCustomer = new System.Windows.Forms.ComboBox();
            cmbMovie = new System.Windows.Forms.ComboBox();
            txtReturnTime  = new System.Windows.Forms.DateTimePicker();
            txtMovieRate = new System.Windows.Forms.TextBox();
            btnAddRental = new System.Windows.Forms.Button();
            btnSearchRental = new System.Windows.Forms.Button();
            btnUpdateRental = new System.Windows.Forms.Button();
            btnDeleteRental = new System.Windows.Forms.Button();
            dgvRentals = new System.Windows.Forms.DataGridView();
            lblEmployee = new System.Windows.Forms.Label();
            lblCustomer = new System.Windows.Forms.Label();
            lblMovie = new System.Windows.Forms.Label();
            lblReturnTime = new System.Windows.Forms.Label();
            lblMovieRate = new System.Windows.Forms.Label();
            lblRentalID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(dgvRentals)).BeginInit();
            SuspendLayout();


            // 
            // cmbEmployee
            // 
            cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new System.Drawing.Point(300, 50);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new System.Drawing.Size(250, 28);
            cmbEmployee.TabIndex = 0;

          
            // 
            // cmbCustomer
            // 
            cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new System.Drawing.Point(300, 100);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new System.Drawing.Size(250, 28);
            cmbCustomer.TabIndex = 1;

            // 
            // cmbMovie
            // 
            cmbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMovie.FormattingEnabled = true;
            cmbMovie.Location = new System.Drawing.Point(300, 150);
            cmbMovie.Name = "cmbMovie";
            cmbMovie.Size = new System.Drawing.Size(250, 28);
            cmbMovie.TabIndex = 2;

            // 
            // txtReturnTime
            // 
            txtReturnTime.Location = new System.Drawing.Point(300, 200);
            txtReturnTime.Name = "txtReturnTime";
            txtReturnTime.Size = new System.Drawing.Size(250, 27);
            txtReturnTime.TabIndex = 3;

            // 
            // txtMovieRate
            // 
            txtMovieRate.Location = new System.Drawing.Point(300, 250);
            txtMovieRate.Name = "txtMovieRate";
            txtMovieRate.Size = new System.Drawing.Size(125, 27);
            txtMovieRate.TabIndex = 4;
            txtMovieRate.Text = "0"; // Default value

            // 
            // btnAddRental
            // 
            btnAddRental.Location = new System.Drawing.Point(600, 50);
            btnAddRental.Name = "btnAddRental";
            btnAddRental.Size = new System.Drawing.Size(128, 29);
            btnAddRental.TabIndex = 5;
            btnAddRental.Text = "Add Rental";
            btnAddRental.UseVisualStyleBackColor = true;
            btnAddRental.Click += new System.EventHandler(btnAddRental_Click);

            
            // btnSearchRental
            // 
            btnSearchRental.Location = new System.Drawing.Point(600, 100);
            btnSearchRental.Name = "btnSearchRental";
            btnSearchRental.Size = new System.Drawing.Size(128, 29);
            btnSearchRental.TabIndex = 6;
            btnSearchRental.Text = "Search Rental";
            btnSearchRental.UseVisualStyleBackColor = true;
            btnSearchRental.Click += new System.EventHandler(btnSearchRental_Click);

            // 
            // btnUpdateRental
            //
            btnUpdateRental.Location = new System.Drawing.Point(600, 150);
            btnUpdateRental.Name = "btnUpdateRental";
            btnUpdateRental.Size = new System.Drawing.Size(138, 29);
            btnUpdateRental.TabIndex = 7;
            btnUpdateRental.Text = "Update Rental";
            btnUpdateRental.UseVisualStyleBackColor = true;
            btnUpdateRental.Click += new System.EventHandler(btnUpdateRental_Click);

            // 
            // btnDeleteRental
            // 
            btnDeleteRental.Location = new System.Drawing.Point(600, 200);
            btnDeleteRental.Name = "btnDeleteRental";
            btnDeleteRental.Size = new System.Drawing.Size(128, 29);
            btnDeleteRental.TabIndex = 8;
            btnDeleteRental.Text = "Delete Rental";
            btnDeleteRental.UseVisualStyleBackColor = true;
            btnDeleteRental.Click += new System.EventHandler(btnDeleteRental_Click);
        

            // 
            // dgvRentals
            // 
            dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentals.Location = new System.Drawing.Point(250, 350);
            dgvRentals.Name = "dgvRentals";
            dgvRentals.RowHeadersWidth = 51;
            dgvRentals.Size = new System.Drawing.Size(400, 300);
            dgvRentals.TabIndex = 9;


            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Location = new System.Drawing.Point(80, 50);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new System.Drawing.Size(113, 20);
            lblEmployee.TabIndex = 0;
            lblEmployee.Text = "Select Employee:";


            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new System.Drawing.Point(80, 100);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new System.Drawing.Size(83, 20);
            lblCustomer.TabIndex = 10;
            lblCustomer.Text = "Select Customer:";

            // 
            // lblMovie
            // 
            lblMovie.AutoSize = true;
            lblMovie.Location = new System.Drawing.Point(80, 150);
            lblMovie.Name = "lblMovie";
            lblMovie.Size = new System.Drawing.Size(79, 20);
            lblMovie.TabIndex = 11;
            lblMovie.Text = "Select Movie:";

            // 
            // lblReturnTime
            // 
            lblReturnTime.AutoSize = true;
            lblReturnTime.Location = new System.Drawing.Point(80, 200);
            lblReturnTime.Name = "lblReturnTime ";
            lblReturnTime.Size = new System.Drawing.Size(90, 20);
            lblReturnTime.TabIndex = 12;
            lblReturnTime.Text = "Enter Return Date:";

            // 
            // lblMovieRate
            // 
            lblMovieRate.AutoSize = true;
            lblMovieRate.Location = new System.Drawing.Point(80, 250);
            lblMovieRate.Name = "lblMovieRate";
            lblMovieRate.Size = new System.Drawing.Size(57, 20);
            lblMovieRate.TabIndex = 13;
            lblMovieRate.Text = "MovieRate:";

            // 
            // RentalsControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            Size = new System.Drawing.Size(926, 565);
            ((System.ComponentModel.ISupportInitialize)(dgvRentals)).EndInit();
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
