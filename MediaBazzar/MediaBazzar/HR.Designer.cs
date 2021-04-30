
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
            this.lbManagemendEmployees = new System.Windows.Forms.ListBox();
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.btnFireEmp = new System.Windows.Forms.Button();
            this.btnEmpUpdate = new System.Windows.Forms.Button();
            this.DGVManagementEmployees = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVManagementEmployees)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbManagemendEmployees
            // 
            this.lbManagemendEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbManagemendEmployees.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbManagemendEmployees.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbManagemendEmployees.FormattingEnabled = true;
            this.lbManagemendEmployees.ItemHeight = 17;
            this.lbManagemendEmployees.Location = new System.Drawing.Point(246, 32);
            this.lbManagemendEmployees.Name = "lbManagemendEmployees";
            this.lbManagemendEmployees.Size = new System.Drawing.Size(710, 327);
            this.lbManagemendEmployees.TabIndex = 1;
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnEmpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDetails.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEmpDetails.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEmpDetails.Location = new System.Drawing.Point(0, 114);
            this.btnEmpDetails.Name = "btnEmpDetails";
            this.btnEmpDetails.Size = new System.Drawing.Size(191, 60);
            this.btnEmpDetails.TabIndex = 10;
            this.btnEmpDetails.Text = "View details about employee";
            this.btnEmpDetails.UseVisualStyleBackColor = false;
            this.btnEmpDetails.Click += new System.EventHandler(this.btnEmpDetails_Click);
            // 
            // btnFireEmp
            // 
            this.btnFireEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnFireEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFireEmp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnFireEmp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFireEmp.Location = new System.Drawing.Point(0, 192);
            this.btnFireEmp.Name = "btnFireEmp";
            this.btnFireEmp.Size = new System.Drawing.Size(191, 56);
            this.btnFireEmp.TabIndex = 11;
            this.btnFireEmp.Text = "Fire an employee";
            this.btnFireEmp.UseVisualStyleBackColor = false;
            this.btnFireEmp.Click += new System.EventHandler(this.btnFireEmp_Click);
            // 
            // btnEmpUpdate
            // 
            this.btnEmpUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnEmpUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpUpdate.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEmpUpdate.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEmpUpdate.Location = new System.Drawing.Point(0, 348);
            this.btnEmpUpdate.Name = "btnEmpUpdate";
            this.btnEmpUpdate.Size = new System.Drawing.Size(191, 54);
            this.btnEmpUpdate.TabIndex = 12;
            this.btnEmpUpdate.Text = "Update employee info";
            this.btnEmpUpdate.UseVisualStyleBackColor = false;
            this.btnEmpUpdate.Click += new System.EventHandler(this.btnEmpUpdate_Click);
            // 
            // DGVManagementEmployees
            // 
            this.DGVManagementEmployees.AllowUserToAddRows = false;
            this.DGVManagementEmployees.AllowUserToDeleteRows = false;
            this.DGVManagementEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVManagementEmployees.Location = new System.Drawing.Point(255, 380);
            this.DGVManagementEmployees.Name = "DGVManagementEmployees";
            this.DGVManagementEmployees.ReadOnly = true;
            this.DGVManagementEmployees.Size = new System.Drawing.Size(710, 263);
            this.DGVManagementEmployees.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(0, 270);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 57);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add employee to the system";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnEmpDetails);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnEmpUpdate);
            this.panel1.Controls.Add(this.btnFireEmp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 749);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.lbManagemendEmployees);
            this.panel2.Controls.Add(this.DGVManagementEmployees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 749);
            this.panel2.TabIndex = 16;
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "HR";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVManagementEmployees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbManagemendEmployees;
        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Button btnFireEmp;
        private System.Windows.Forms.Button btnEmpUpdate;
        private System.Windows.Forms.DataGridView DGVManagementEmployees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}