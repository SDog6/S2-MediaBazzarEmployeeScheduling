
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblConInf = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWorkHrs = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFire
            // 
            this.tbFire.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbFire.Location = new System.Drawing.Point(152, 497);
            this.tbFire.Margin = new System.Windows.Forms.Padding(4);
            this.tbFire.Multiline = true;
            this.tbFire.Name = "tbFire";
            this.tbFire.Size = new System.Drawing.Size(725, 163);
            this.tbFire.TabIndex = 0;
            // 
            // lblFire
            // 
            this.lblFire.AutoSize = true;
            this.lblFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblFire.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.lblFire.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblFire.Location = new System.Drawing.Point(318, 463);
            this.lblFire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFire.Name = "lblFire";
            this.lblFire.Size = new System.Drawing.Size(273, 19);
            this.lblFire.TabIndex = 1;
            this.lblFire.Text = "Please state the reason for firing ";
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFire.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnFire.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFire.Location = new System.Drawing.Point(442, 674);
            this.btnFire.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnFire);
            this.panel1.Controls.Add(this.lblFire);
            this.panel1.Controls.Add(this.tbFire);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 737);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(272, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Termination of employee\'s contract";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(252, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(511, 67);
            this.label2.TabIndex = 4;
            this.label2.Text = "By executing the following function the person will be layed off from employment " +
    "with our company, effective immediately after receiving his/hers letter of termi" +
    "nation.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblRole.Location = new System.Drawing.Point(15, 135);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(57, 25);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role:";
            // 
            // lblConInf
            // 
            this.lblConInf.AutoSize = true;
            this.lblConInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConInf.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblConInf.Location = new System.Drawing.Point(15, 185);
            this.lblConInf.Name = "lblConInf";
            this.lblConInf.Size = new System.Drawing.Size(192, 25);
            this.lblConInf.TabIndex = 6;
            this.lblConInf.Text = "Contract information:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblName.Location = new System.Drawing.Point(15, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name:";
            // 
            // lblWorkHrs
            // 
            this.lblWorkHrs.AutoSize = true;
            this.lblWorkHrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkHrs.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblWorkHrs.Location = new System.Drawing.Point(18, 237);
            this.lblWorkHrs.Name = "lblWorkHrs";
            this.lblWorkHrs.Size = new System.Drawing.Size(145, 25);
            this.lblWorkHrs.TabIndex = 8;
            this.lblWorkHrs.Text = "Working hours:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblAddress);
            this.panel2.Controls.Add(this.lblConInf);
            this.panel2.Controls.Add(this.lblWorkHrs);
            this.panel2.Controls.Add(this.lblRole);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Location = new System.Drawing.Point(97, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 288);
            this.panel2.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblAddress.Location = new System.Drawing.Point(15, 85);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(91, 25);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Address:";
            // 
            // EmployeeFiring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 737);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeFiring";
            this.Text = "EmployeeFiring";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbFire;
        private System.Windows.Forms.Label lblFire;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblConInf;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWorkHrs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAddress;
    }
}