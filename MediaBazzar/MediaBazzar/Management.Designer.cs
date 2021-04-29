
namespace MediaBazzar
{
    partial class Management
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnManagementStockFilter = new System.Windows.Forms.Button();
            this.tbManagementStockFilter = new System.Windows.Forms.TextBox();
            this.rbManagementStockAmountFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockIDFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockBrandFilter = new System.Windows.Forms.RadioButton();
            this.btnManagementRestockRequest = new System.Windows.Forms.Button();
            this.btnManagementNewStock = new System.Windows.Forms.Button();
            this.btnManagementStockUpdate = new System.Windows.Forms.Button();
            this.btnStockRemove = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.People = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbManagementEPFilter = new System.Windows.Forms.TextBox();
            this.rbManagementRole = new System.Windows.Forms.RadioButton();
            this.rbManagementID = new System.Windows.Forms.RadioButton();
            this.btnManagementEPFilter = new System.Windows.Forms.Button();
            this.lbManagemendEmployees = new System.Windows.Forms.ListBox();
            this.btnManagemntPersonCreation = new System.Windows.Forms.Button();
            this.btnManagemntPersonUpdate = new System.Windows.Forms.Button();
            this.btnManagemendUpdate = new System.Windows.Forms.Button();
            this.btnViewEmployeeInfo = new System.Windows.Forms.Button();
            this.DgvManagemendEmployees = new System.Windows.Forms.DataGridView();
            this.btnScheduling = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.People.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvManagemendEmployees)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbManagementStockBrandFilter);
            this.groupBox2.Controls.Add(this.rbManagementStockIDFilter);
            this.groupBox2.Controls.Add(this.rbManagementStockAmountFilter);
            this.groupBox2.Controls.Add(this.tbManagementStockFilter);
            this.groupBox2.Controls.Add(this.btnManagementStockFilter);
            this.groupBox2.Location = new System.Drawing.Point(18, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 144);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnManagementStockFilter
            // 
            this.btnManagementStockFilter.Location = new System.Drawing.Point(88, 95);
            this.btnManagementStockFilter.Name = "btnManagementStockFilter";
            this.btnManagementStockFilter.Size = new System.Drawing.Size(75, 32);
            this.btnManagementStockFilter.TabIndex = 3;
            this.btnManagementStockFilter.Text = "Filter";
            this.btnManagementStockFilter.UseVisualStyleBackColor = true;
            this.btnManagementStockFilter.Click += new System.EventHandler(this.btnManagementStockFilter_Click);
            // 
            // tbManagementStockFilter
            // 
            this.tbManagementStockFilter.Location = new System.Drawing.Point(74, 69);
            this.tbManagementStockFilter.Name = "tbManagementStockFilter";
            this.tbManagementStockFilter.Size = new System.Drawing.Size(100, 20);
            this.tbManagementStockFilter.TabIndex = 1;
            // 
            // rbManagementStockAmountFilter
            // 
            this.rbManagementStockAmountFilter.AutoSize = true;
            this.rbManagementStockAmountFilter.Location = new System.Drawing.Point(187, 29);
            this.rbManagementStockAmountFilter.Name = "rbManagementStockAmountFilter";
            this.rbManagementStockAmountFilter.Size = new System.Drawing.Size(61, 17);
            this.rbManagementStockAmountFilter.TabIndex = 7;
            this.rbManagementStockAmountFilter.TabStop = true;
            this.rbManagementStockAmountFilter.Text = "Amount";
            this.rbManagementStockAmountFilter.UseVisualStyleBackColor = true;
            // 
            // rbManagementStockIDFilter
            // 
            this.rbManagementStockIDFilter.AutoSize = true;
            this.rbManagementStockIDFilter.Location = new System.Drawing.Point(6, 29);
            this.rbManagementStockIDFilter.Name = "rbManagementStockIDFilter";
            this.rbManagementStockIDFilter.Size = new System.Drawing.Size(36, 17);
            this.rbManagementStockIDFilter.TabIndex = 5;
            this.rbManagementStockIDFilter.TabStop = true;
            this.rbManagementStockIDFilter.Text = "ID";
            this.rbManagementStockIDFilter.UseVisualStyleBackColor = true;
            // 
            // rbManagementStockBrandFilter
            // 
            this.rbManagementStockBrandFilter.AutoSize = true;
            this.rbManagementStockBrandFilter.Location = new System.Drawing.Point(98, 29);
            this.rbManagementStockBrandFilter.Name = "rbManagementStockBrandFilter";
            this.rbManagementStockBrandFilter.Size = new System.Drawing.Size(53, 17);
            this.rbManagementStockBrandFilter.TabIndex = 6;
            this.rbManagementStockBrandFilter.TabStop = true;
            this.rbManagementStockBrandFilter.Text = "Brand";
            this.rbManagementStockBrandFilter.UseVisualStyleBackColor = true;
            // 
            // btnManagementRestockRequest
            // 
            this.btnManagementRestockRequest.Location = new System.Drawing.Point(24, 287);
            this.btnManagementRestockRequest.Name = "btnManagementRestockRequest";
            this.btnManagementRestockRequest.Size = new System.Drawing.Size(242, 32);
            this.btnManagementRestockRequest.TabIndex = 4;
            this.btnManagementRestockRequest.Text = "[IN DEVELOPMENT]Make new restock request";
            this.btnManagementRestockRequest.UseVisualStyleBackColor = true;
            this.btnManagementRestockRequest.Click += new System.EventHandler(this.btnManagementRestockRequest_Click);
            // 
            // btnManagementNewStock
            // 
            this.btnManagementNewStock.Location = new System.Drawing.Point(42, 325);
            this.btnManagementNewStock.Name = "btnManagementNewStock";
            this.btnManagementNewStock.Size = new System.Drawing.Size(201, 44);
            this.btnManagementNewStock.TabIndex = 8;
            this.btnManagementNewStock.Text = "Request new stock to be added to inventory";
            this.btnManagementNewStock.UseVisualStyleBackColor = true;
            this.btnManagementNewStock.Click += new System.EventHandler(this.btnManagementNewStock_Click);
            // 
            // btnManagementStockUpdate
            // 
            this.btnManagementStockUpdate.Location = new System.Drawing.Point(80, 210);
            this.btnManagementStockUpdate.Name = "btnManagementStockUpdate";
            this.btnManagementStockUpdate.Size = new System.Drawing.Size(134, 32);
            this.btnManagementStockUpdate.TabIndex = 9;
            this.btnManagementStockUpdate.Text = "View store inventory";
            this.btnManagementStockUpdate.UseVisualStyleBackColor = true;
            this.btnManagementStockUpdate.Click += new System.EventHandler(this.btnManagementStockUpdate_Click_1);
            // 
            // btnStockRemove
            // 
            this.btnStockRemove.Location = new System.Drawing.Point(42, 249);
            this.btnStockRemove.Name = "btnStockRemove";
            this.btnStockRemove.Size = new System.Drawing.Size(201, 32);
            this.btnStockRemove.TabIndex = 11;
            this.btnStockRemove.Text = "Remove stock from inventory";
            this.btnStockRemove.UseVisualStyleBackColor = true;
            this.btnStockRemove.Click += new System.EventHandler(this.btnStockRemove_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(308, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(444, 244);
            this.dataGridView1.TabIndex = 13;
            // 
            // People
            // 
            this.People.Controls.Add(this.btnScheduling);
            this.People.Controls.Add(this.DgvManagemendEmployees);
            this.People.Controls.Add(this.btnViewEmployeeInfo);
            this.People.Controls.Add(this.btnManagemendUpdate);
            this.People.Controls.Add(this.btnManagemntPersonUpdate);
            this.People.Controls.Add(this.btnManagemntPersonCreation);
            this.People.Controls.Add(this.lbManagemendEmployees);
            this.People.Controls.Add(this.groupBox1);
            this.People.Location = new System.Drawing.Point(4, 22);
            this.People.Name = "People";
            this.People.Padding = new System.Windows.Forms.Padding(3);
            this.People.Size = new System.Drawing.Size(837, 702);
            this.People.TabIndex = 0;
            this.People.Text = "Employees";
            this.People.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnManagementEPFilter);
            this.groupBox1.Controls.Add(this.rbManagementID);
            this.groupBox1.Controls.Add(this.rbManagementRole);
            this.groupBox1.Controls.Add(this.tbManagementEPFilter);
            this.groupBox1.Location = new System.Drawing.Point(57, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 172);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering";
            // 
            // tbManagementEPFilter
            // 
            this.tbManagementEPFilter.Location = new System.Drawing.Point(44, 75);
            this.tbManagementEPFilter.Name = "tbManagementEPFilter";
            this.tbManagementEPFilter.Size = new System.Drawing.Size(157, 20);
            this.tbManagementEPFilter.TabIndex = 3;
            // 
            // rbManagementRole
            // 
            this.rbManagementRole.AutoSize = true;
            this.rbManagementRole.Location = new System.Drawing.Point(126, 28);
            this.rbManagementRole.Name = "rbManagementRole";
            this.rbManagementRole.Size = new System.Drawing.Size(47, 17);
            this.rbManagementRole.TabIndex = 6;
            this.rbManagementRole.TabStop = true;
            this.rbManagementRole.Text = "Role";
            this.rbManagementRole.UseVisualStyleBackColor = true;
            // 
            // rbManagementID
            // 
            this.rbManagementID.AutoSize = true;
            this.rbManagementID.Location = new System.Drawing.Point(65, 28);
            this.rbManagementID.Name = "rbManagementID";
            this.rbManagementID.Size = new System.Drawing.Size(36, 17);
            this.rbManagementID.TabIndex = 5;
            this.rbManagementID.TabStop = true;
            this.rbManagementID.Text = "ID";
            this.rbManagementID.UseVisualStyleBackColor = true;
            // 
            // btnManagementEPFilter
            // 
            this.btnManagementEPFilter.Location = new System.Drawing.Point(79, 128);
            this.btnManagementEPFilter.Name = "btnManagementEPFilter";
            this.btnManagementEPFilter.Size = new System.Drawing.Size(93, 38);
            this.btnManagementEPFilter.TabIndex = 4;
            this.btnManagementEPFilter.Text = "Filter";
            this.btnManagementEPFilter.UseVisualStyleBackColor = true;
            this.btnManagementEPFilter.Click += new System.EventHandler(this.btnManagementEPFilter_Click);
            // 
            // lbManagemendEmployees
            // 
            this.lbManagemendEmployees.FormattingEnabled = true;
            this.lbManagemendEmployees.Location = new System.Drawing.Point(364, 20);
            this.lbManagemendEmployees.Name = "lbManagemendEmployees";
            this.lbManagemendEmployees.Size = new System.Drawing.Size(311, 329);
            this.lbManagemendEmployees.TabIndex = 0;
            // 
            // btnManagemntPersonCreation
            // 
            this.btnManagemntPersonCreation.Location = new System.Drawing.Point(8, 249);
            this.btnManagemntPersonCreation.Name = "btnManagemntPersonCreation";
            this.btnManagemntPersonCreation.Size = new System.Drawing.Size(93, 38);
            this.btnManagemntPersonCreation.TabIndex = 1;
            this.btnManagemntPersonCreation.Text = "Add a new employee";
            this.btnManagemntPersonCreation.UseVisualStyleBackColor = true;
            this.btnManagemntPersonCreation.Click += new System.EventHandler(this.btnManagemntPersonCreation_Click);
            // 
            // btnManagemntPersonUpdate
            // 
            this.btnManagemntPersonUpdate.Location = new System.Drawing.Point(137, 249);
            this.btnManagemntPersonUpdate.Name = "btnManagemntPersonUpdate";
            this.btnManagemntPersonUpdate.Size = new System.Drawing.Size(93, 38);
            this.btnManagemntPersonUpdate.TabIndex = 2;
            this.btnManagemntPersonUpdate.Text = "Update employee information";
            this.btnManagemntPersonUpdate.UseVisualStyleBackColor = true;
            this.btnManagemntPersonUpdate.Click += new System.EventHandler(this.btnManagemntPersonUpdate_Click_1);
            // 
            // btnManagemendUpdate
            // 
            this.btnManagemendUpdate.Location = new System.Drawing.Point(265, 249);
            this.btnManagemendUpdate.Name = "btnManagemendUpdate";
            this.btnManagemendUpdate.Size = new System.Drawing.Size(93, 38);
            this.btnManagemendUpdate.TabIndex = 9;
            this.btnManagemendUpdate.Text = "View all employees";
            this.btnManagemendUpdate.UseVisualStyleBackColor = true;
            this.btnManagemendUpdate.Click += new System.EventHandler(this.btnManagemendUpdate_Click);
            // 
            // btnViewEmployeeInfo
            // 
            this.btnViewEmployeeInfo.Location = new System.Drawing.Point(137, 293);
            this.btnViewEmployeeInfo.Name = "btnViewEmployeeInfo";
            this.btnViewEmployeeInfo.Size = new System.Drawing.Size(93, 38);
            this.btnViewEmployeeInfo.TabIndex = 10;
            this.btnViewEmployeeInfo.Text = "View employee info";
            this.btnViewEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnViewEmployeeInfo.Click += new System.EventHandler(this.btnViewEmployeeInfo_Click);
            // 
            // DgvManagemendEmployees
            // 
            this.DgvManagemendEmployees.AllowUserToAddRows = false;
            this.DgvManagemendEmployees.AllowUserToDeleteRows = false;
            this.DgvManagemendEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvManagemendEmployees.Location = new System.Drawing.Point(265, 426);
            this.DgvManagemendEmployees.Name = "DgvManagemendEmployees";
            this.DgvManagemendEmployees.ReadOnly = true;
            this.DgvManagemendEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvManagemendEmployees.Size = new System.Drawing.Size(453, 248);
            this.DgvManagemendEmployees.TabIndex = 11;
            // 
            // btnScheduling
            // 
            this.btnScheduling.Location = new System.Drawing.Point(265, 293);
            this.btnScheduling.Name = "btnScheduling";
            this.btnScheduling.Size = new System.Drawing.Size(93, 38);
            this.btnScheduling.TabIndex = 12;
            this.btnScheduling.Text = "Schedule shifts";
            this.btnScheduling.UseVisualStyleBackColor = true;
            this.btnScheduling.Click += new System.EventHandler(this.btnScheduling_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.People);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 728);
            this.tabControl1.TabIndex = 0;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 740);
            this.Controls.Add(this.tabControl1);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.People.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvManagemendEmployees)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbManagementStockBrandFilter;
        private System.Windows.Forms.RadioButton rbManagementStockIDFilter;
        private System.Windows.Forms.RadioButton rbManagementStockAmountFilter;
        private System.Windows.Forms.TextBox tbManagementStockFilter;
        private System.Windows.Forms.Button btnManagementStockFilter;
        private System.Windows.Forms.Button btnManagementRestockRequest;
        private System.Windows.Forms.Button btnManagementNewStock;
        private System.Windows.Forms.Button btnManagementStockUpdate;
        private System.Windows.Forms.Button btnStockRemove;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage People;
        private System.Windows.Forms.Button btnScheduling;
        private System.Windows.Forms.DataGridView DgvManagemendEmployees;
        private System.Windows.Forms.Button btnViewEmployeeInfo;
        private System.Windows.Forms.Button btnManagemendUpdate;
        private System.Windows.Forms.Button btnManagemntPersonUpdate;
        private System.Windows.Forms.Button btnManagemntPersonCreation;
        private System.Windows.Forms.ListBox lbManagemendEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManagementEPFilter;
        private System.Windows.Forms.RadioButton rbManagementID;
        private System.Windows.Forms.RadioButton rbManagementRole;
        private System.Windows.Forms.TextBox tbManagementEPFilter;
        private System.Windows.Forms.TabControl tabControl1;
    }
}