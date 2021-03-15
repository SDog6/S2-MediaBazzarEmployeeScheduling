
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnManagementEPFilter = new System.Windows.Forms.Button();
            this.tbManagementEPFilter = new System.Windows.Forms.TextBox();
            this.btnManagemntPersonUpdate = new System.Windows.Forms.Button();
            this.btnManagemntPersonCreation = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Stock = new System.Windows.Forms.TabPage();
            this.rbManagementStockAmountFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockBrandFilter = new System.Windows.Forms.RadioButton();
            this.rbManagementStockIDFilter = new System.Windows.Forms.RadioButton();
            this.btnManagementRestockRequest = new System.Windows.Forms.Button();
            this.btnManagementStockFilter = new System.Windows.Forms.Button();
            this.tbManagementStockFilter = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.People.SuspendLayout();
            this.Stock.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(742, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // People
            // 
            this.People.Controls.Add(this.label1);
            this.People.Controls.Add(this.btnManagementEPFilter);
            this.People.Controls.Add(this.tbManagementEPFilter);
            this.People.Controls.Add(this.btnManagemntPersonUpdate);
            this.People.Controls.Add(this.btnManagemntPersonCreation);
            this.People.Controls.Add(this.listBox1);
            this.People.Location = new System.Drawing.Point(4, 22);
            this.People.Name = "People";
            this.People.Padding = new System.Windows.Forms.Padding(3);
            this.People.Size = new System.Drawing.Size(734, 407);
            this.People.TabIndex = 0;
            this.People.Text = "Employees";
            this.People.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "BSN:";
            // 
            // btnManagementEPFilter
            // 
            this.btnManagementEPFilter.Location = new System.Drawing.Point(107, 101);
            this.btnManagementEPFilter.Name = "btnManagementEPFilter";
            this.btnManagementEPFilter.Size = new System.Drawing.Size(93, 38);
            this.btnManagementEPFilter.TabIndex = 4;
            this.btnManagementEPFilter.Text = "Filter";
            this.btnManagementEPFilter.UseVisualStyleBackColor = true;
            this.btnManagementEPFilter.Click += new System.EventHandler(this.btnManagementEPFilter_Click);
            // 
            // tbManagementEPFilter
            // 
            this.tbManagementEPFilter.Location = new System.Drawing.Point(100, 66);
            this.tbManagementEPFilter.Name = "tbManagementEPFilter";
            this.tbManagementEPFilter.Size = new System.Drawing.Size(100, 20);
            this.tbManagementEPFilter.TabIndex = 3;
            // 
            // btnManagemntPersonUpdate
            // 
            this.btnManagemntPersonUpdate.Location = new System.Drawing.Point(31, 224);
            this.btnManagemntPersonUpdate.Name = "btnManagemntPersonUpdate";
            this.btnManagemntPersonUpdate.Size = new System.Drawing.Size(93, 38);
            this.btnManagemntPersonUpdate.TabIndex = 2;
            this.btnManagemntPersonUpdate.Text = "Update employee information";
            this.btnManagemntPersonUpdate.UseVisualStyleBackColor = true;
            // 
            // btnManagemntPersonCreation
            // 
            this.btnManagemntPersonCreation.Location = new System.Drawing.Point(167, 224);
            this.btnManagemntPersonCreation.Name = "btnManagemntPersonCreation";
            this.btnManagemntPersonCreation.Size = new System.Drawing.Size(93, 38);
            this.btnManagemntPersonCreation.TabIndex = 1;
            this.btnManagemntPersonCreation.Text = "Add a new employee";
            this.btnManagemntPersonCreation.UseVisualStyleBackColor = true;
            this.btnManagemntPersonCreation.Click += new System.EventHandler(this.btnManagemntPersonCreation_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(364, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(321, 368);
            this.listBox1.TabIndex = 0;
            // 
            // Stock
            // 
            this.Stock.Controls.Add(this.rbManagementStockAmountFilter);
            this.Stock.Controls.Add(this.rbManagementStockBrandFilter);
            this.Stock.Controls.Add(this.rbManagementStockIDFilter);
            this.Stock.Controls.Add(this.btnManagementRestockRequest);
            this.Stock.Controls.Add(this.btnManagementStockFilter);
            this.Stock.Controls.Add(this.tbManagementStockFilter);
            this.Stock.Controls.Add(this.listBox2);
            this.Stock.Location = new System.Drawing.Point(4, 22);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(3);
            this.Stock.Size = new System.Drawing.Size(734, 407);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // rbManagementStockAmountFilter
            // 
            this.rbManagementStockAmountFilter.AutoSize = true;
            this.rbManagementStockAmountFilter.Location = new System.Drawing.Point(231, 86);
            this.rbManagementStockAmountFilter.Name = "rbManagementStockAmountFilter";
            this.rbManagementStockAmountFilter.Size = new System.Drawing.Size(61, 17);
            this.rbManagementStockAmountFilter.TabIndex = 7;
            this.rbManagementStockAmountFilter.TabStop = true;
            this.rbManagementStockAmountFilter.Text = "Amount";
            this.rbManagementStockAmountFilter.UseVisualStyleBackColor = true;
            // 
            // rbManagementStockBrandFilter
            // 
            this.rbManagementStockBrandFilter.AutoSize = true;
            this.rbManagementStockBrandFilter.Location = new System.Drawing.Point(136, 86);
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
            this.rbManagementStockIDFilter.Location = new System.Drawing.Point(45, 86);
            this.rbManagementStockIDFilter.Name = "rbManagementStockIDFilter";
            this.rbManagementStockIDFilter.Size = new System.Drawing.Size(36, 17);
            this.rbManagementStockIDFilter.TabIndex = 5;
            this.rbManagementStockIDFilter.TabStop = true;
            this.rbManagementStockIDFilter.Text = "ID";
            this.rbManagementStockIDFilter.UseVisualStyleBackColor = true;
            // 
            // btnManagementRestockRequest
            // 
            this.btnManagementRestockRequest.Location = new System.Drawing.Point(69, 217);
            this.btnManagementRestockRequest.Name = "btnManagementRestockRequest";
            this.btnManagementRestockRequest.Size = new System.Drawing.Size(201, 32);
            this.btnManagementRestockRequest.TabIndex = 4;
            this.btnManagementRestockRequest.Text = "Make new restock request";
            this.btnManagementRestockRequest.UseVisualStyleBackColor = true;
            this.btnManagementRestockRequest.Click += new System.EventHandler(this.btnManagementRestockRequest_Click);
            // 
            // btnManagementStockFilter
            // 
            this.btnManagementStockFilter.Location = new System.Drawing.Point(143, 163);
            this.btnManagementStockFilter.Name = "btnManagementStockFilter";
            this.btnManagementStockFilter.Size = new System.Drawing.Size(75, 32);
            this.btnManagementStockFilter.TabIndex = 3;
            this.btnManagementStockFilter.Text = "Filter";
            this.btnManagementStockFilter.UseVisualStyleBackColor = true;
            // 
            // tbManagementStockFilter
            // 
            this.tbManagementStockFilter.Location = new System.Drawing.Point(128, 127);
            this.tbManagementStockFilter.Name = "tbManagementStockFilter";
            this.tbManagementStockFilter.Size = new System.Drawing.Size(100, 20);
            this.tbManagementStockFilter.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(350, 26);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(321, 342);
            this.listBox2.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(734, 407);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Shifts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "Management";
            this.Text = "Management";
            this.tabControl1.ResumeLayout(false);
            this.People.ResumeLayout(false);
            this.People.PerformLayout();
            this.Stock.ResumeLayout(false);
            this.Stock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage People;
        private System.Windows.Forms.TabPage Stock;
        private System.Windows.Forms.Button btnManagemntPersonCreation;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbManagementEPFilter;
        private System.Windows.Forms.Button btnManagemntPersonUpdate;
        private System.Windows.Forms.Button btnManagementEPFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManagementRestockRequest;
        private System.Windows.Forms.Button btnManagementStockFilter;
        private System.Windows.Forms.TextBox tbManagementStockFilter;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton rbManagementStockAmountFilter;
        private System.Windows.Forms.RadioButton rbManagementStockBrandFilter;
        private System.Windows.Forms.RadioButton rbManagementStockIDFilter;
    }
}