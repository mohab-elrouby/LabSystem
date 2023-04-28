namespace WindowsFormsApp1
{
    partial class Patient_Data
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DdPatientsName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPatientName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GVpatient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PAname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAjob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAcity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAMedicalHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAtests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PATestsPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GVdoctor = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblDoctorName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.DdDoctorsName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRTestsNumbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRTestSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DRTestRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GVpatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVdoctor)).BeginInit();
            this.SuspendLayout();
            // 
            // DdPatientsName
            // 
            this.DdPatientsName.BackColor = System.Drawing.Color.Transparent;
            this.DdPatientsName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DdPatientsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdPatientsName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DdPatientsName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DdPatientsName.FocusedState.Parent = this.DdPatientsName;
            this.DdPatientsName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DdPatientsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DdPatientsName.HoverState.Parent = this.DdPatientsName;
            this.DdPatientsName.ItemHeight = 30;
            this.DdPatientsName.ItemsAppearance.Parent = this.DdPatientsName;
            this.DdPatientsName.Location = new System.Drawing.Point(177, 16);
            this.DdPatientsName.Name = "DdPatientsName";
            this.DdPatientsName.ShadowDecoration.Parent = this.DdPatientsName;
            this.DdPatientsName.Size = new System.Drawing.Size(243, 36);
            this.DdPatientsName.TabIndex = 3;
            // 
            // lblPatientName
            // 
            this.lblPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.Location = new System.Drawing.Point(39, 22);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(132, 25);
            this.lblPatientName.TabIndex = 4;
            this.lblPatientName.Text = "Patient Name";
            // 
            // GVpatient
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GVpatient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVpatient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVpatient.BackgroundColor = System.Drawing.Color.White;
            this.GVpatient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVpatient.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVpatient.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVpatient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GVpatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVpatient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PAname,
            this.PAage,
            this.PAjob,
            this.PAcity,
            this.PAphone,
            this.PAMedicalHistory,
            this.PAtests,
            this.PAdate,
            this.PATestsPrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVpatient.DefaultCellStyle = dataGridViewCellStyle3;
            this.GVpatient.EnableHeadersVisualStyles = false;
            this.GVpatient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVpatient.Location = new System.Drawing.Point(26, 63);
            this.GVpatient.Name = "GVpatient";
            this.GVpatient.RowHeadersVisible = false;
            this.GVpatient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVpatient.Size = new System.Drawing.Size(649, 204);
            this.GVpatient.TabIndex = 5;
            this.GVpatient.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GVpatient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GVpatient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GVpatient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GVpatient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GVpatient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GVpatient.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GVpatient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVpatient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GVpatient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVpatient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVpatient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GVpatient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVpatient.ThemeStyle.HeaderStyle.Height = 40;
            this.GVpatient.ThemeStyle.ReadOnly = false;
            this.GVpatient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GVpatient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVpatient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVpatient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GVpatient.ThemeStyle.RowsStyle.Height = 22;
            this.GVpatient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVpatient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PAname
            // 
            this.PAname.HeaderText = "Name";
            this.PAname.Name = "PAname";
            // 
            // PAage
            // 
            this.PAage.HeaderText = "Age";
            this.PAage.Name = "PAage";
            // 
            // PAjob
            // 
            this.PAjob.HeaderText = "Job";
            this.PAjob.Name = "PAjob";
            // 
            // PAcity
            // 
            this.PAcity.HeaderText = "City";
            this.PAcity.Name = "PAcity";
            // 
            // PAphone
            // 
            this.PAphone.HeaderText = "Phone";
            this.PAphone.Name = "PAphone";
            // 
            // PAMedicalHistory
            // 
            this.PAMedicalHistory.HeaderText = "Medical History";
            this.PAMedicalHistory.Name = "PAMedicalHistory";
            // 
            // PAtests
            // 
            this.PAtests.HeaderText = "Tests Name";
            this.PAtests.Name = "PAtests";
            // 
            // PAdate
            // 
            this.PAdate.HeaderText = "Tests Date";
            this.PAdate.Name = "PAdate";
            // 
            // PATestsPrice
            // 
            this.PATestsPrice.HeaderText = "Tests Price";
            this.PATestsPrice.Name = "PATestsPrice";
            // 
            // GVdoctor
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.GVdoctor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GVdoctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVdoctor.BackgroundColor = System.Drawing.Color.White;
            this.GVdoctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVdoctor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVdoctor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVdoctor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.GVdoctor.ColumnHeadersHeight = 40;
            this.GVdoctor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.DRTestsNumbers,
            this.dataGridViewTextBoxColumn7,
            this.DRTestSalary,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.DRTestRevenue});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVdoctor.DefaultCellStyle = dataGridViewCellStyle6;
            this.GVdoctor.EnableHeadersVisualStyles = false;
            this.GVdoctor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVdoctor.Location = new System.Drawing.Point(25, 320);
            this.GVdoctor.Name = "GVdoctor";
            this.GVdoctor.RowHeadersVisible = false;
            this.GVdoctor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVdoctor.Size = new System.Drawing.Size(649, 204);
            this.GVdoctor.TabIndex = 8;
            this.GVdoctor.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GVdoctor.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GVdoctor.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GVdoctor.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GVdoctor.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GVdoctor.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GVdoctor.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GVdoctor.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVdoctor.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GVdoctor.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVdoctor.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVdoctor.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GVdoctor.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GVdoctor.ThemeStyle.HeaderStyle.Height = 40;
            this.GVdoctor.ThemeStyle.ReadOnly = false;
            this.GVdoctor.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GVdoctor.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVdoctor.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVdoctor.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GVdoctor.ThemeStyle.RowsStyle.Height = 22;
            this.GVdoctor.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVdoctor.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.BackColor = System.Drawing.Color.Transparent;
            this.lblDoctorName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.Location = new System.Drawing.Point(38, 279);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(128, 25);
            this.lblDoctorName.TabIndex = 7;
            this.lblDoctorName.Text = "Doctor Name";
            // 
            // DdDoctorsName
            // 
            this.DdDoctorsName.BackColor = System.Drawing.Color.Transparent;
            this.DdDoctorsName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DdDoctorsName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DdDoctorsName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DdDoctorsName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DdDoctorsName.FocusedState.Parent = this.DdDoctorsName;
            this.DdDoctorsName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DdDoctorsName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DdDoctorsName.HoverState.Parent = this.DdDoctorsName;
            this.DdDoctorsName.ItemHeight = 30;
            this.DdDoctorsName.ItemsAppearance.Parent = this.DdDoctorsName;
            this.DdDoctorsName.Location = new System.Drawing.Point(176, 273);
            this.DdDoctorsName.Name = "DdDoctorsName";
            this.DdDoctorsName.ShadowDecoration.Parent = this.DdDoctorsName;
            this.DdDoctorsName.Size = new System.Drawing.Size(243, 36);
            this.DdDoctorsName.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // DRTestsNumbers
            // 
            this.DRTestsNumbers.HeaderText = "Tests Numbers";
            this.DRTestsNumbers.Name = "DRTestsNumbers";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tests Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // DRTestSalary
            // 
            this.DRTestSalary.HeaderText = "Test Salary";
            this.DRTestSalary.Name = "DRTestSalary";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Tests Date";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Tests Price";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // DRTestRevenue
            // 
            this.DRTestRevenue.HeaderText = "Tests Revenue";
            this.DRTestRevenue.Name = "DRTestRevenue";
            // 
            // Patient_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GVdoctor);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.DdDoctorsName);
            this.Controls.Add(this.GVpatient);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.DdPatientsName);
            this.Name = "Patient_Data";
            this.Size = new System.Drawing.Size(690, 543);
            ((System.ComponentModel.ISupportInitialize)(this.GVpatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GVdoctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox DdPatientsName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPatientName;
        private Guna.UI2.WinForms.Guna2DataGridView GVpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAage;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAjob;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAcity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAMedicalHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAtests;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PATestsPrice;
        private Guna.UI2.WinForms.Guna2DataGridView GVdoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRTestsNumbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRTestSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn DRTestRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblDoctorName;
        private Guna.UI2.WinForms.Guna2ComboBox DdDoctorsName;
    }
}
