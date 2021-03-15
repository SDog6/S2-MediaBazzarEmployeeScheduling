
namespace MediaBazzar
{
    partial class WarehouseManagement
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
            this.btnWarehouseAddItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWarehouseSearch = new System.Windows.Forms.Button();
            this.rbWarehouseItemID = new System.Windows.Forms.RadioButton();
            this.tbWarehouseSearch = new System.Windows.Forms.TextBox();
            this.rbWarehouseBrand = new System.Windows.Forms.RadioButton();
            this.lbWarehouseStock = new System.Windows.Forms.ListBox();
            this.btnWarehouseUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWarehouseAddItem
            // 
            this.btnWarehouseAddItem.Location = new System.Drawing.Point(186, 261);
            this.btnWarehouseAddItem.Name = "btnWarehouseAddItem";
            this.btnWarehouseAddItem.Size = new System.Drawing.Size(101, 45);
            this.btnWarehouseAddItem.TabIndex = 8;
            this.btnWarehouseAddItem.Text = "Add new item";
            this.btnWarehouseAddItem.UseVisualStyleBackColor = true;
            this.btnWarehouseAddItem.Click += new System.EventHandler(this.btnWarehouseAddItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWarehouseSearch);
            this.groupBox1.Controls.Add(this.rbWarehouseItemID);
            this.groupBox1.Controls.Add(this.tbWarehouseSearch);
            this.groupBox1.Controls.Add(this.rbWarehouseBrand);
            this.groupBox1.Location = new System.Drawing.Point(82, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // btnWarehouseSearch
            // 
            this.btnWarehouseSearch.Location = new System.Drawing.Point(81, 61);
            this.btnWarehouseSearch.Name = "btnWarehouseSearch";
            this.btnWarehouseSearch.Size = new System.Drawing.Size(75, 23);
            this.btnWarehouseSearch.TabIndex = 5;
            this.btnWarehouseSearch.Text = "Search";
            this.btnWarehouseSearch.UseVisualStyleBackColor = true;
            this.btnWarehouseSearch.Click += new System.EventHandler(this.btnWarehouseSearch_Click);
            // 
            // rbWarehouseItemID
            // 
            this.rbWarehouseItemID.AutoSize = true;
            this.rbWarehouseItemID.Location = new System.Drawing.Point(6, 30);
            this.rbWarehouseItemID.Name = "rbWarehouseItemID";
            this.rbWarehouseItemID.Size = new System.Drawing.Size(59, 17);
            this.rbWarehouseItemID.TabIndex = 2;
            this.rbWarehouseItemID.TabStop = true;
            this.rbWarehouseItemID.Text = "Item ID";
            this.rbWarehouseItemID.UseVisualStyleBackColor = true;
            // 
            // tbWarehouseSearch
            // 
            this.tbWarehouseSearch.Location = new System.Drawing.Point(81, 30);
            this.tbWarehouseSearch.Name = "tbWarehouseSearch";
            this.tbWarehouseSearch.Size = new System.Drawing.Size(100, 20);
            this.tbWarehouseSearch.TabIndex = 1;
            // 
            // rbWarehouseBrand
            // 
            this.rbWarehouseBrand.AutoSize = true;
            this.rbWarehouseBrand.Location = new System.Drawing.Point(6, 61);
            this.rbWarehouseBrand.Name = "rbWarehouseBrand";
            this.rbWarehouseBrand.Size = new System.Drawing.Size(53, 17);
            this.rbWarehouseBrand.TabIndex = 3;
            this.rbWarehouseBrand.TabStop = true;
            this.rbWarehouseBrand.Text = "Brand";
            this.rbWarehouseBrand.UseVisualStyleBackColor = true;
            // 
            // lbWarehouseStock
            // 
            this.lbWarehouseStock.FormattingEnabled = true;
            this.lbWarehouseStock.Location = new System.Drawing.Point(336, 29);
            this.lbWarehouseStock.Name = "lbWarehouseStock";
            this.lbWarehouseStock.Size = new System.Drawing.Size(402, 407);
            this.lbWarehouseStock.TabIndex = 6;
            // 
            // btnWarehouseUpdate
            // 
            this.btnWarehouseUpdate.Location = new System.Drawing.Point(70, 261);
            this.btnWarehouseUpdate.Name = "btnWarehouseUpdate";
            this.btnWarehouseUpdate.Size = new System.Drawing.Size(101, 45);
            this.btnWarehouseUpdate.TabIndex = 9;
            this.btnWarehouseUpdate.Text = "Check for update";
            this.btnWarehouseUpdate.UseVisualStyleBackColor = true;
            this.btnWarehouseUpdate.Click += new System.EventHandler(this.btnWarehouseUpdate_Click);
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 456);
            this.Controls.Add(this.btnWarehouseUpdate);
            this.Controls.Add(this.btnWarehouseAddItem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbWarehouseStock);
            this.Name = "WarehouseManagement";
            this.Text = "WarehouseManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWarehouseAddItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWarehouseSearch;
        private System.Windows.Forms.RadioButton rbWarehouseItemID;
        private System.Windows.Forms.TextBox tbWarehouseSearch;
        private System.Windows.Forms.RadioButton rbWarehouseBrand;
        private System.Windows.Forms.ListBox lbWarehouseStock;
        private System.Windows.Forms.Button btnWarehouseUpdate;
    }
}