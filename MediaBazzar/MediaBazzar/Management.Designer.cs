
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
            this.btnViewEmployeeInfo = new System.Windows.Forms.Button();
            this.btnManagemendUpdate = new System.Windows.Forms.Button();
            this.lbManagemendEmployees = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_allRoles = new System.Windows.Forms.ComboBox();
            this.radio_name = new System.Windows.Forms.RadioButton();
            this.radio_ID = new System.Windows.Forms.RadioButton();
            this.radio_role = new System.Windows.Forms.RadioButton();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.Stock = new System.Windows.Forms.TabPage();
            this.btnStockRemove = new System.Windows.Forms.Button();
            this.btnManagementStockUpdate = new System.Windows.Forms.Button();
            this.btnManagementNewStock = new System.Windows.Forms.Button();
            this.btnManagementRestockRequest = new System.Windows.Forms.Button();
            this.lbManagementStock = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbManagementStockBrandFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockIDFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockAmountFilter = new System.Windows.Forms.RadioButton();
            this.tbManagementStockFilter = new System.Windows.Forms.TextBox();
            this.btnManagementStockFilter = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnManagementShiftAssignEmployee = new System.Windows.Forms.Button();
            this.lbManagementShiftEmployeesAssigned = new System.Windows.Forms.ListBox();
            this.lbManagementShiftEmployeesToAssign = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.checkBox_active = new System.Windows.Forms.CheckBox();
            this.checkbox_fired = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.People.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Stock.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.People);
            this.tabControl1.Controls.Add(this.Stock);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 502);
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
            this.People.Location = new System.Drawing.Point(4, 25);
            this.People.Margin = new System.Windows.Forms.Padding(4);
            this.People.Name = "People";
            this.People.Padding = new System.Windows.Forms.Padding(4);
            this.People.Size = new System.Drawing.Size(1041, 473);
            this.People.TabIndex = 0;
            this.People.Text = "Employees";
            this.People.UseVisualStyleBackColor = true;
            // 
            // btnViewEmployeeInfo
            // 
            this.btnViewEmployeeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEmployeeInfo.Location = new System.Drawing.Point(251, 206);
            this.btnViewEmployeeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewEmployeeInfo.Name = "btnViewEmployeeInfo";
            this.btnViewEmployeeInfo.Size = new System.Drawing.Size(162, 55);
            this.btnViewEmployeeInfo.TabIndex = 10;
            this.btnViewEmployeeInfo.Text = "View employee info";
            this.btnViewEmployeeInfo.UseVisualStyleBackColor = true;
            this.btnViewEmployeeInfo.Click += new System.EventHandler(this.btnViewEmployeeInfo_Click);
            // 
            // btnManagemendUpdate
            // 
            this.btnManagemendUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagemendUpdate.Location = new System.Drawing.Point(52, 206);
            this.btnManagemendUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagemendUpdate.Name = "btnManagemendUpdate";
            this.btnManagemendUpdate.Size = new System.Drawing.Size(162, 55);
            this.btnManagemendUpdate.TabIndex = 9;
            this.btnManagemendUpdate.Text = "View all employees";
            this.btnManagemendUpdate.UseVisualStyleBackColor = true;
            this.btnManagemendUpdate.Click += new System.EventHandler(this.btnManagemendUpdate_Click);
            // 
            // lbManagemendEmployees
            // 
            this.lbManagemendEmployees.FormattingEnabled = true;
            this.lbManagemendEmployees.ItemHeight = 16;
            this.lbManagemendEmployees.Location = new System.Drawing.Point(572, 26);
            this.lbManagemendEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.lbManagemendEmployees.Name = "lbManagemendEmployees";
            this.lbManagemendEmployees.Size = new System.Drawing.Size(413, 404);
            this.lbManagemendEmployees.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_allRoles);
            this.groupBox1.Controls.Add(this.radio_name);
            this.groupBox1.Controls.Add(this.radio_ID);
            this.groupBox1.Controls.Add(this.radio_role);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(401, 157);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by";
            // 
            // cb_allRoles
            // 
            this.cb_allRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_allRoles.FormattingEnabled = true;
            this.cb_allRoles.Location = new System.Drawing.Point(87, 94);
            this.cb_allRoles.Name = "cb_allRoles";
            this.cb_allRoles.Size = new System.Drawing.Size(226, 28);
            this.cb_allRoles.TabIndex = 8;
            this.cb_allRoles.SelectedIndexChanged += new System.EventHandler(this.cb_allRoles_SelectedIndexChanged);
            // 
            // radio_name
            // 
            this.radio_name.AutoSize = true;
            this.radio_name.Location = new System.Drawing.Point(291, 34);
            this.radio_name.Margin = new System.Windows.Forms.Padding(4);
            this.radio_name.Name = "radio_name";
            this.radio_name.Size = new System.Drawing.Size(74, 24);
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
            this.radio_ID.Size = new System.Drawing.Size(47, 24);
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
            this.radio_role.Size = new System.Drawing.Size(64, 24);
            this.radio_role.TabIndex = 6;
            this.radio_role.TabStop = true;
            this.radio_role.Text = "Role";
            this.radio_role.UseVisualStyleBackColor = true;
            this.radio_role.CheckedChanged += new System.EventHandler(this.radio_role_CheckedChanged);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(87, 94);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(226, 27);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // Stock
            // 
            this.Stock.Controls.Add(this.btnStockRemove);
            this.Stock.Controls.Add(this.btnManagementStockUpdate);
            this.Stock.Controls.Add(this.btnManagementNewStock);
            this.Stock.Controls.Add(this.btnManagementRestockRequest);
            this.Stock.Controls.Add(this.lbManagementStock);
            this.Stock.Controls.Add(this.groupBox2);
            this.Stock.Location = new System.Drawing.Point(4, 25);
            this.Stock.Margin = new System.Windows.Forms.Padding(4);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(4);
            this.Stock.Size = new System.Drawing.Size(1041, 473);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // btnStockRemove
            // 
            this.btnStockRemove.Location = new System.Drawing.Point(105, 294);
            this.btnStockRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnStockRemove.Name = "btnStockRemove";
            this.btnStockRemove.Size = new System.Drawing.Size(268, 39);
            this.btnStockRemove.TabIndex = 11;
            this.btnStockRemove.Text = "Remove stock from inventory";
            this.btnStockRemove.UseVisualStyleBackColor = true;
            this.btnStockRemove.Click += new System.EventHandler(this.btnStockRemove_Click);
            // 
            // btnManagementStockUpdate
            // 
            this.btnManagementStockUpdate.Location = new System.Drawing.Point(155, 247);
            this.btnManagementStockUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementStockUpdate.Name = "btnManagementStockUpdate";
            this.btnManagementStockUpdate.Size = new System.Drawing.Size(179, 39);
            this.btnManagementStockUpdate.TabIndex = 9;
            this.btnManagementStockUpdate.Text = "View store inventory";
            this.btnManagementStockUpdate.UseVisualStyleBackColor = true;
            this.btnManagementStockUpdate.Click += new System.EventHandler(this.btnManagementStockUpdate_Click_1);
            // 
            // btnManagementNewStock
            // 
            this.btnManagementNewStock.Location = new System.Drawing.Point(105, 388);
            this.btnManagementNewStock.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementNewStock.Name = "btnManagementNewStock";
            this.btnManagementNewStock.Size = new System.Drawing.Size(268, 54);
            this.btnManagementNewStock.TabIndex = 8;
            this.btnManagementNewStock.Text = "Request new stock to be added to inventory";
            this.btnManagementNewStock.UseVisualStyleBackColor = true;
            this.btnManagementNewStock.Click += new System.EventHandler(this.btnManagementNewStock_Click);
            // 
            // btnManagementRestockRequest
            // 
            this.btnManagementRestockRequest.Location = new System.Drawing.Point(81, 341);
            this.btnManagementRestockRequest.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementRestockRequest.Name = "btnManagementRestockRequest";
            this.btnManagementRestockRequest.Size = new System.Drawing.Size(323, 39);
            this.btnManagementRestockRequest.TabIndex = 4;
            this.btnManagementRestockRequest.Text = "[IN DEVELOPMENT]Make new restock request";
            this.btnManagementRestockRequest.UseVisualStyleBackColor = true;
            this.btnManagementRestockRequest.Click += new System.EventHandler(this.btnManagementRestockRequest_Click);
            // 
            // lbManagementStock
            // 
            this.lbManagementStock.FormattingEnabled = true;
            this.lbManagementStock.ItemHeight = 16;
            this.lbManagementStock.Location = new System.Drawing.Point(467, 32);
            this.lbManagementStock.Margin = new System.Windows.Forms.Padding(4);
            this.lbManagementStock.Name = "lbManagementStock";
            this.lbManagementStock.Size = new System.Drawing.Size(504, 420);
            this.lbManagementStock.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbManagementStockBrandFilter);
            this.groupBox2.Controls.Add(this.rbManagementStockIDFilter);
            this.groupBox2.Controls.Add(this.rbManagementStockAmountFilter);
            this.groupBox2.Controls.Add(this.tbManagementStockFilter);
            this.groupBox2.Controls.Add(this.btnManagementStockFilter);
            this.groupBox2.Location = new System.Drawing.Point(73, 50);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(368, 177);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // rbManagementStockBrandFilter
            // 
            this.rbManagementStockBrandFilter.AutoSize = true;
            this.rbManagementStockBrandFilter.Location = new System.Drawing.Point(131, 36);
            this.rbManagementStockBrandFilter.Margin = new System.Windows.Forms.Padding(4);
            this.rbManagementStockBrandFilter.Name = "rbManagementStockBrandFilter";
            this.rbManagementStockBrandFilter.Size = new System.Drawing.Size(67, 21);
            this.rbManagementStockBrandFilter.TabIndex = 6;
            this.rbManagementStockBrandFilter.TabStop = true;
            this.rbManagementStockBrandFilter.Text = "Brand";
            this.rbManagementStockBrandFilter.UseVisualStyleBackColor = true;
            // 
            // rbManagementStockIDFilter
            // 
            this.rbManagementStockIDFilter.AutoSize = true;
            this.rbManagementStockIDFilter.Location = new System.Drawing.Point(8, 36);
            this.rbManagementStockIDFilter.Margin = new System.Windows.Forms.Padding(4);
            this.rbManagementStockIDFilter.Name = "rbManagementStockIDFilter";
            this.rbManagementStockIDFilter.Size = new System.Drawing.Size(42, 21);
            this.rbManagementStockIDFilter.TabIndex = 5;
            this.rbManagementStockIDFilter.TabStop = true;
            this.rbManagementStockIDFilter.Text = "ID";
            this.rbManagementStockIDFilter.UseVisualStyleBackColor = true;
            // 
            // rbManagementStockAmountFilter
            // 
            this.rbManagementStockAmountFilter.AutoSize = true;
            this.rbManagementStockAmountFilter.Location = new System.Drawing.Point(249, 36);
            this.rbManagementStockAmountFilter.Margin = new System.Windows.Forms.Padding(4);
            this.rbManagementStockAmountFilter.Name = "rbManagementStockAmountFilter";
            this.rbManagementStockAmountFilter.Size = new System.Drawing.Size(77, 21);
            this.rbManagementStockAmountFilter.TabIndex = 7;
            this.rbManagementStockAmountFilter.TabStop = true;
            this.rbManagementStockAmountFilter.Text = "Amount";
            this.rbManagementStockAmountFilter.UseVisualStyleBackColor = true;
            // 
            // tbManagementStockFilter
            // 
            this.tbManagementStockFilter.Location = new System.Drawing.Point(99, 85);
            this.tbManagementStockFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbManagementStockFilter.Name = "tbManagementStockFilter";
            this.tbManagementStockFilter.Size = new System.Drawing.Size(132, 22);
            this.tbManagementStockFilter.TabIndex = 1;
            // 
            // btnManagementStockFilter
            // 
            this.btnManagementStockFilter.Location = new System.Drawing.Point(117, 117);
            this.btnManagementStockFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementStockFilter.Name = "btnManagementStockFilter";
            this.btnManagementStockFilter.Size = new System.Drawing.Size(100, 39);
            this.btnManagementStockFilter.TabIndex = 3;
            this.btnManagementStockFilter.Text = "Filter";
            this.btnManagementStockFilter.UseVisualStyleBackColor = true;
            this.btnManagementStockFilter.Click += new System.EventHandler(this.btnManagementStockFilter_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnManagementShiftAssignEmployee);
            this.tabPage1.Controls.Add(this.lbManagementShiftEmployeesAssigned);
            this.tabPage1.Controls.Add(this.lbManagementShiftEmployeesToAssign);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1041, 473);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Shifts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnManagementShiftAssignEmployee
            // 
            this.btnManagementShiftAssignEmployee.Location = new System.Drawing.Point(655, 375);
            this.btnManagementShiftAssignEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnManagementShiftAssignEmployee.Name = "btnManagementShiftAssignEmployee";
            this.btnManagementShiftAssignEmployee.Size = new System.Drawing.Size(313, 44);
            this.btnManagementShiftAssignEmployee.TabIndex = 1;
            this.btnManagementShiftAssignEmployee.Text = "[IN DEVELOPMENT]AssignEmployeeToShift";
            this.btnManagementShiftAssignEmployee.UseVisualStyleBackColor = true;
            // 
            // lbManagementShiftEmployeesAssigned
            // 
            this.lbManagementShiftEmployeesAssigned.FormattingEnabled = true;
            this.lbManagementShiftEmployeesAssigned.ItemHeight = 16;
            this.lbManagementShiftEmployeesAssigned.Location = new System.Drawing.Point(700, 11);
            this.lbManagementShiftEmployeesAssigned.Margin = new System.Windows.Forms.Padding(4);
            this.lbManagementShiftEmployeesAssigned.Name = "lbManagementShiftEmployeesAssigned";
            this.lbManagementShiftEmployeesAssigned.Size = new System.Drawing.Size(320, 356);
            this.lbManagementShiftEmployeesAssigned.TabIndex = 2;
            // 
            // lbManagementShiftEmployeesToAssign
            // 
            this.lbManagementShiftEmployeesToAssign.FormattingEnabled = true;
            this.lbManagementShiftEmployeesToAssign.ItemHeight = 16;
            this.lbManagementShiftEmployeesToAssign.Location = new System.Drawing.Point(349, 11);
            this.lbManagementShiftEmployeesToAssign.Margin = new System.Windows.Forms.Padding(4);
            this.lbManagementShiftEmployeesToAssign.Name = "lbManagementShiftEmployeesToAssign";
            this.lbManagementShiftEmployeesToAssign.Size = new System.Drawing.Size(320, 356);
            this.lbManagementShiftEmployeesToAssign.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(19, 11);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // checkBox_active
            // 
            this.checkBox_active.AutoSize = true;
            this.checkBox_active.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_active.Location = new System.Drawing.Point(482, 33);
            this.checkBox_active.Name = "checkBox_active";
            this.checkBox_active.Size = new System.Drawing.Size(83, 28);
            this.checkBox_active.TabIndex = 12;
            this.checkBox_active.Text = "Active";
            this.checkBox_active.UseVisualStyleBackColor = true;
            this.checkBox_active.CheckedChanged += new System.EventHandler(this.checkBox_active_CheckedChanged);
            // 
            // checkbox_fired
            // 
            this.checkbox_fired.AutoSize = true;
            this.checkbox_fired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbox_fired.Location = new System.Drawing.Point(483, 74);
            this.checkbox_fired.Name = "checkbox_fired";
            this.checkbox_fired.Size = new System.Drawing.Size(76, 28);
            this.checkbox_fired.TabIndex = 13;
            this.checkbox_fired.Text = "Fired";
            this.checkbox_fired.UseVisualStyleBackColor = true;
            this.checkbox_fired.CheckedChanged += new System.EventHandler(this.checkbox_fired_CheckedChanged);
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 492);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Management";
            this.Text = "Management";
            this.tabControl1.ResumeLayout(false);
            this.People.ResumeLayout(false);
            this.People.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Stock.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage People;
        private System.Windows.Forms.TabPage Stock;
        private System.Windows.Forms.ListBox lbManagemendEmployees;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btnManagementRestockRequest;
        private System.Windows.Forms.Button btnManagementStockFilter;
        private System.Windows.Forms.TextBox tbManagementStockFilter;
        private System.Windows.Forms.ListBox lbManagementStock;
        private System.Windows.Forms.RadioButton rbManagementStockAmountFilter;
        private System.Windows.Forms.RadioButton rbManagementStockBrandFilter;
        private System.Windows.Forms.RadioButton rbManagementStockIDFilter;
        private System.Windows.Forms.Button btnManagementShiftAssignEmployee;
        private System.Windows.Forms.ListBox lbManagementShiftEmployeesAssigned;
        private System.Windows.Forms.ListBox lbManagementShiftEmployeesToAssign;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnManagementNewStock;
        private System.Windows.Forms.Button btnManagementStockUpdate;
        private System.Windows.Forms.RadioButton radio_role;
        private System.Windows.Forms.RadioButton radio_ID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManagemendUpdate;
        private System.Windows.Forms.Button btnViewEmployeeInfo;
        private System.Windows.Forms.Button btnStockRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radio_name;
        private System.Windows.Forms.ComboBox cb_allRoles;
        private System.Windows.Forms.CheckBox checkbox_fired;
        private System.Windows.Forms.CheckBox checkBox_active;
    }
}