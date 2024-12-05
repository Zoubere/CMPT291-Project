namespace MovieRentalSystem
{
    partial class MoviesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMovieType = new TextBox();
            txtFee = new TextBox();
            txtNumOfCopy = new TextBox();
            txtMovieName = new TextBox();
            btnAddMovie = new Button();
            btnSearchMovie = new Button();
            btnUpdateMovie = new Button();
            btnDeleteMovie = new Button();
            dgvMovies = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            SuspendLayout();
            // 
            // txtMovieType
            // 
            txtMovieType.Location = new Point(454, 131);
            txtMovieType.Name = "txtMovieType";
            txtMovieType.Size = new Size(125, 27);
            txtMovieType.TabIndex = 0;
            // 
            // txtFee
            // 
            txtFee.Location = new Point(454, 194);
            txtFee.Name = "txtFee";
            txtFee.Size = new Size(125, 27);
            txtFee.TabIndex = 1;
            // 
            // txtNumOfCopy
            // 
            txtNumOfCopy.Location = new Point(454, 260);
            txtNumOfCopy.Name = "txtNumOfCopy";
            txtNumOfCopy.Size = new Size(125, 27);
            txtNumOfCopy.TabIndex = 2;
            // 
            // txtMovieName
            // 
            txtMovieName.Location = new Point(454, 65);
            txtMovieName.Name = "txtMovieName";
            txtMovieName.Size = new Size(125, 27);
            txtMovieName.TabIndex = 3;
            // 
            // btnAddMovie
            // 
            btnAddMovie.Location = new Point(628, 65);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(111, 29);
            btnAddMovie.TabIndex = 4;
            btnAddMovie.Text = "Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnSearchMovie
            // 
            btnSearchMovie.Location = new Point(628, 122);
            btnSearchMovie.Name = "btnSearchMovie";
            btnSearchMovie.Size = new Size(108, 29);
            btnSearchMovie.TabIndex = 5;
            btnSearchMovie.Text = "Search Movie";
            btnSearchMovie.UseVisualStyleBackColor = true;
            btnSearchMovie.Click += btnSearchMovie_Click;
            // 
            // btnUpdateMovie
            // 
            btnUpdateMovie.Location = new Point(624, 194);
            btnUpdateMovie.Name = "btnUpdateMovie";
            btnUpdateMovie.Size = new Size(112, 29);
            btnUpdateMovie.TabIndex = 6;
            btnUpdateMovie.Text = "Update Movie";
            btnUpdateMovie.UseVisualStyleBackColor = true;
            btnUpdateMovie.Click += btnUpdateMovie_Click;
            // 
            // btnDeleteMovie
            // 
            btnDeleteMovie.Location = new Point(624, 260);
            btnDeleteMovie.Name = "btnDeleteMovie";
            btnDeleteMovie.Size = new Size(108, 29);
            btnDeleteMovie.TabIndex = 7;
            btnDeleteMovie.Text = "Delete Movie";
            btnDeleteMovie.UseVisualStyleBackColor = true;
            btnDeleteMovie.Click += btnDeleteMovie_Click;
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(249, 322);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 51;
            dgvMovies.Size = new Size(415, 213);
            dgvMovies.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 72);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 9;
            label1.Text = "Enter a Movie Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 138);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 10;
            label2.Text = "Enter a Movie Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 203);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 12;
            label3.Text = "Enter the Movie Fee:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(153, 267);
            label4.Name = "label4";
            label4.Size = new Size(195, 20);
            label4.TabIndex = 14;
            label4.Text = "Enter the number of Movies:";
            // 
            // MoviesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMovies);
            Controls.Add(btnDeleteMovie);
            Controls.Add(btnUpdateMovie);
            Controls.Add(btnSearchMovie);
            Controls.Add(btnAddMovie);
            Controls.Add(txtMovieName);
            Controls.Add(txtNumOfCopy);
            Controls.Add(txtFee);
            Controls.Add(txtMovieType);
            Name = "MoviesControl";
            Size = new Size(912, 552);
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMovieType;
        private TextBox txtFee;
        private TextBox txtNumOfCopy;
        private TextBox txtMovieName;
        private Button btnAddMovie;
        private Button btnSearchMovie;
        private Button btnUpdateMovie;
        private Button btnDeleteMovie;
        private DataGridView dgvMovies;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
