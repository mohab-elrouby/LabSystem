using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    partial class CRUD_Tests
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
            this.lblTests = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GVTests = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lblTestName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblTestPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtTestName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.numTestSalary = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnReset = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.GVTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTests
            // 
            this.lblTests.BackColor = System.Drawing.Color.Transparent;
            this.lblTests.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTests.Location = new System.Drawing.Point(280, 16);
            this.lblTests.Name = "lblTests";
            this.lblTests.Size = new System.Drawing.Size(87, 41);
            this.lblTests.TabIndex = 0;
            this.lblTests.Text = "Tests";
            // 
            // GVTests
            // 
            this.GVTests.AllowUserToAddRows = false;
            this.GVTests.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GVTests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GVTests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVTests.BackgroundColor = System.Drawing.Color.White;
            this.GVTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GVTests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVTests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GVTests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GVTests.ColumnHeadersHeight = 21;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GVTests.DefaultCellStyle = dataGridViewCellStyle3;
            this.GVTests.EnableHeadersVisualStyles = false;
            this.GVTests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVTests.Location = new System.Drawing.Point(344, 78);
            this.GVTests.Name = "GVTests";
            this.GVTests.ReadOnly = true;
            this.GVTests.RowHeadersVisible = false;
            this.GVTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GVTests.Size = new System.Drawing.Size(288, 362);
            this.GVTests.TabIndex = 1;
            this.GVTests.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GVTests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GVTests.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GVTests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GVTests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GVTests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GVTests.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GVTests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVTests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GVTests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GVTests.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVTests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GVTests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GVTests.ThemeStyle.HeaderStyle.Height = 21;
            this.GVTests.ThemeStyle.ReadOnly = true;
            this.GVTests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GVTests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GVTests.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GVTests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GVTests.ThemeStyle.RowsStyle.Height = 22;
            this.GVTests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GVTests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GVTests.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVTests_CellClick);
            // 
            // lblTestName
            // 
            this.lblTestName.BackColor = System.Drawing.Color.Transparent;
            this.lblTestName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.Location = new System.Drawing.Point(16, 79);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(105, 25);
            this.lblTestName.TabIndex = 2;
            this.lblTestName.Text = "Test Name";
            // 
            // lblTestPrice
            // 
            this.lblTestPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTestPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestPrice.Location = new System.Drawing.Point(16, 139);
            this.lblTestPrice.Name = "lblTestPrice";
            this.lblTestPrice.Size = new System.Drawing.Size(97, 25);
            this.lblTestPrice.TabIndex = 3;
            this.lblTestPrice.Text = "Test Price";
            // 
            // txtTestName
            // 
            this.txtTestName.AutoRoundedCorners = true;
            this.txtTestName.BorderRadius = 15;
            this.txtTestName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTestName.DefaultText = "";
            this.txtTestName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTestName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTestName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTestName.DisabledState.Parent = this.txtTestName;
            this.txtTestName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTestName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTestName.FocusedState.Parent = this.txtTestName;
            this.txtTestName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTestName.HoverState.Parent = this.txtTestName;
            this.txtTestName.Location = new System.Drawing.Point(138, 78);
            this.txtTestName.Name = "txtTestName";
            this.txtTestName.PasswordChar = '\0';
            this.txtTestName.PlaceholderText = "";
            this.txtTestName.SelectedText = "";
            this.txtTestName.ShadowDecoration.Parent = this.txtTestName;
            this.txtTestName.Size = new System.Drawing.Size(182, 33);
            this.txtTestName.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 14;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(39, 217);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(82, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 14;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.Enabled = false;
            this.btnDelete.FillColor = System.Drawing.Color.Firebrick;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(143, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(78, 31);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // numTestSalary
            // 
            this.numTestSalary.AllowDrop = true;
            this.numTestSalary.AutoRoundedCorners = true;
            this.numTestSalary.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.numTestSalary.BackColor = System.Drawing.Color.Transparent;
            this.numTestSalary.BorderRadius = 16;
            this.numTestSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numTestSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numTestSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numTestSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numTestSalary.DisabledState.Parent = this.numTestSalary;
            this.numTestSalary.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numTestSalary.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numTestSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numTestSalary.FocusedState.Parent = this.numTestSalary;
            this.numTestSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.numTestSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numTestSalary.Location = new System.Drawing.Point(138, 139);
            this.numTestSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numTestSalary.Name = "numTestSalary";
            this.numTestSalary.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.numTestSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numTestSalary.ShadowDecoration.Parent = this.numTestSalary;
            this.numTestSalary.Size = new System.Drawing.Size(182, 34);
            this.numTestSalary.TabIndex = 5;
            this.numTestSalary.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Animated = true;
            this.btnReset.AutoRoundedCorners = true;
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BorderRadius = 14;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(242, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(78, 31);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // CRUD_Tests
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numTestSalary);
            this.Controls.Add(this.txtTestName);
            this.Controls.Add(this.lblTestPrice);
            this.Controls.Add(this.lblTestName);
            this.Controls.Add(this.GVTests);
            this.Controls.Add(this.lblTests);
            this.Name = "CRUD_Tests";
            this.Size = new System.Drawing.Size(643, 476);
            ((System.ComponentModel.ISupportInitialize)(this.GVTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTestSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lblTests;
        private Guna.UI2.WinForms.Guna2DataGridView GVTests;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTestName;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTestPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtTestName;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna2NumericUpDown numTestSalary;
        private Guna2Button btnReset;
    }
}
