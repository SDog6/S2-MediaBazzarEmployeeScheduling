
namespace MediaBazzar
{
    partial class ManagementReshelf
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
            this.btnReshelfApprove = new System.Windows.Forms.Button();
            this.tbReshelfApprove = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStockName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReshelfApprove
            // 
            this.btnReshelfApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnReshelfApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReshelfApprove.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnReshelfApprove.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReshelfApprove.Location = new System.Drawing.Point(80, 117);
            this.btnReshelfApprove.Name = "btnReshelfApprove";
            this.btnReshelfApprove.Size = new System.Drawing.Size(90, 32);
            this.btnReshelfApprove.TabIndex = 1;
            this.btnReshelfApprove.Text = "Send request";
            this.btnReshelfApprove.UseVisualStyleBackColor = false;
            this.btnReshelfApprove.Click += new System.EventHandler(this.btnReshelfApprove_Click);
            // 
            // tbReshelfApprove
            // 
            this.tbReshelfApprove.Location = new System.Drawing.Point(145, 75);
            this.tbReshelfApprove.Name = "tbReshelfApprove";
            this.tbReshelfApprove.Size = new System.Drawing.Size(90, 20);
            this.tbReshelfApprove.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount needed:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lblStockName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblStockName.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblStockName.Location = new System.Drawing.Point(76, 21);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(107, 21);
            this.lblStockName.TabIndex = 4;
            this.lblStockName.Text = "Stock_name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.lblStockName);
            this.panel1.Controls.Add(this.tbReshelfApprove);
            this.panel1.Controls.Add(this.btnReshelfApprove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 181);
            this.panel1.TabIndex = 5;
            // 
            // ManagementReshelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ManagementReshelf";
            this.Text = "ManagementReshelf";
            this.Load += new System.EventHandler(this.ManagementReshelf_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReshelfApprove;
        private System.Windows.Forms.TextBox tbReshelfApprove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStockName;
        private System.Windows.Forms.Panel panel1;
    }
}