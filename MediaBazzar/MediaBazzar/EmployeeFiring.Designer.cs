
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFire
            // 
            this.tbFire.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbFire.Location = new System.Drawing.Point(108, 89);
            this.tbFire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFire.Multiline = true;
            this.tbFire.Name = "tbFire";
            this.tbFire.Size = new System.Drawing.Size(283, 133);
            this.tbFire.TabIndex = 0;
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblFire.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFire.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFire.Location = new System.Drawing.Point(45, 43);
            this.lblFire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(326, 23);
            this.lblFire.TabIndex = 1;
            this.lblFire.Text = "Please state the reason for firing ";
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFire.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnFire.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFire.Location = new System.Drawing.Point(180, 242);
            this.btnFire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(149, 50);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.lblFire);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 358);
            this.panel1.TabIndex = 3;
            // 
            // EmployeeFiring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 358);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.tbFire);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EmployeeFiring";
            this.Text = "EmployeeFiring";
            this.Load += new System.EventHandler(this.EmployeeFiring_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFire;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Panel panel1;
    }
}