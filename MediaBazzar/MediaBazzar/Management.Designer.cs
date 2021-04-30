
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.People = new System.Windows.Forms.TabPage();
            this.checkbox_fired = new System.Windows.Forms.CheckBox();
            this.checkBox_active = new System.Windows.Forms.CheckBox();
            this.btnViewEmployeeInfo = new System.Windows.Forms.Button();
            this.btnManagemendUpdate = new System.Windows.Forms.Button();
            this.lbManagemendEmployees = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_allRoles = new System.Windows.Forms.ComboBox();
            this.radio_name = new System.Windows.Forms.RadioButton();
            this.radio_ID = new System.Windows.Forms.RadioButton();
            this.radio_role = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.DgvManagemendEmployees = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStockRemove = new System.Windows.Forms.Button();
            this.btnManagementStockUpdate = new System.Windows.Forms.Button();
            this.btnManagementNewStock = new System.Windows.Forms.Button();
            this.btnManagementRestockRequest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbManagementStockBrandFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockIDFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockAmountFilter = new System.Windows.Forms.RadioButton();
            this.tbManagementStockFilter = new System.Windows.Forms.TextBox();
            this.btnManagementStockFilter = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.People.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvManagemendEmployees)).BeginInit();
            this.Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.People);
            this.tabControl1.Controls.Add(this.Stock);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(845, 728);
            this.tabControl1.TabIndex = 0;
            // 
            // People
            // 
            this.People.Controls.Add(this.checkbox_fired);
            this.People.Controls.Add(this.checkBox_active);
            this.People.Controls.Add(this.btnViewEmployeeInfo);
            this.People.Controls.Add(this.btnManagemendUpdate);
            this.People.Controls.Add(this.lbManagemendEmployees);
            this.People.Controls.Add(this.groupBox1);
            this.People.Controls.Add(this.DgvManagemendEmployees);
            this.People.Location = new System.Drawing.Point(4, 22);
            this.People.Name = "People";
            this.People.Padding = new System.Windows.Forms.Padding(3);
            this.People.Size = new System.Drawing.Size(837, 702);
            this.People.TabIndex = 0;
            this.People.Text = "Employees";
            this.People.UseVisualStyleBackColor = true;
            // 
            // checkbox_fired
            // 
            this.checkbox_fired.AutoSize = true;
            this.checkbox_fired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_fired.Location = new System.Drawing.Point(380, 99);
            this.checkbox_fired.Margin = new System.Windows.Forms.Padding(2);
            this.checkbox_fired.Name = "checkbox_fired";
            this.checkbox_fired.Size = new System.Drawing.Size(60, 22);
            this.checkbox_fired.TabIndex = 19;
            this.checkbox_fired.Text = "Fired";
            this.checkbox_fired.UseVisualStyleBackColor = true;
            this.checkbox_fired.CheckedChanged += new System.EventHandler(this.checkbox_fired_CheckedChanged);
            // 
            // checkBox_active
            // 
            this.checkBox_active.AutoSize = true;
            this.checkBox_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_active.Location = new System.Drawing.Point(380, 66);
            this.checkBox_active.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_active.Name = "checkBox_active";
            this.checkBox_active.Size = new System.Drawing.Size(66, 22);
            this.checkBox_active.TabIndex = 18;
            this.checkBox_active.Text = "Active";
            this.checkBox_active.UseVisualStyleBackColor = true;
            this.checkBox_active.CheckedChanged += new System.EventHandler(this.checkBox_active_CheckedChanged);
            // 
            // btnViewEmployeeInfo
            // 
            this.btnViewEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmployeeInfo.Location = new System.Drawing.Point(206, 206);
            this.btnViewEmployeeInfo.Name = "btnViewEmployeeInfo";
            this.btnViewEmployeeInfo.Size = new System.Drawing.Size(122, 45);
            this.btnViewEmployeeInfo.TabIndex = 17;
            this.btnViewEmployeeInfo.Text = "Schedule shifts";
            this.btnViewEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnViewEmployeeInfo.Click += new System.EventHandler(this.btnViewEmployeeInfo_Click_1);
            // 
            // btnManagemendUpdate
            // 
            this.btnManagemendUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagemendUpdate.Location = new System.Drawing.Point(57, 206);
            this.btnManagemendUpdate.Name = "btnManagemendUpdate";
            this.btnManagemendUpdate.Size = new System.Drawing.Size(122, 45);
            this.btnManagemendUpdate.TabIndex = 16;
            this.btnManagemendUpdate.Text = "View all employees";
            this.btnManagemendUpdate.UseVisualStyleBackColor = true;
            // 
            // lbManagemendEmployees
            // 
            this.lbManagemendEmployees.FormattingEnabled = true;
            this.lbManagemendEmployees.Location = new System.Drawing.Point(447, 60);
            this.lbManagemendEmployees.Name = "lbManagemendEmployees";
            this.lbManagemendEmployees.Size = new System.Drawing.Size(311, 329);
            this.lbManagemendEmployees.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_allRoles);
            this.groupBox1.Controls.Add(this.radio_name);
            this.groupBox1.Controls.Add(this.radio_ID);
            this.groupBox1.Controls.Add(this.radio_role);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(42, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 128);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // cb_allRoles
            // 
            this.cb_allRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_allRoles.FormattingEnabled = true;
            this.cb_allRoles.Location = new System.Drawing.Point(65, 74);
            this.cb_allRoles.Margin = new System.Windows.Forms.Padding(2);
            this.cb_allRoles.Name = "cb_allRoles";
            this.cb_allRoles.Size = new System.Drawing.Size(170, 25);
            this.cb_allRoles.TabIndex = 8;
            this.cb_allRoles.SelectedIndexChanged += new System.EventHandler(this.cb_allRoles_SelectedIndexChanged);
            // 
            // radio_name
            // 
            this.radio_name.AutoSize = true;
            this.radio_name.Location = new System.Drawing.Point(218, 28);
            this.radio_name.Name = "radio_name";
            this.radio_name.Size = new System.Drawing.Size(63, 21);
            this.radio_name.TabIndex = 7;
            this.radio_name.TabStop = true;
            this.radio_name.Text = "Name";
            this.radio_name.UseVisualStyleBackColor = true;
            this.radio_name.CheckedChanged += new System.EventHandler(this.radio_name_CheckedChanged);
            // 
            // radio_ID
            // 
            this.radio_ID.AutoSize = true;
            this.radio_ID.Location = new System.Drawing.Point(28, 28);
            this.radio_ID.Name = "radio_ID";
            this.radio_ID.Size = new System.Drawing.Size(39, 21);
            this.radio_ID.TabIndex = 5;
            this.radio_ID.TabStop = true;
            this.radio_ID.Text = "ID";
            this.radio_ID.UseVisualStyleBackColor = true;
            this.radio_ID.CheckedChanged += new System.EventHandler(this.radio_ID_CheckedChanged);
            // 
            // radio_role
            // 
            this.radio_role.AutoSize = true;
            this.radio_role.Location = new System.Drawing.Point(117, 28);
            this.radio_role.Name = "radio_role";
            this.radio_role.Size = new System.Drawing.Size(55, 21);
            this.radio_role.TabIndex = 6;
            this.radio_role.TabStop = true;
            this.radio_role.Text = "Role";
            this.radio_role.UseVisualStyleBackColor = true;
            this.radio_role.CheckedChanged += new System.EventHandler(this.radio_role_CheckedChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(65, 76);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(170, 23);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
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
            // Stock
            // 
            this.Stock.Controls.Add(this.dataGridView1);
            this.Stock.Controls.Add(this.btnStockRemove);
            this.Stock.Controls.Add(this.btnManagementStockUpdate);
            this.Stock.Controls.Add(this.btnManagementNewStock);
            this.Stock.Controls.Add(this.btnManagementRestockRequest);
            this.Stock.Controls.Add(this.groupBox2);
            this.Stock.Location = new System.Drawing.Point(4, 22);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(3);
            this.Stock.Size = new System.Drawing.Size(837, 702);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
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
            // tbManagementStockFilter
            // 
            this.tbManagementStockFilter.Location = new System.Drawing.Point(74, 69);
            this.tbManagementStockFilter.Name = "tbManagementStockFilter";
            this.tbManagementStockFilter.Size = new System.Drawing.Size(100, 20);
            this.tbManagementStockFilter.TabIndex = 1;
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
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 740);
            this.Controls.Add(this.tabControl1);
            this.Name = "Management";
            this.Text = "Management";
            this.Load += new System.EventHandler(this.Management_Load);
            this.tabControl1.ResumeLayout(false);
            this.People.ResumeLayout(false);
            this.People.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvManagemendEmployees)).EndInit();
            this.Stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage People;
        private System.Windows.Forms.TabPage Stock;
        private System.Windows.Forms.Button btnManagementRestockRequest;
        private System.Windows.Forms.Button btnManagementStockFilter;
        private System.Windows.Forms.TextBox tbManagementStockFilter;
        private System.Windows.Forms.RadioButton rbManagementStockAmountFilter;
        private System.Windows.Forms.RadioButton rbManagementStockBrandFilter;
        private System.Windows.Forms.RadioButton rbManagementStockIDFilter;
        private System.Windows.Forms.Button btnManagementNewStock;
        private System.Windows.Forms.Button btnManagementStockUpdate;
        private System.Windows.Forms.Button btnStockRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView DgvManagemendEmployees;
        private System.Windows.Forms.CheckBox checkbox_fired;
        private System.Windows.Forms.CheckBox checkBox_active;
        private System.Windows.Forms.Button btnViewEmployeeInfo;
        private System.Windows.Forms.Button btnManagemendUpdate;
        private System.Windows.Forms.ListBox lbManagemendEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_allRoles;
        private System.Windows.Forms.RadioButton radio_name;
        private System.Windows.Forms.RadioButton radio_ID;
        private System.Windows.Forms.RadioButton radio_role;
        private System.Windows.Forms.TextBox txt_search;
    }
}