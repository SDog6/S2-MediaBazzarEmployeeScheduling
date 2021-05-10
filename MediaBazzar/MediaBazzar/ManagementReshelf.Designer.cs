
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkbox_unfnished = new System.Windows.Forms.CheckBox();
            this.checkBox_complete = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReshelfApprove
            // 
            this.btnReshelfApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnReshelfApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReshelfApprove.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnReshelfApprove.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnReshelfApprove.Location = new System.Drawing.Point(294, 343);
            this.btnReshelfApprove.Name = "btnReshelfApprove";
            this.btnReshelfApprove.Size = new System.Drawing.Size(139, 71);
            this.btnReshelfApprove.TabIndex = 1;
            this.btnReshelfApprove.Text = "Approve";
            this.btnReshelfApprove.UseVisualStyleBackColor = false;
            this.btnReshelfApprove.Click += new System.EventHandler(this.btnReshelfApprove_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.checkbox_unfnished);
            this.panel1.Controls.Add(this.checkBox_complete);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.btnReshelfApprove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 426);
            this.panel1.TabIndex = 5;
            // 
            // checkbox_unfnished
            // 
            this.checkbox_unfnished.AutoSize = true;
            this.checkbox_unfnished.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_unfnished.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkbox_unfnished.Location = new System.Drawing.Point(417, 299);
            this.checkbox_unfnished.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_unfnished.Name = "checkbox_unfnished";
            this.checkbox_unfnished.Size = new System.Drawing.Size(155, 24);
            this.checkbox_unfnished.TabIndex = 21;
            this.checkbox_unfnished.Text = "Waiting approval";
            this.checkbox_unfnished.UseVisualStyleBackColor = true;
            this.checkbox_unfnished.CheckedChanged += new System.EventHandler(this.checkbox_unfnished_CheckedChanged);
            // 
            // checkBox_complete
            // 
            this.checkBox_complete.AutoSize = true;
            this.checkBox_complete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_complete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox_complete.Location = new System.Drawing.Point(225, 299);
            this.checkBox_complete.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_complete.Name = "checkBox_complete";
            this.checkBox_complete.Size = new System.Drawing.Size(101, 24);
            this.checkBox_complete.TabIndex = 20;
            this.checkBox_complete.Text = "Complete";
            this.checkBox_complete.UseVisualStyleBackColor = true;
            this.checkBox_complete.CheckedChanged += new System.EventHandler(this.checkBox_complete_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(37, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 253);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ManagementReshelf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 426);
            this.Controls.Add(this.panel1);
            this.Name = "ManagementReshelf";
            this.Text = "ManagementReshelf";
            this.Load += new System.EventHandler(this.ManagementReshelf_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReshelfApprove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkbox_unfnished;
        private System.Windows.Forms.CheckBox checkBox_complete;
    }
}