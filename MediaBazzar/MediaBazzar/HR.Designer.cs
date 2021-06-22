
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
            this.btnEmpDetails = new System.Windows.Forms.Button();
            this.btnFireEmp = new System.Windows.Forms.Button();
            this.dataGrid_employees = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNon = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_employees)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmpDetails
            // 
            this.btnEmpDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnEmpDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpDetails.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnEmpDetails.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnEmpDetails.Location = new System.Drawing.Point(-3, 34);
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
            this.btnFireEmp.Location = new System.Drawing.Point(-3, 114);
            this.btnFireEmp.Name = "btnFireEmp";
            this.btnFireEmp.Size = new System.Drawing.Size(191, 56);
            this.btnFireEmp.TabIndex = 11;
            this.btnFireEmp.Text = "Fire an employee";
            this.btnFireEmp.UseVisualStyleBackColor = false;
            this.btnFireEmp.Click += new System.EventHandler(this.btnFireEmp_Click);
            // 
            // dataGrid_employees
            // 
            this.dataGrid_employees.AllowUserToAddRows = false;
            this.dataGrid_employees.AllowUserToDeleteRows = false;
            this.dataGrid_employees.AllowUserToResizeColumns = false;
            this.dataGrid_employees.AllowUserToResizeRows = false;
            this.dataGrid_employees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_employees.Location = new System.Drawing.Point(238, 114);
            this.dataGrid_employees.MultiSelect = false;
            this.dataGrid_employees.Name = "dataGrid_employees";
            this.dataGrid_employees.ReadOnly = true;
            this.dataGrid_employees.RowHeadersWidth = 51;
            this.dataGrid_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_employees.Size = new System.Drawing.Size(550, 288);
            this.dataGrid_employees.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(-3, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(191, 57);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add employee to the system";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.btnEmpDetails);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnFireEmp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 455);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.rbNon);
            this.panel2.Controls.Add(this.rbActive);
            this.panel2.Controls.Add(this.dataGrid_employees);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(856, 455);
            this.panel2.TabIndex = 16;
            // 
            // rbNon
            // 
            this.rbNon.AutoSize = true;
            this.rbNon.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNon.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbNon.Location = new System.Drawing.Point(543, 58);
            this.rbNon.Name = "rbNon";
            this.rbNon.Size = new System.Drawing.Size(116, 25);
            this.rbNon.TabIndex = 15;
            this.rbNon.TabStop = true;
            this.rbNon.Text = "Non-active";
            this.rbNon.UseVisualStyleBackColor = true;
            this.rbNon.CheckedChanged += new System.EventHandler(this.rbNon_CheckedChanged);
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbActive.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.rbActive.Location = new System.Drawing.Point(412, 58);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(81, 25);
            this.rbActive.TabIndex = 14;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Active";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.CheckedChanged += new System.EventHandler(this.rbActive_CheckedChanged);
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "HR";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_employees)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEmpDetails;
        private System.Windows.Forms.Button btnFireEmp;
        private System.Windows.Forms.DataGridView dataGrid_employees;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNon;
        private System.Windows.Forms.RadioButton rbActive;
    }
}