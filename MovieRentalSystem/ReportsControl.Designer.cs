namespace MovieRentalSystem
{
    partial class ReportScreen
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
            components = new System.ComponentModel.Container();
            ReportTab = new TabControl();
            tabPage1 = new TabPage();
            SalesQueryResult = new DataGridView();
            FetchSales = new Button();
            DateTo = new DateTimePicker();
            DateFrom = new DateTimePicker();
            EndDatePrompt = new Label();
            StartDatePrompt = new Label();
            tabPage2 = new TabPage();
            FetchAvailable = new Button();
            AvailableMoviesPrompt = new TextBox();
            AvailableMovieType = new ComboBox();
            tabPage3 = new TabPage();
            TopNum = new TextBox();
            MostPopularMoviesPrompt = new TextBox();
            FetchPopularMovies = new Button();
            tabPage4 = new TabPage();
            FetchRentalReport = new Button();
            RentalMovieType = new ComboBox();
            RentalReportPrompt = new TextBox();
            tabPage5 = new TabPage();
            ChooseActorPrompt = new TextBox();
            ActorName = new ComboBox();
            FetchStatsReport = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ReportTab.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SalesQueryResult).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // ReportTab
            // 
            ReportTab.Controls.Add(tabPage1);
            ReportTab.Controls.Add(tabPage2);
            ReportTab.Controls.Add(tabPage3);
            ReportTab.Controls.Add(tabPage4);
            ReportTab.Controls.Add(tabPage5);
            ReportTab.Location = new Point(0, 0);
            ReportTab.Name = "ReportTab";
            ReportTab.SelectedIndex = 0;
            ReportTab.Size = new Size(800, 451);
            ReportTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(SalesQueryResult);
            tabPage1.Controls.Add(FetchSales);
            tabPage1.Controls.Add(DateTo);
            tabPage1.Controls.Add(DateFrom);
            tabPage1.Controls.Add(EndDatePrompt);
            tabPage1.Controls.Add(StartDatePrompt);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sales Report";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // SalesQueryResult
            // 
            SalesQueryResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SalesQueryResult.Location = new Point(83, 143);
            SalesQueryResult.Name = "SalesQueryResult";
            SalesQueryResult.Size = new Size(240, 150);
            SalesQueryResult.TabIndex = 5;
            SalesQueryResult.CellContentClick += SalesQueryResult_CellContentClick;
            // 
            // FetchSales
            // 
            FetchSales.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FetchSales.Location = new Point(568, 74);
            FetchSales.Name = "FetchSales";
            FetchSales.Size = new Size(135, 36);
            FetchSales.TabIndex = 4;
            FetchSales.Text = "Fetch Sales";
            FetchSales.UseVisualStyleBackColor = true;
            FetchSales.Click += button_fetch_Sales;
            // 
            // DateTo
            // 
            DateTo.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTo.Location = new Point(245, 76);
            DateTo.Name = "DateTo";
            DateTo.Size = new Size(269, 29);
            DateTo.TabIndex = 3;
            // 
            // DateFrom
            // 
            DateFrom.CalendarFont = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateFrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateFrom.Location = new Point(245, 26);
            DateFrom.Name = "DateFrom";
            DateFrom.Size = new Size(269, 29);
            DateFrom.TabIndex = 2;
            DateFrom.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // EndDatePrompt
            // 
            EndDatePrompt.AutoSize = true;
            EndDatePrompt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EndDatePrompt.Location = new Point(69, 84);
            EndDatePrompt.Name = "EndDatePrompt";
            EndDatePrompt.Size = new Size(116, 19);
            EndDatePrompt.TabIndex = 1;
            EndDatePrompt.Text = "Enter end date: ";
            EndDatePrompt.Click += label2_Click;
            // 
            // StartDatePrompt
            // 
            StartDatePrompt.AutoSize = true;
            StartDatePrompt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartDatePrompt.Location = new Point(69, 34);
            StartDatePrompt.Name = "StartDatePrompt";
            StartDatePrompt.Size = new Size(123, 19);
            StartDatePrompt.TabIndex = 0;
            StartDatePrompt.Text = "Enter start date: ";
            StartDatePrompt.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(FetchAvailable);
            tabPage2.Controls.Add(AvailableMoviesPrompt);
            tabPage2.Controls.Add(AvailableMovieType);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Available Movies";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FetchAvailable
            // 
            FetchAvailable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FetchAvailable.Location = new Point(537, 31);
            FetchAvailable.Name = "FetchAvailable";
            FetchAvailable.Size = new Size(211, 33);
            FetchAvailable.TabIndex = 2;
            FetchAvailable.Text = "Fetch Available Movies";
            FetchAvailable.UseVisualStyleBackColor = true;
            FetchAvailable.Click += FetchAvailable_Click;
            // 
            // AvailableMoviesPrompt
            // 
            AvailableMoviesPrompt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AvailableMoviesPrompt.Location = new Point(49, 34);
            AvailableMoviesPrompt.Name = "AvailableMoviesPrompt";
            AvailableMoviesPrompt.Size = new Size(166, 26);
            AvailableMoviesPrompt.TabIndex = 1;
            AvailableMoviesPrompt.Text = "Choose Movie Type: ";
            // 
            // AvailableMovieType
            // 
            AvailableMovieType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AvailableMovieType.FormattingEnabled = true;
            AvailableMovieType.Items.AddRange(new object[] { "<LOAD FROM DATABASE>", "Horror", "Thriller", "Suspence", "Comedy", "Drama", "Action", "Documentary", "... etc." });
            AvailableMovieType.Location = new Point(256, 34);
            AvailableMovieType.Name = "AvailableMovieType";
            AvailableMovieType.Size = new Size(241, 29);
            AvailableMovieType.TabIndex = 0;
            AvailableMovieType.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(TopNum);
            tabPage3.Controls.Add(MostPopularMoviesPrompt);
            tabPage3.Controls.Add(FetchPopularMovies);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 423);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Most Popular Movies";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // TopNum
            // 
            TopNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TopNum.Location = new Point(308, 27);
            TopNum.Name = "TopNum";
            TopNum.Size = new Size(100, 29);
            TopNum.TabIndex = 2;
            // 
            // MostPopularMoviesPrompt
            // 
            MostPopularMoviesPrompt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MostPopularMoviesPrompt.Location = new Point(53, 27);
            MostPopularMoviesPrompt.Name = "MostPopularMoviesPrompt";
            MostPopularMoviesPrompt.Size = new Size(214, 26);
            MostPopularMoviesPrompt.TabIndex = 1;
            MostPopularMoviesPrompt.Text = "Top _ Most Popular Movies";
            // 
            // FetchPopularMovies
            // 
            FetchPopularMovies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FetchPopularMovies.Location = new Point(449, 25);
            FetchPopularMovies.Name = "FetchPopularMovies";
            FetchPopularMovies.Size = new Size(290, 31);
            FetchPopularMovies.TabIndex = 0;
            FetchPopularMovies.Text = "Fetch List of Most Popular Movies";
            FetchPopularMovies.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(FetchRentalReport);
            tabPage4.Controls.Add(RentalMovieType);
            tabPage4.Controls.Add(RentalReportPrompt);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(792, 423);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Rental Report";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // FetchRentalReport
            // 
            FetchRentalReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FetchRentalReport.Location = new Point(534, 44);
            FetchRentalReport.Name = "FetchRentalReport";
            FetchRentalReport.Size = new Size(186, 32);
            FetchRentalReport.TabIndex = 2;
            FetchRentalReport.Text = "Fetch Rental Report";
            FetchRentalReport.UseVisualStyleBackColor = true;
            // 
            // RentalMovieType
            // 
            RentalMovieType.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RentalMovieType.FormattingEnabled = true;
            RentalMovieType.Items.AddRange(new object[] { "<LOAD FROM DATABASE>", "Horror", "Thriller", "Suspence", "Comedy", "Drama", "Action", "Documentary", "... etc." });
            RentalMovieType.Location = new Point(286, 47);
            RentalMovieType.Name = "RentalMovieType";
            RentalMovieType.Size = new Size(186, 29);
            RentalMovieType.TabIndex = 1;
            // 
            // RentalReportPrompt
            // 
            RentalReportPrompt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RentalReportPrompt.Location = new Point(53, 47);
            RentalReportPrompt.Name = "RentalReportPrompt";
            RentalReportPrompt.Size = new Size(186, 26);
            RentalReportPrompt.TabIndex = 0;
            RentalReportPrompt.Text = "Choose Movie Type";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(ChooseActorPrompt);
            tabPage5.Controls.Add(ActorName);
            tabPage5.Controls.Add(FetchStatsReport);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(792, 423);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Statistics Report";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // ChooseActorPrompt
            // 
            ChooseActorPrompt.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChooseActorPrompt.Location = new Point(41, 33);
            ChooseActorPrompt.Name = "ChooseActorPrompt";
            ChooseActorPrompt.Size = new Size(381, 26);
            ChooseActorPrompt.TabIndex = 2;
            ChooseActorPrompt.Text = "Select actor to search their popularity in rented movies: ";
            // 
            // ActorName
            // 
            ActorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActorName.FormattingEnabled = true;
            ActorName.Items.AddRange(new object[] { "<MUST BE COLLECTED FROM THE DATABASE>", "actor1", "actor2", "actor3" });
            ActorName.Location = new Point(484, 31);
            ActorName.Name = "ActorName";
            ActorName.Size = new Size(250, 29);
            ActorName.TabIndex = 1;
            ActorName.SelectedIndexChanged += ActorName_SelectedIndexChanged;
            // 
            // FetchStatsReport
            // 
            FetchStatsReport.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FetchStatsReport.Location = new Point(41, 83);
            FetchStatsReport.Name = "FetchStatsReport";
            FetchStatsReport.Size = new Size(211, 28);
            FetchStatsReport.TabIndex = 0;
            FetchStatsReport.Text = "Fetch Statistics Report";
            FetchStatsReport.UseVisualStyleBackColor = true;
            FetchStatsReport.Click += FetchStatsReport_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // ReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReportTab);
            Name = "ReportScreen";
            Text = "ReportScreen";
            ReportTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SalesQueryResult).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl ReportTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label StartDatePrompt;
        private Label EndDatePrompt;
        private DateTimePicker DateFrom;
        private DateTimePicker DateTo;
        private TextBox AvailableMoviesPrompt;
        private ComboBox AvailableMovieType;
        private Button FetchAvailable;
        private Button FetchSales;
        private TextBox MostPopularMoviesPrompt;
        private Button FetchPopularMovies;
        private TextBox RentalReportPrompt;
        private TextBox TopNum;
        private Button FetchRentalReport;
        private ComboBox RentalMovieType;
        private Button FetchStatsReport;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox ActorName;
        private TextBox ChooseActorPrompt;
        private DataGridView SalesQueryResult;
    }
}
