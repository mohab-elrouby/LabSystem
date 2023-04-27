namespace WindowsFormsApp1
{
    partial class Tests_in_month
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbFromDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GVmonth = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TESTname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Testsnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestsEarnings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVtest = new Guna.UI2.WinForms.Guna2DataGridView();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTest = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.comboTests = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblToDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnFilter = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVmonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVtest)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFromDate
            // 
            this.lbFromDate.BackColor = System.Drawing.Color.Transparent;
            this.lbFromDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFromDate.Location = new System.Drawing.Point(55, 28);
            this.lbFromDate.Name = "lbFromDate";
            this.lbFromDate.Size = new System.Drawing.Size(55, 21);
            this.lbFromDate.TabIndex = 6;
            this.lbFromDate.Text = "From :";
            // 
            // GVmonth
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.GVmonth.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.GVmonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVmonth.BackgroundColor = System.Drawing.Color.White;
            this.GVmonth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVmonth.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVmonth.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVmonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.GVmonth.ColumnHeadersHeight = 40;
            this.GVmonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TESTname,
            this.Testsnumber,
            this.TestsEarnings});
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVmonth.DefaultCellStyle = dataGridViewCellStyle27;
            this.GVmonth.EnableHeadersVisualStyles = false;
            this.GVmonth.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVmonth.Location = new System.Drawing.Point(32, 70);
            this.GVmonth.Name = "GVmonth";
            this.GVmonth.RowHeadersVisible = false;
            this.GVmonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVmonth.Size = new System.Drawing.Size(649, 204);
            this.GVmonth.TabIndex = 7;
            this.GVmonth.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GVmonth.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GVmonth.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GVmonth.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GVmonth.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GVmonth.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GVmonth.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GVmonth.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVmonth.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GVmonth.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVmonth.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVmonth.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GVmonth.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GVmonth.ThemeStyle.HeaderStyle.Height = 40;
            this.GVmonth.ThemeStyle.ReadOnly = false;
            this.GVmonth.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GVmonth.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVmonth.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVmonth.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GVmonth.ThemeStyle.RowsStyle.Height = 22;
            this.GVmonth.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVmonth.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TESTname
            // 
            this.TESTname.HeaderText = "Test Name";
            this.TESTname.Name = "TESTname";
            // 
            // Testsnumber
            // 
            this.Testsnumber.HeaderText = "Tests Number";
            this.Testsnumber.Name = "Testsnumber";
            // 
            // TestsEarnings
            // 
            this.TestsEarnings.HeaderText = "Tests Earnings";
            this.TestsEarnings.Name = "TestsEarnings";
            // 
            // GVtest
            // 
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.White;
            this.GVtest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.GVtest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVtest.BackgroundColor = System.Drawing.Color.White;
            this.GVtest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVtest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVtest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVtest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.GVtest.ColumnHeadersHeight = 40;
            this.GVtest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.month,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVtest.DefaultCellStyle = dataGridViewCellStyle30;
            this.GVtest.EnableHeadersVisualStyles = false;
            this.GVtest.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVtest.Location = new System.Drawing.Point(32, 330);
            this.GVtest.Name = "GVtest";
            this.GVtest.RowHeadersVisible = false;
            this.GVtest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVtest.Size = new System.Drawing.Size(649, 204);
            this.GVtest.TabIndex = 10;
            this.GVtest.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GVtest.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GVtest.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GVtest.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GVtest.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GVtest.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GVtest.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GVtest.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVtest.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GVtest.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVtest.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVtest.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GVtest.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GVtest.ThemeStyle.HeaderStyle.Height = 40;
            this.GVtest.ThemeStyle.ReadOnly = false;
            this.GVtest.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GVtest.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVtest.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVtest.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GVtest.ThemeStyle.RowsStyle.Height = 22;
            this.GVtest.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVtest.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // month
            // 
            this.month.HeaderText = "Month";
            this.month.Name = "month";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tests Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Tests Earnings";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblTest
            // 
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(63, 290);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(44, 25);
            this.lblTest.TabIndex = 9;
            this.lblTest.Text = "Test";
            // 
            // comboTests
            // 
            this.comboTests.BackColor = System.Drawing.Color.Transparent;
            this.comboTests.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboTests.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTests.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTests.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboTests.FocusedState.Parent = this.comboTests;
            this.comboTests.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboTests.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboTests.HoverState.Parent = this.comboTests;
            this.comboTests.ItemHeight = 30;
            this.comboTests.ItemsAppearance.Parent = this.comboTests;
            this.comboTests.Location = new System.Drawing.Point(137, 283);
            this.comboTests.Name = "comboTests";
            this.comboTests.ShadowDecoration.Parent = this.comboTests;
            this.comboTests.Size = new System.Drawing.Size(146, 36);
            this.comboTests.TabIndex = 8;
            this.comboTests.SelectionChangeCommitted += new System.EventHandler(this.comboTests_SelectionChangeCommitted);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Animated = true;
            this.dtpFrom.AutoRoundedCorners = true;
            this.dtpFrom.BorderRadius = 13;
            this.dtpFrom.CheckedState.Parent = this.dtpFrom;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFrom.HoverState.Parent = this.dtpFrom;
            this.dtpFrom.Location = new System.Drawing.Point(126, 22);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.ShadowDecoration.Parent = this.dtpFrom;
            this.dtpFrom.Size = new System.Drawing.Size(122, 29);
            this.dtpFrom.TabIndex = 11;
            this.dtpFrom.Value = new System.DateTime(2023, 4, 27, 0, 22, 53, 49);
            // 
            // dtpTo
            // 
            this.dtpTo.Animated = true;
            this.dtpTo.AutoRoundedCorners = true;
            this.dtpTo.BorderRadius = 13;
            this.dtpTo.CheckedState.Parent = this.dtpTo;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTo.HoverState.Parent = this.dtpTo;
            this.dtpTo.Location = new System.Drawing.Point(340, 22);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.ShadowDecoration.Parent = this.dtpTo;
            this.dtpTo.Size = new System.Drawing.Size(127, 29);
            this.dtpTo.TabIndex = 13;
            this.dtpTo.Value = new System.DateTime(2023, 4, 27, 0, 22, 53, 49);
            // 
            // lblToDate
            // 
            this.lblToDate.BackColor = System.Drawing.Color.Transparent;
            this.lblToDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(291, 27);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(35, 21);
            this.lblToDate.TabIndex = 14;
            this.lblToDate.Text = "To :";
            // 
            // btnFilter
            // 
            this.btnFilter.Animated = true;
            this.btnFilter.AutoRoundedCorners = true;
            this.btnFilter.BorderRadius = 18;
            this.btnFilter.CheckedState.Parent = this.btnFilter;
            this.btnFilter.CustomImages.Parent = this.btnFilter;
            this.btnFilter.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.HoverState.Parent = this.btnFilter;
            this.btnFilter.Location = new System.Drawing.Point(536, 16);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShadowDecoration.Parent = this.btnFilter;
            this.btnFilter.Size = new System.Drawing.Size(88, 38);
            this.btnFilter.TabIndex = 15;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // Tests_in_month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.GVtest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.comboTests);
            this.Controls.Add(this.GVmonth);
            this.Controls.Add(this.lbFromDate);
            this.Name = "Tests_in_month";
            this.Size = new System.Drawing.Size(720, 548);
            ((System.ComponentModel.ISupportInitialize)(this.GVmonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVtest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbFromDate;
        private Guna.UI2.WinForms.Guna2DataGridView GVmonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TESTname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Testsnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestsEarnings;
        private Guna.UI2.WinForms.Guna2DataGridView GVtest;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTest;
        private Guna.UI2.WinForms.Guna2ComboBox comboTests;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblToDate;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
    }
}
