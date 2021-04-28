
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
            this.btnManagemntPersonUpdate = new System.Windows.Forms.Button();
            this.btnManagemntPersonCreation = new System.Windows.Forms.Button();
            this.lbManagemendEmployees = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnManagementEPFilter = new System.Windows.Forms.Button();
            this.rbManagementID = new System.Windows.Forms.RadioButton();
            this.rbManagementRole = new System.Windows.Forms.RadioButton();
            this.tbManagementEPFilter = new System.Windows.Forms.TextBox();
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
            this.cbShiftType = new System.Windows.Forms.ComboBox();
            this.btnManagementShiftAssignEmployee = new System.Windows.Forms.Button();
            this.lbManagementShiftEmployeesAssigned = new System.Windows.Forms.ListBox();
            this.lbManagementShiftEmployeesToAssign = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // People
            // 
            this.People.Controls.Add(this.btnViewEmployeeInfo);
            this.People.Controls.Add(this.btnManagemendUpdate);
            this.People.Controls.Add(this.btnManagemntPersonUpdate);
            this.People.Controls.Add(this.btnManagemntPersonCreation);
            this.People.Controls.Add(this.lbManagemendEmployees);
            this.People.Controls.Add(this.groupBox1);
            this.People.Location = new System.Drawing.Point(4, 22);
            this.People.Name = "People";
            this.People.Padding = new System.Windows.Forms.Padding(3);
            this.People.Size = new System.Drawing.Size(779, 382);
            this.People.TabIndex = 0;
            this.People.Text = "Employees";
            this.People.UseVisualStyleBackColor = true;
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
            // lbManagemendEmployees
            // 
            this.lbManagemendEmployees.FormattingEnabled = true;
            this.lbManagemendEmployees.Location = new System.Drawing.Point(364, 20);
            this.lbManagemendEmployees.Name = "lbManagemendEmployees";
            this.lbManagemendEmployees.Size = new System.Drawing.Size(311, 329);
            this.lbManagemendEmployees.TabIndex = 0;
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
            // tbManagementEPFilter
            // 
            this.tbManagementEPFilter.Location = new System.Drawing.Point(44, 75);
            this.tbManagementEPFilter.Name = "tbManagementEPFilter";
            this.tbManagementEPFilter.Size = new System.Drawing.Size(157, 20);
            this.tbManagementEPFilter.TabIndex = 3;
            // 
            // Stock
            // 
            this.Stock.Controls.Add(this.btnStockRemove);
            this.Stock.Controls.Add(this.btnManagementStockUpdate);
            this.Stock.Controls.Add(this.btnManagementNewStock);
            this.Stock.Controls.Add(this.btnManagementRestockRequest);
            this.Stock.Controls.Add(this.lbManagementStock);
            this.Stock.Controls.Add(this.groupBox2);
            this.Stock.Location = new System.Drawing.Point(4, 22);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(3);
            this.Stock.Size = new System.Drawing.Size(779, 382);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // btnStockRemove
            // 
            this.btnStockRemove.Location = new System.Drawing.Point(79, 239);
            this.btnStockRemove.Name = "btnStockRemove";
            this.btnStockRemove.Size = new System.Drawing.Size(201, 32);
            this.btnStockRemove.TabIndex = 11;
            this.btnStockRemove.Text = "Remove stock from inventory";
            this.btnStockRemove.UseVisualStyleBackColor = true;
            this.btnStockRemove.Click += new System.EventHandler(this.btnStockRemove_Click);
            // 
            // btnManagementStockUpdate
            // 
            this.btnManagementStockUpdate.Location = new System.Drawing.Point(116, 201);
            this.btnManagementStockUpdate.Name = "btnManagementStockUpdate";
            this.btnManagementStockUpdate.Size = new System.Drawing.Size(134, 32);
            this.btnManagementStockUpdate.TabIndex = 9;
            this.btnManagementStockUpdate.Text = "View store inventory";
            this.btnManagementStockUpdate.UseVisualStyleBackColor = true;
            this.btnManagementStockUpdate.Click += new System.EventHandler(this.btnManagementStockUpdate_Click_1);
            // 
            // btnManagementNewStock
            // 
            this.btnManagementNewStock.Location = new System.Drawing.Point(79, 315);
            this.btnManagementNewStock.Name = "btnManagementNewStock";
            this.btnManagementNewStock.Size = new System.Drawing.Size(201, 44);
            this.btnManagementNewStock.TabIndex = 8;
            this.btnManagementNewStock.Text = "Request new stock to be added to inventory";
            this.btnManagementNewStock.UseVisualStyleBackColor = true;
            this.btnManagementNewStock.Click += new System.EventHandler(this.btnManagementNewStock_Click);
            // 
            // btnManagementRestockRequest
            // 
            this.btnManagementRestockRequest.Location = new System.Drawing.Point(61, 277);
            this.btnManagementRestockRequest.Name = "btnManagementRestockRequest";
            this.btnManagementRestockRequest.Size = new System.Drawing.Size(242, 32);
            this.btnManagementRestockRequest.TabIndex = 4;
            this.btnManagementRestockRequest.Text = "[IN DEVELOPMENT]Make new restock request";
            this.btnManagementRestockRequest.UseVisualStyleBackColor = true;
            this.btnManagementRestockRequest.Click += new System.EventHandler(this.btnManagementRestockRequest_Click);
            // 
            // lbManagementStock
            // 
            this.lbManagementStock.FormattingEnabled = true;
            this.lbManagementStock.Location = new System.Drawing.Point(350, 26);
            this.lbManagementStock.Name = "lbManagementStock";
            this.lbManagementStock.Size = new System.Drawing.Size(379, 342);
            this.lbManagementStock.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbManagementStockBrandFilter);
            this.groupBox2.Controls.Add(this.rbManagementStockIDFilter);
            this.groupBox2.Controls.Add(this.rbManagementStockAmountFilter);
            this.groupBox2.Controls.Add(this.tbManagementStockFilter);
            this.groupBox2.Controls.Add(this.btnManagementStockFilter);
            this.groupBox2.Location = new System.Drawing.Point(55, 41);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbShiftType);
            this.tabPage1.Controls.Add(this.btnManagementShiftAssignEmployee);
            this.tabPage1.Controls.Add(this.lbManagementShiftEmployeesAssigned);
            this.tabPage1.Controls.Add(this.lbManagementShiftEmployeesToAssign);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(779, 382);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Shifts";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // cbShiftType
            // 
            this.cbShiftType.FormattingEnabled = true;
            this.cbShiftType.Items.AddRange(new object[] {
            "Morning (7AM-2PM)",
            "Afternoon (1PM-6PM)",
            "Night (5PM-10PM)"});
            this.cbShiftType.Location = new System.Drawing.Point(507, 278);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(121, 21);
            this.cbShiftType.TabIndex = 3;
            // 
            // btnManagementShiftAssignEmployee
            // 
            this.btnManagementShiftAssignEmployee.Location = new System.Drawing.Point(507, 305);
            this.btnManagementShiftAssignEmployee.Name = "btnManagementShiftAssignEmployee";
            this.btnManagementShiftAssignEmployee.Size = new System.Drawing.Size(141, 36);
            this.btnManagementShiftAssignEmployee.TabIndex = 1;
            this.btnManagementShiftAssignEmployee.Text = "Assign shift";
            this.btnManagementShiftAssignEmployee.UseVisualStyleBackColor = true;
            this.btnManagementShiftAssignEmployee.Click += new System.EventHandler(this.btnManagementShiftAssignEmployee_Click);
            // 
            // lbManagementShiftEmployeesAssigned
            // 
            this.lbManagementShiftEmployeesAssigned.FormattingEnabled = true;
            this.lbManagementShiftEmployeesAssigned.Location = new System.Drawing.Point(17, 207);
            this.lbManagementShiftEmployeesAssigned.Name = "lbManagementShiftEmployeesAssigned";
            this.lbManagementShiftEmployeesAssigned.Size = new System.Drawing.Size(486, 134);
            this.lbManagementShiftEmployeesAssigned.TabIndex = 2;
            this.lbManagementShiftEmployeesAssigned.SelectedIndexChanged += new System.EventHandler(this.lbManagementShiftEmployeesAssigned_SelectedIndexChanged);
            // 
            // lbManagementShiftEmployeesToAssign
            // 
            this.lbManagementShiftEmployeesToAssign.FormattingEnabled = true;
            this.lbManagementShiftEmployeesToAssign.Location = new System.Drawing.Point(17, 17);
            this.lbManagementShiftEmployeesToAssign.Name = "lbManagementShiftEmployeesToAssign";
            this.lbManagementShiftEmployeesToAssign.Size = new System.Drawing.Size(486, 173);
            this.lbManagementShiftEmployeesToAssign.TabIndex = 1;
            this.lbManagementShiftEmployeesToAssign.SelectedIndexChanged += new System.EventHandler(this.lbManagementShiftEmployeesToAssign_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(515, 17);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 400);
            this.Controls.Add(this.tabControl1);
            this.Name = "Management";
            this.Text = "Management";
            this.tabControl1.ResumeLayout(false);
            this.People.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnManagemntPersonCreation;
        private System.Windows.Forms.ListBox lbManagemendEmployees;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbManagementEPFilter;
        private System.Windows.Forms.Button btnManagemntPersonUpdate;
        private System.Windows.Forms.Button btnManagementEPFilter;
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
        private System.Windows.Forms.RadioButton rbManagementRole;
        private System.Windows.Forms.RadioButton rbManagementID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnManagemendUpdate;
        private System.Windows.Forms.Button btnViewEmployeeInfo;
        private System.Windows.Forms.Button btnStockRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbShiftType;
    }
}