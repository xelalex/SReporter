namespace SReporter
{
    partial class ReporterForm
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
            this.msReportsMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startReportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssReportStatus = new System.Windows.Forms.StatusStrip();
            this.tsslReportsStatusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDailyReports = new System.Windows.Forms.GroupBox();
            this.dgvReportsDashboard = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brochures = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Magazines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendReport = new System.Windows.Forms.Button();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.gbMonthlyReportStatus = new System.Windows.Forms.GroupBox();
            this.txtBibleStudies = new System.Windows.Forms.TextBox();
            this.txtReturnVisits = new System.Windows.Forms.TextBox();
            this.txtMagazines = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtBrochures = new System.Windows.Forms.TextBox();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.lblBibleStudies = new System.Windows.Forms.Label();
            this.lblReturnVisits = new System.Windows.Forms.Label();
            this.lblMagazines = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblBrochures = new System.Windows.Forms.Label();
            this.lblBook = new System.Windows.Forms.Label();
            this.gbCalendar = new System.Windows.Forms.GroupBox();
            this.gbMinutesRemainders = new System.Windows.Forms.GroupBox();
            this.txtNextMonthMinutes = new System.Windows.Forms.TextBox();
            this.txtPreviousMonthMinutes = new System.Windows.Forms.TextBox();
            this.lblNextMonth = new System.Windows.Forms.Label();
            this.lblPreviousMonth = new System.Windows.Forms.Label();
            this.msReportsMenu.SuspendLayout();
            this.ssReportStatus.SuspendLayout();
            this.gbDailyReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsDashboard)).BeginInit();
            this.gbMonthlyReportStatus.SuspendLayout();
            this.gbCalendar.SuspendLayout();
            this.gbMinutesRemainders.SuspendLayout();
            this.SuspendLayout();
            // 
            // msReportsMenu
            // 
            this.msReportsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.msReportsMenu.Location = new System.Drawing.Point(0, 0);
            this.msReportsMenu.Name = "msReportsMenu";
            this.msReportsMenu.Size = new System.Drawing.Size(822, 24);
            this.msReportsMenu.TabIndex = 1;
            this.msReportsMenu.Text = "Reports Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startReportingToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // startReportingToolStripMenuItem
            // 
            this.startReportingToolStripMenuItem.Name = "startReportingToolStripMenuItem";
            this.startReportingToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.startReportingToolStripMenuItem.Text = "Start Reporting";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // ssReportStatus
            // 
            this.ssReportStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslReportsStatusBar});
            this.ssReportStatus.Location = new System.Drawing.Point(0, 805);
            this.ssReportStatus.Name = "ssReportStatus";
            this.ssReportStatus.Size = new System.Drawing.Size(822, 22);
            this.ssReportStatus.TabIndex = 2;
            this.ssReportStatus.Text = "Ready";
            // 
            // tsslReportsStatusBar
            // 
            this.tsslReportsStatusBar.Name = "tsslReportsStatusBar";
            this.tsslReportsStatusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // gbDailyReports
            // 
            this.gbDailyReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDailyReports.Controls.Add(this.dgvReportsDashboard);
            this.gbDailyReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbDailyReports.Location = new System.Drawing.Point(12, 42);
            this.gbDailyReports.Name = "gbDailyReports";
            this.gbDailyReports.Size = new System.Drawing.Size(542, 742);
            this.gbDailyReports.TabIndex = 3;
            this.gbDailyReports.TabStop = false;
            this.gbDailyReports.Text = "Daily Reports";
            // 
            // dgvReportsDashboard
            // 
            this.dgvReportsDashboard.AllowUserToAddRows = false;
            this.dgvReportsDashboard.AllowUserToDeleteRows = false;
            this.dgvReportsDashboard.AllowUserToResizeRows = false;
            this.dgvReportsDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReportsDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportsDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Books,
            this.Brochures,
            this.Magazines,
            this.ReturnVisits});
            this.dgvReportsDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReportsDashboard.Location = new System.Drawing.Point(3, 16);
            this.dgvReportsDashboard.Margin = new System.Windows.Forms.Padding(5);
            this.dgvReportsDashboard.Name = "dgvReportsDashboard";
            this.dgvReportsDashboard.RowHeadersVisible = false;
            this.dgvReportsDashboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReportsDashboard.Size = new System.Drawing.Size(536, 723);
            this.dgvReportsDashboard.TabIndex = 1;
            this.dgvReportsDashboard.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReportsDashboard_CellEndEdit);
            this.dgvReportsDashboard.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReportsDashboard_CellFormatting);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time Spent";
            this.Time.Name = "Time";
            // 
            // Books
            // 
            this.Books.HeaderText = "Books";
            this.Books.Name = "Books";
            // 
            // Brochures
            // 
            this.Brochures.HeaderText = "Brochures";
            this.Brochures.Name = "Brochures";
            // 
            // Magazines
            // 
            this.Magazines.HeaderText = "Magazines";
            this.Magazines.Name = "Magazines";
            // 
            // ReturnVisits
            // 
            this.ReturnVisits.HeaderText = "Return Visits";
            this.ReturnVisits.Name = "ReturnVisits";
            // 
            // btnSendReport
            // 
            this.btnSendReport.Location = new System.Drawing.Point(564, 754);
            this.btnSendReport.Name = "btnSendReport";
            this.btnSendReport.Size = new System.Drawing.Size(250, 27);
            this.btnSendReport.TabIndex = 4;
            this.btnSendReport.Text = "Send Monthly Report";
            this.btnSendReport.UseVisualStyleBackColor = true;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 16);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 6;
            // 
            // gbMonthlyReportStatus
            // 
            this.gbMonthlyReportStatus.Controls.Add(this.txtBibleStudies);
            this.gbMonthlyReportStatus.Controls.Add(this.txtReturnVisits);
            this.gbMonthlyReportStatus.Controls.Add(this.txtMagazines);
            this.gbMonthlyReportStatus.Controls.Add(this.txtHours);
            this.gbMonthlyReportStatus.Controls.Add(this.txtBrochures);
            this.gbMonthlyReportStatus.Controls.Add(this.txtBooks);
            this.gbMonthlyReportStatus.Controls.Add(this.lblBibleStudies);
            this.gbMonthlyReportStatus.Controls.Add(this.lblReturnVisits);
            this.gbMonthlyReportStatus.Controls.Add(this.lblMagazines);
            this.gbMonthlyReportStatus.Controls.Add(this.lblHours);
            this.gbMonthlyReportStatus.Controls.Add(this.lblBrochures);
            this.gbMonthlyReportStatus.Controls.Add(this.lblBook);
            this.gbMonthlyReportStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbMonthlyReportStatus.Location = new System.Drawing.Point(564, 247);
            this.gbMonthlyReportStatus.Name = "gbMonthlyReportStatus";
            this.gbMonthlyReportStatus.Size = new System.Drawing.Size(248, 259);
            this.gbMonthlyReportStatus.TabIndex = 7;
            this.gbMonthlyReportStatus.TabStop = false;
            this.gbMonthlyReportStatus.Text = "Monthly Report Status";
            // 
            // txtBibleStudies
            // 
            this.txtBibleStudies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBibleStudies.Location = new System.Drawing.Point(159, 198);
            this.txtBibleStudies.Name = "txtBibleStudies";
            this.txtBibleStudies.ReadOnly = true;
            this.txtBibleStudies.Size = new System.Drawing.Size(37, 13);
            this.txtBibleStudies.TabIndex = 6;
            // 
            // txtReturnVisits
            // 
            this.txtReturnVisits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReturnVisits.Location = new System.Drawing.Point(159, 166);
            this.txtReturnVisits.Name = "txtReturnVisits";
            this.txtReturnVisits.ReadOnly = true;
            this.txtReturnVisits.Size = new System.Drawing.Size(37, 13);
            this.txtReturnVisits.TabIndex = 6;
            // 
            // txtMagazines
            // 
            this.txtMagazines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMagazines.Location = new System.Drawing.Point(159, 134);
            this.txtMagazines.Name = "txtMagazines";
            this.txtMagazines.ReadOnly = true;
            this.txtMagazines.Size = new System.Drawing.Size(37, 13);
            this.txtMagazines.TabIndex = 6;
            // 
            // txtHours
            // 
            this.txtHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHours.Location = new System.Drawing.Point(159, 102);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(37, 13);
            this.txtHours.TabIndex = 6;
            // 
            // txtBrochures
            // 
            this.txtBrochures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrochures.Location = new System.Drawing.Point(159, 70);
            this.txtBrochures.Name = "txtBrochures";
            this.txtBrochures.ReadOnly = true;
            this.txtBrochures.Size = new System.Drawing.Size(37, 13);
            this.txtBrochures.TabIndex = 6;
            // 
            // txtBooks
            // 
            this.txtBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBooks.Location = new System.Drawing.Point(159, 38);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.ReadOnly = true;
            this.txtBooks.Size = new System.Drawing.Size(37, 13);
            this.txtBooks.TabIndex = 6;
            // 
            // lblBibleStudies
            // 
            this.lblBibleStudies.AutoSize = true;
            this.lblBibleStudies.Location = new System.Drawing.Point(60, 198);
            this.lblBibleStudies.Name = "lblBibleStudies";
            this.lblBibleStudies.Size = new System.Drawing.Size(71, 13);
            this.lblBibleStudies.TabIndex = 5;
            this.lblBibleStudies.Text = "Bible Studies:";
            // 
            // lblReturnVisits
            // 
            this.lblReturnVisits.AutoSize = true;
            this.lblReturnVisits.Location = new System.Drawing.Point(60, 166);
            this.lblReturnVisits.Name = "lblReturnVisits";
            this.lblReturnVisits.Size = new System.Drawing.Size(69, 13);
            this.lblReturnVisits.TabIndex = 4;
            this.lblReturnVisits.Text = "Return Visits:";
            // 
            // lblMagazines
            // 
            this.lblMagazines.AutoSize = true;
            this.lblMagazines.Location = new System.Drawing.Point(60, 134);
            this.lblMagazines.Name = "lblMagazines";
            this.lblMagazines.Size = new System.Drawing.Size(61, 13);
            this.lblMagazines.TabIndex = 3;
            this.lblMagazines.Text = "Magazines:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(60, 102);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(38, 13);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours:";
            // 
            // lblBrochures
            // 
            this.lblBrochures.AutoSize = true;
            this.lblBrochures.Location = new System.Drawing.Point(60, 70);
            this.lblBrochures.Name = "lblBrochures";
            this.lblBrochures.Size = new System.Drawing.Size(58, 13);
            this.lblBrochures.TabIndex = 1;
            this.lblBrochures.Text = "Brochures:";
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBook.Location = new System.Drawing.Point(60, 38);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(40, 13);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Books:";
            // 
            // gbCalendar
            // 
            this.gbCalendar.Controls.Add(this.monthCalendar);
            this.gbCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCalendar.Location = new System.Drawing.Point(562, 42);
            this.gbCalendar.Name = "gbCalendar";
            this.gbCalendar.Size = new System.Drawing.Size(250, 190);
            this.gbCalendar.TabIndex = 8;
            this.gbCalendar.TabStop = false;
            this.gbCalendar.Text = "Calendar";
            // 
            // gbMinutesRemainders
            // 
            this.gbMinutesRemainders.Controls.Add(this.txtNextMonthMinutes);
            this.gbMinutesRemainders.Controls.Add(this.txtPreviousMonthMinutes);
            this.gbMinutesRemainders.Controls.Add(this.lblNextMonth);
            this.gbMinutesRemainders.Controls.Add(this.lblPreviousMonth);
            this.gbMinutesRemainders.Location = new System.Drawing.Point(564, 525);
            this.gbMinutesRemainders.Name = "gbMinutesRemainders";
            this.gbMinutesRemainders.Size = new System.Drawing.Size(248, 148);
            this.gbMinutesRemainders.TabIndex = 9;
            this.gbMinutesRemainders.TabStop = false;
            this.gbMinutesRemainders.Text = "Minutes Remainders";
            // 
            // txtNextMonthMinutes
            // 
            this.txtNextMonthMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNextMonthMinutes.Location = new System.Drawing.Point(159, 67);
            this.txtNextMonthMinutes.Name = "txtNextMonthMinutes";
            this.txtNextMonthMinutes.ReadOnly = true;
            this.txtNextMonthMinutes.Size = new System.Drawing.Size(37, 13);
            this.txtNextMonthMinutes.TabIndex = 6;
            // 
            // txtPreviousMonthMinutes
            // 
            this.txtPreviousMonthMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPreviousMonthMinutes.Location = new System.Drawing.Point(159, 34);
            this.txtPreviousMonthMinutes.Name = "txtPreviousMonthMinutes";
            this.txtPreviousMonthMinutes.ReadOnly = true;
            this.txtPreviousMonthMinutes.Size = new System.Drawing.Size(37, 13);
            this.txtPreviousMonthMinutes.TabIndex = 6;
            // 
            // lblNextMonth
            // 
            this.lblNextMonth.AutoSize = true;
            this.lblNextMonth.Location = new System.Drawing.Point(60, 67);
            this.lblNextMonth.Name = "lblNextMonth";
            this.lblNextMonth.Size = new System.Drawing.Size(65, 13);
            this.lblNextMonth.TabIndex = 1;
            this.lblNextMonth.Text = "Next Month:";
            // 
            // lblPreviousMonth
            // 
            this.lblPreviousMonth.AutoSize = true;
            this.lblPreviousMonth.Location = new System.Drawing.Point(60, 34);
            this.lblPreviousMonth.Name = "lblPreviousMonth";
            this.lblPreviousMonth.Size = new System.Drawing.Size(63, 13);
            this.lblPreviousMonth.TabIndex = 0;
            this.lblPreviousMonth.Text = "Last Month:";
            // 
            // ReporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 827);
            this.Controls.Add(this.gbMinutesRemainders);
            this.Controls.Add(this.gbCalendar);
            this.Controls.Add(this.gbMonthlyReportStatus);
            this.Controls.Add(this.btnSendReport);
            this.Controls.Add(this.gbDailyReports);
            this.Controls.Add(this.ssReportStatus);
            this.Controls.Add(this.msReportsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msReportsMenu;
            this.MaximizeBox = false;
            this.Name = "ReporterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SReporter";
            this.Load += new System.EventHandler(this.ReporterForm_Load);
            this.msReportsMenu.ResumeLayout(false);
            this.msReportsMenu.PerformLayout();
            this.ssReportStatus.ResumeLayout(false);
            this.ssReportStatus.PerformLayout();
            this.gbDailyReports.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportsDashboard)).EndInit();
            this.gbMonthlyReportStatus.ResumeLayout(false);
            this.gbMonthlyReportStatus.PerformLayout();
            this.gbCalendar.ResumeLayout(false);
            this.gbMinutesRemainders.ResumeLayout(false);
            this.gbMinutesRemainders.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msReportsMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startReportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssReportStatus;
        private System.Windows.Forms.GroupBox gbDailyReports;
        private System.Windows.Forms.DataGridView dgvReportsDashboard;
        private System.Windows.Forms.ToolStripStatusLabel tsslReportsStatusBar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brochures;
        private System.Windows.Forms.DataGridViewTextBoxColumn Magazines;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnVisits;
        private System.Windows.Forms.Button btnSendReport;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.GroupBox gbMonthlyReportStatus;
        private System.Windows.Forms.GroupBox gbCalendar;
        private System.Windows.Forms.Label lblBibleStudies;
        private System.Windows.Forms.Label lblReturnVisits;
        private System.Windows.Forms.Label lblMagazines;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblBrochures;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.GroupBox gbMinutesRemainders;
        private System.Windows.Forms.Label lblNextMonth;
        private System.Windows.Forms.Label lblPreviousMonth;
        private System.Windows.Forms.TextBox txtBibleStudies;
        private System.Windows.Forms.TextBox txtReturnVisits;
        private System.Windows.Forms.TextBox txtMagazines;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtBrochures;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.TextBox txtNextMonthMinutes;
        private System.Windows.Forms.TextBox txtPreviousMonthMinutes;
    }
}

