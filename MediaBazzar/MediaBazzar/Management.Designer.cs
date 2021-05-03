
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShifts = new System.Windows.Forms.Button();
            this.checkbox_fired = new System.Windows.Forms.CheckBox();
            this.checkBox_active = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_allRoles = new System.Windows.Forms.ComboBox();
            this.radio_name = new System.Windows.Forms.RadioButton();
            this.radio_ID = new System.Windows.Forms.RadioButton();
            this.radio_role = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.dataGrid_employees = new System.Windows.Forms.DataGridView();
            this.Stock = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStockRemove = new System.Windows.Forms.Button();
            this.btnManagementStockUpdate = new System.Windows.Forms.Button();
            this.btnManagementRestockRequest = new System.Windows.Forms.Button();
            this.btnManagementNewStock = new System.Windows.Forms.Button();
            this.dataGrid_stocks = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbManagementStockBrandFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockIDFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockAmountFilter = new System.Windows.Forms.RadioButton();
            this.tbManagementStockFilter = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.People.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_employees)).BeginInit();
            this.Stock.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_stocks)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.People);
            this.tabControl1.Controls.Add(this.Stock);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1127, 896);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // People
            // 
            this.People.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.People.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.People.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.People.Controls.Add(this.panel2);
            this.People.Controls.Add(this.checkbox_fired);
            this.People.Controls.Add(this.checkBox_active);
            this.People.Controls.Add(this.groupBox1);
            this.People.Controls.Add(this.dataGrid_employees);
            this.People.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.People.Location = new System.Drawing.Point(4, 30);
            this.People.Margin = new System.Windows.Forms.Padding(4);
            this.People.Name = "People";
            this.People.Padding = new System.Windows.Forms.Padding(4);
            this.People.Size = new System.Drawing.Size(1119, 862);
            this.People.TabIndex = 0;
            this.People.Text = "Employees";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.Controls.Add(this.btnShifts);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 852);
            this.panel2.TabIndex = 21;
            // 
            // btnShifts
            // 
            this.btnShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShifts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShifts.Location = new System.Drawing.Point(-11, 151);
            this.btnShifts.Margin = new System.Windows.Forms.Padding(4);
            this.btnShifts.Name = "btnShifts";
            this.btnShifts.Size = new System.Drawing.Size(217, 69);
            this.btnShifts.TabIndex = 20;
            this.btnShifts.Text = "Schedule shifts";
            this.btnShifts.UseVisualStyleBackColor = false;
            this.btnShifts.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkbox_fired
            // 
            this.checkbox_fired.AutoSize = true;
            this.checkbox_fired.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_fired.Location = new System.Drawing.Point(840, 165);
            this.checkbox_fired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkbox_fired.Name = "checkbox_fired";
            this.checkbox_fired.Size = new System.Drawing.Size(75, 26);
            this.checkbox_fired.TabIndex = 19;
            this.checkbox_fired.Text = "Fired";
            this.checkbox_fired.UseVisualStyleBackColor = true;
            this.checkbox_fired.CheckedChanged += new System.EventHandler(this.checkbox_fired_CheckedChanged);
            // 
            // checkBox_active
            // 
            this.checkBox_active.AutoSize = true;
            this.checkBox_active.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_active.Location = new System.Drawing.Point(840, 124);
            this.checkBox_active.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_active.Name = "checkBox_active";
            this.checkBox_active.Size = new System.Drawing.Size(94, 26);
            this.checkBox_active.TabIndex = 18;
            this.checkBox_active.Text = "Active";
            this.checkBox_active.UseVisualStyleBackColor = true;
            this.checkBox_active.CheckedChanged += new System.EventHandler(this.checkBox_active_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_allRoles);
            this.groupBox1.Controls.Add(this.radio_name);
            this.groupBox1.Controls.Add(this.radio_ID);
            this.groupBox1.Controls.Add(this.radio_role);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(399, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(559, 193);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // cb_allRoles
            // 
            this.cb_allRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_allRoles.FormattingEnabled = true;
            this.cb_allRoles.Location = new System.Drawing.Point(85, 101);
            this.cb_allRoles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_allRoles.Name = "cb_allRoles";
            this.cb_allRoles.Size = new System.Drawing.Size(225, 30);
            this.cb_allRoles.TabIndex = 8;
            this.cb_allRoles.SelectedIndexChanged += new System.EventHandler(this.cb_allRoles_SelectedIndexChanged);
            // 
            // radio_name
            // 
            this.radio_name.AutoSize = true;
            this.radio_name.Location = new System.Drawing.Point(291, 34);
            this.radio_name.Margin = new System.Windows.Forms.Padding(4);
            this.radio_name.Name = "radio_name";
            this.radio_name.Size = new System.Drawing.Size(87, 26);
            this.radio_name.TabIndex = 7;
            this.radio_name.TabStop = true;
            this.radio_name.Text = "Name";
            this.radio_name.UseVisualStyleBackColor = true;
            this.radio_name.CheckedChanged += new System.EventHandler(this.radio_name_CheckedChanged);
            // 
            // radio_ID
            // 
            this.radio_ID.AutoSize = true;
            this.radio_ID.Location = new System.Drawing.Point(37, 34);
            this.radio_ID.Margin = new System.Windows.Forms.Padding(4);
            this.radio_ID.Name = "radio_ID";
            this.radio_ID.Size = new System.Drawing.Size(50, 26);
            this.radio_ID.TabIndex = 5;
            this.radio_ID.TabStop = true;
            this.radio_ID.Text = "ID";
            this.radio_ID.UseVisualStyleBackColor = true;
            this.radio_ID.CheckedChanged += new System.EventHandler(this.radio_ID_CheckedChanged);
            // 
            // radio_role
            // 
            this.radio_role.AutoSize = true;
            this.radio_role.Location = new System.Drawing.Point(156, 34);
            this.radio_role.Margin = new System.Windows.Forms.Padding(4);
            this.radio_role.Name = "radio_role";
            this.radio_role.Size = new System.Drawing.Size(70, 26);
            this.radio_role.TabIndex = 6;
            this.radio_role.TabStop = true;
            this.radio_role.Text = "Role";
            this.radio_role.UseVisualStyleBackColor = true;
            this.radio_role.CheckedChanged += new System.EventHandler(this.radio_role_CheckedChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(85, 103);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(225, 30);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // dataGrid_employees
            // 
            this.dataGrid_employees.AllowUserToAddRows = false;
            this.dataGrid_employees.AllowUserToDeleteRows = false;
            this.dataGrid_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_employees.Location = new System.Drawing.Point(196, 384);
            this.dataGrid_employees.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_employees.Name = "dataGrid_employees";
            this.dataGrid_employees.ReadOnly = true;
            this.dataGrid_employees.RowHeadersWidth = 51;
            this.dataGrid_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_employees.Size = new System.Drawing.Size(604, 305);
            this.dataGrid_employees.TabIndex = 11;
            // 
            // Stock
            // 
            this.Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Stock.Controls.Add(this.panel1);
            this.Stock.Controls.Add(this.dataGrid_stocks);
            this.Stock.Controls.Add(this.groupBox2);
            this.Stock.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Stock.Location = new System.Drawing.Point(4, 30);
            this.Stock.Margin = new System.Windows.Forms.Padding(4);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(4);
            this.Stock.Size = new System.Drawing.Size(1119, 862);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btnStockRemove);
            this.panel1.Controls.Add(this.btnManagementStockUpdate);
            this.panel1.Controls.Add(this.btnManagementRestockRequest);
            this.panel1.Controls.Add(this.btnManagementNewStock);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 852);
            this.panel1.TabIndex = 14;
            // 
            // btnStockRemove
            // 
            this.btnStockRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnStockRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockRemove.Location = new System.Drawing.Point(-4, 251);
            this.btnStockRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockRemove.Name = "btnStockRemove";
            this.btnStockRemove.Size = new System.Drawing.Size(212, 65);
            this.btnStockRemove.TabIndex = 11;
            this.btnStockRemove.Text = "Remove stock from inventory";
            this.btnStockRemove.UseVisualStyleBackColor = false;
            this.btnStockRemove.Click += new System.EventHandler(this.btnStockRemove_Click);
            // 
            // btnManagementStockUpdate
            // 
            this.btnManagementStockUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnManagementStockUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementStockUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementStockUpdate.Location = new System.Drawing.Point(-9, 139);
            this.btnManagementStockUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementStockUpdate.Name = "btnManagementStockUpdate";
            this.btnManagementStockUpdate.Size = new System.Drawing.Size(217, 69);
            this.btnManagementStockUpdate.TabIndex = 9;
            this.btnManagementStockUpdate.Text = "View store inventory";
            this.btnManagementStockUpdate.UseVisualStyleBackColor = false;
            this.btnManagementStockUpdate.Click += new System.EventHandler(this.btnManagementStockUpdate_Click_1);
            // 
            // btnManagementRestockRequest
            // 
            this.btnManagementRestockRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnManagementRestockRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementRestockRequest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementRestockRequest.Location = new System.Drawing.Point(-4, 459);
            this.btnManagementRestockRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementRestockRequest.Name = "btnManagementRestockRequest";
            this.btnManagementRestockRequest.Size = new System.Drawing.Size(212, 69);
            this.btnManagementRestockRequest.TabIndex = 4;
            this.btnManagementRestockRequest.Text = "Make new restock request";
            this.btnManagementRestockRequest.UseVisualStyleBackColor = false;
            this.btnManagementRestockRequest.Click += new System.EventHandler(this.btnManagementRestockRequest_Click);
            // 
            // btnManagementNewStock
            // 
            this.btnManagementNewStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnManagementNewStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementNewStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementNewStock.Location = new System.Drawing.Point(-4, 352);
            this.btnManagementNewStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementNewStock.Name = "btnManagementNewStock";
            this.btnManagementNewStock.Size = new System.Drawing.Size(212, 69);
            this.btnManagementNewStock.TabIndex = 8;
            this.btnManagementNewStock.Text = "Add new stock to inventory";
            this.btnManagementNewStock.UseVisualStyleBackColor = false;
            this.btnManagementNewStock.Click += new System.EventHandler(this.btnManagementNewStock_Click);
            // 
            // dataGrid_stocks
            // 
            this.dataGrid_stocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGrid_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_stocks.Location = new System.Drawing.Point(283, 287);
            this.dataGrid_stocks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGrid_stocks.Name = "dataGrid_stocks";
            this.dataGrid_stocks.RowHeadersWidth = 51;
            this.dataGrid_stocks.RowTemplate.Height = 24;
            this.dataGrid_stocks.Size = new System.Drawing.Size(689, 311);
            this.dataGrid_stocks.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbManagementStockBrandFilter);
            this.groupBox2.Controls.Add(this.rbManagementStockIDFilter);
            this.groupBox2.Controls.Add(this.rbManagementStockAmountFilter);
            this.groupBox2.Controls.Add(this.tbManagementStockFilter);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(457, 41);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(385, 186);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // rbManagementStockBrandFilter
            // 
            this.rbManagementStockBrandFilter.AutoSize = true;
            this.rbManagementStockBrandFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManagementStockBrandFilter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbManagementStockBrandFilter.Location = new System.Drawing.Point(131, 36);
            this.rbManagementStockBrandFilter.Margin = new System.Windows.Forms.Padding(4);
            this.rbManagementStockBrandFilter.Name = "rbManagementStockBrandFilter";
            this.rbManagementStockBrandFilter.Size = new System.Drawing.Size(88, 27);
            this.rbManagementStockBrandFilter.TabIndex = 6;
            this.rbManagementStockBrandFilter.TabStop = true;
            this.rbManagementStockBrandFilter.Text = "Brand";
            this.rbManagementStockBrandFilter.UseVisualStyleBackColor = true;
            this.rbManagementStockBrandFilter.CheckedChanged += new System.EventHandler(this.rbManagementStockBrandFilter_CheckedChanged);
            // 
            // rbManagementStockIDFilter
            // 
            this.rbManagementStockIDFilter.AutoSize = true;
            this.rbManagementStockIDFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManagementStockIDFilter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbManagementStockIDFilter.Location = new System.Drawing.Point(8, 36);
            this.rbManagementStockIDFilter.Margin = new System.Windows.Forms.Padding(4);
            this.rbManagementStockIDFilter.Name = "rbManagementStockIDFilter";
            this.rbManagementStockIDFilter.Size = new System.Drawing.Size(51, 27);
            this.rbManagementStockIDFilter.TabIndex = 5;
            this.rbManagementStockIDFilter.TabStop = true;
            this.rbManagementStockIDFilter.Text = "ID";
            this.rbManagementStockIDFilter.UseVisualStyleBackColor = true;
            this.rbManagementStockIDFilter.CheckedChanged += new System.EventHandler(this.rbManagementStockIDFilter_CheckedChanged);
            // 
            // rbManagementStockAmountFilter
            // 
            this.rbManagementStockAmountFilter.AutoSize = true;
            this.rbManagementStockAmountFilter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbManagementStockAmountFilter.ForeColor = System.Drawing.SystemColors.Control;
            this.rbManagementStockAmountFilter.Location = new System.Drawing.Point(249, 36);
            this.rbManagementStockAmountFilter.Margin = new System.Windows.Forms.Padding(4);
            this.rbManagementStockAmountFilter.Name = "rbManagementStockAmountFilter";
            this.rbManagementStockAmountFilter.Size = new System.Drawing.Size(109, 27);
            this.rbManagementStockAmountFilter.TabIndex = 7;
            this.rbManagementStockAmountFilter.TabStop = true;
            this.rbManagementStockAmountFilter.Text = "Amount";
            this.rbManagementStockAmountFilter.UseVisualStyleBackColor = true;
            this.rbManagementStockAmountFilter.CheckedChanged += new System.EventHandler(this.rbManagementStockAmountFilter_CheckedChanged);
            // 
            // tbManagementStockFilter
            // 
            this.tbManagementStockFilter.Location = new System.Drawing.Point(117, 85);
            this.tbManagementStockFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbManagementStockFilter.Name = "tbManagementStockFilter";
            this.tbManagementStockFilter.Size = new System.Drawing.Size(132, 26);
            this.tbManagementStockFilter.TabIndex = 1;
            this.tbManagementStockFilter.TextChanged += new System.EventHandler(this.tbManagementStockFilter_TextChanged);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 700);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Management";
            this.Text = "Management";
            this.tabControl1.ResumeLayout(false);
            this.People.ResumeLayout(false);
            this.People.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_employees)).EndInit();
            this.Stock.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_stocks)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage People;
        private System.Windows.Forms.TabPage Stock;
        private System.Windows.Forms.Button btnManagementRestockRequest;
        private System.Windows.Forms.TextBox tbManagementStockFilter;
        private System.Windows.Forms.RadioButton rbManagementStockAmountFilter;
        private System.Windows.Forms.RadioButton rbManagementStockBrandFilter;
        private System.Windows.Forms.RadioButton rbManagementStockIDFilter;
        private System.Windows.Forms.Button btnManagementNewStock;
        private System.Windows.Forms.Button btnManagementStockUpdate;
        private System.Windows.Forms.Button btnStockRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGrid_stocks;
        private System.Windows.Forms.DataGridView dataGrid_employees;
        private System.Windows.Forms.CheckBox checkbox_fired;
        private System.Windows.Forms.CheckBox checkBox_active;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_allRoles;
        private System.Windows.Forms.RadioButton radio_name;
        private System.Windows.Forms.RadioButton radio_ID;
        private System.Windows.Forms.RadioButton radio_role;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShifts;
        private System.Windows.Forms.Panel panel2;
    }
}