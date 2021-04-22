
namespace MediaBazzar
{
    partial class Employees
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
            this.lbManagemendEmployees = new System.Windows.Forms.ListBox();
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.btnFireEmp = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.DGVManagementEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManagementEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // lbManagemendEmployees
            // 
            this.lbManagemendEmployees.FormattingEnabled = true;
            this.lbManagemendEmployees.Location = new System.Drawing.Point(24, 12);
            this.lbManagemendEmployees.Name = "lbManagemendEmployees";
            this.lbManagemendEmployees.Size = new System.Drawing.Size(710, 329);
            this.lbManagemendEmployees.TabIndex = 1;
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.Location = new System.Drawing.Point(169, 365);
            this.btnEmpDetails.Name = "btnEmpDetails";
            this.btnEmpDetails.Size = new System.Drawing.Size(93, 38);
            this.btnEmpDetails.TabIndex = 10;
            this.btnEmpDetails.Text = "View details about employee";
            this.btnEmpDetails.UseVisualStyleBackColor = true;
            this.btnEmpDetails.Click += new System.EventHandler(this.btnEmpDetails_Click);
            // 
            // btnFireEmp
            // 
            this.btnFireEmp.Location = new System.Drawing.Point(339, 365);
            this.btnFireEmp.Name = "btnFireEmp";
            this.btnFireEmp.Size = new System.Drawing.Size(93, 38);
            this.btnFireEmp.TabIndex = 11;
            this.btnFireEmp.Text = "Fire an employee";
            this.btnFireEmp.UseVisualStyleBackColor = true;
            this.btnFireEmp.Click += new System.EventHandler(this.btnFireEmp_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.Location = new System.Drawing.Point(495, 365);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(93, 38);
            this.btnEmpUpdate.TabIndex = 12;
            this.btnEmpUpdate.Text = "Update employee info";
            this.btnEmpUpdate.UseVisualStyleBackColor = true;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // DGVManagementEmployees
            // 
            this.DGVManagementEmployees.AllowUserToAddRows = false;
            this.DGVManagementEmployees.AllowUserToDeleteRows = false;
            this.DGVManagementEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManagementEmployees.Location = new System.Drawing.Point(24, 452);
            this.DGVManagementEmployees.Name = "DGVManagementEmployees";
            this.DGVManagementEmployees.ReadOnly = true;
            this.DGVManagementEmployees.Size = new System.Drawing.Size(710, 263);
            this.DGVManagementEmployees.TabIndex = 13;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 802);
            this.Controls.Add(this.DGVManagementEmployees);
            this.Controls.Add(this.btnEmpUpdate);
            this.Controls.Add(this.btnFireEmp);
            this.Controls.Add(this.btnEmpDetails);
            this.Controls.Add(this.lbManagemendEmployees);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVManagementEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbManagemendEmployees;
        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Button btnFireEmp;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.DataGridView DGVManagementEmployees;
    }
}