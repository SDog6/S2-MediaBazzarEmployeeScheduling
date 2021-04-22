
namespace MediaBazzar
{
    partial class HR
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAllEmployees = new System.Windows.Forms.Button();
            this.btnCreateEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "What would you like to do ?";
            // 
            // btnViewAllEmployees
            // 
            this.btnViewAllEmployees.Location = new System.Drawing.Point(161, 166);
            this.btnViewAllEmployees.Name = "btnViewAllEmployees";
            this.btnViewAllEmployees.Size = new System.Drawing.Size(111, 53);
            this.btnViewAllEmployees.TabIndex = 1;
            this.btnViewAllEmployees.Text = "View all employees";
            this.btnViewAllEmployees.UseVisualStyleBackColor = true;
            this.btnViewAllEmployees.Click += new System.EventHandler(this.btnViewAllEmployees_Click);
            // 
            // btnCreateEmployee
            // 
            this.btnCreateEmployee.Location = new System.Drawing.Point(437, 166);
            this.btnCreateEmployee.Name = "btnCreateEmployee";
            this.btnCreateEmployee.Size = new System.Drawing.Size(111, 53);
            this.btnCreateEmployee.TabIndex = 2;
            this.btnCreateEmployee.Text = "Add employee to the system";
            this.btnCreateEmployee.UseVisualStyleBackColor = true;
            this.btnCreateEmployee.Click += new System.EventHandler(this.btnCreateEmployee_Click);
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 289);
            this.Controls.Add(this.btnCreateEmployee);
            this.Controls.Add(this.btnViewAllEmployees);
            this.Controls.Add(this.label1);
            this.Name = "HR";
            this.Text = "HR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAllEmployees;
        private System.Windows.Forms.Button btnCreateEmployee;
    }
}