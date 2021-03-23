
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
            this.SuspendLayout();
            // 
            // btnReshelfApprove
            // 
            this.btnReshelfApprove.Location = new System.Drawing.Point(103, 112);
            this.btnReshelfApprove.Name = "btnReshelfApprove";
            this.btnReshelfApprove.Size = new System.Drawing.Size(90, 32);
            this.btnReshelfApprove.TabIndex = 1;
            this.btnReshelfApprove.Text = "Send request";
            this.btnReshelfApprove.UseVisualStyleBackColor = true;
            this.btnReshelfApprove.Click += new System.EventHandler(this.btnReshelfApprove_Click);
            // 
            // tbReshelfApprove
            // 
            this.tbReshelfApprove.Location = new System.Drawing.Point(103, 72);
            this.tbReshelfApprove.Name = "tbReshelfApprove";
            this.tbReshelfApprove.Size = new System.Drawing.Size(90, 20);
            this.tbReshelfApprove.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Amount needed:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblStockName
            // 
            this.lblStockName.AutoSize = true;
            this.lblStockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockName.Location = new System.Drawing.Point(100, 19);
            this.lblStockName.Name = "lblStockName";
            this.lblStockName.Size = new System.Drawing.Size(93, 16);
            this.lblStockName.TabIndex = 4;
            this.lblStockName.Text = "Stock_name";
            // 
            // ManagementReshelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 181);
            this.Controls.Add(this.lblStockName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReshelfApprove);
            this.Controls.Add(this.btnReshelfApprove);
            this.Name = "ManagementReshelf";
            this.Text = "ManagementReshelf";
            this.Load += new System.EventHandler(this.ManagementReshelf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReshelfApprove;
        private System.Windows.Forms.TextBox tbReshelfApprove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStockName;
    }
}