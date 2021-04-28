
namespace MediaBazzar
{
    partial class EmployeeFiring
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
            this.tbFire = new System.Windows.Forms.TextBox();
            this.lblFire = new System.Windows.Forms.Label();
            this.btnFire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFire
            // 
            this.tbFire.Location = new System.Drawing.Point(81, 72);
            this.tbFire.Multiline = true;
            this.tbFire.Name = "tbFire";
            this.tbFire.Size = new System.Drawing.Size(213, 109);
            this.tbFire.TabIndex = 0;
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.Location = new System.Drawing.Point(106, 39);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(161, 13);
            this.lblFire.TabIndex = 1;
            this.lblFire.Text = "Please state the reason for firing ";
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(135, 197);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(112, 41);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            // 
            // EmployeeFiring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 291);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.lblFire);
            this.Controls.Add(this.tbFire);
            this.Name = "EmployeeFiring";
            this.Text = "EmployeeFiring";
            this.Load += new System.EventHandler(this.EmployeeFiring_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFire;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Button btnFire;
    }
}