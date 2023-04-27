namespace LabProject_Task1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.formInputs1 = new LabProject_Task1.FormInputs();
            this.SuspendLayout();
            // 
            // formInputs1
            // 
            this.formInputs1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("formInputs1.BackgroundImage")));
            this.formInputs1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.formInputs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formInputs1.Location = new System.Drawing.Point(0, 0);
            this.formInputs1.Name = "formInputs1";
            this.formInputs1.Size = new System.Drawing.Size(1200, 780);
            this.formInputs1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 780);
            this.Controls.Add(this.formInputs1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private FormInputs formInputs1;
    }
}

