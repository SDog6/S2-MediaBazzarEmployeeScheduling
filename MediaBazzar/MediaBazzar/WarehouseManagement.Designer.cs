
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWarehouseItemID = new System.Windows.Forms.RadioButton();
            this.tbWarehouseSearch = new System.Windows.Forms.TextBox();
            this.rbWarehouseBrand = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWarehouseResupply = new System.Windows.Forms.Button();
            this.tbWarehouseResupply = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDiscontinue = new System.Windows.Forms.Button();
            this.btnRestock = new System.Windows.Forms.Button();
            this.btnNewItem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.groupBox1.Controls.Add(this.rbWarehouseItemID);
            this.groupBox1.Controls.Add(this.tbWarehouseSearch);
            this.groupBox1.Controls.Add(this.rbWarehouseBrand);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(223, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter by";
            // 
            // rbWarehouseItemID
            // 
            this.rbWarehouseItemID.AutoSize = true;
            this.rbWarehouseItemID.Location = new System.Drawing.Point(6, 30);
            this.rbWarehouseItemID.Name = "rbWarehouseItemID";
            this.rbWarehouseItemID.Size = new System.Drawing.Size(86, 25);
            this.rbWarehouseItemID.TabIndex = 2;
            this.rbWarehouseItemID.TabStop = true;
            this.rbWarehouseItemID.Text = "Item ID";
            this.rbWarehouseItemID.UseVisualStyleBackColor = true;
            // 
            // tbWarehouseSearch
            // 
            this.tbWarehouseSearch.Location = new System.Drawing.Point(98, 51);
            this.tbWarehouseSearch.Name = "tbWarehouseSearch";
            this.tbWarehouseSearch.Size = new System.Drawing.Size(100, 27);
            this.tbWarehouseSearch.TabIndex = 1;
            // 
            // rbWarehouseBrand
            // 
            this.rbWarehouseBrand.AutoSize = true;
            this.rbWarehouseBrand.Location = new System.Drawing.Point(6, 61);
            this.rbWarehouseBrand.Name = "rbWarehouseBrand";
            this.rbWarehouseBrand.Size = new System.Drawing.Size(74, 25);
            this.rbWarehouseBrand.TabIndex = 3;
            this.rbWarehouseBrand.TabStop = true;
            this.rbWarehouseBrand.Text = "Brand";
            this.rbWarehouseBrand.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnWarehouseResupply);
            this.groupBox2.Controls.Add(this.tbWarehouseResupply);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Location = new System.Drawing.Point(581, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 135);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resupply";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Increase amount in stock by";
            // 
            // btnWarehouseResupply
            // 
            this.btnWarehouseResupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnWarehouseResupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarehouseResupply.Location = new System.Drawing.Point(9, 79);
            this.btnWarehouseResupply.Name = "btnWarehouseResupply";
            this.btnWarehouseResupply.Size = new System.Drawing.Size(139, 38);
            this.btnWarehouseResupply.TabIndex = 7;
            this.btnWarehouseResupply.Text = "Increase";
            this.btnWarehouseResupply.UseVisualStyleBackColor = false;
            this.btnWarehouseResupply.Click += new System.EventHandler(this.btnWarehouseResupply_Click);
            // 
            // tbWarehouseResupply
            // 
            this.tbWarehouseResupply.Location = new System.Drawing.Point(9, 41);
            this.tbWarehouseResupply.Name = "tbWarehouseResupply";
            this.tbWarehouseResupply.Size = new System.Drawing.Size(100, 27);
            this.tbWarehouseResupply.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 528);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 217);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(634, 253);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(12)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.btnDiscontinue);
            this.panel2.Controls.Add(this.btnRestock);
            this.panel2.Controls.Add(this.btnNewItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 528);
            this.panel2.TabIndex = 0;
            // 
            // btnDiscontinue
            // 
            this.btnDiscontinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnDiscontinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscontinue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscontinue.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDiscontinue.Location = new System.Drawing.Point(0, 179);
            this.btnDiscontinue.Name = "btnDiscontinue";
            this.btnDiscontinue.Size = new System.Drawing.Size(200, 56);
            this.btnDiscontinue.TabIndex = 23;
            this.btnDiscontinue.Text = "Remove item from active inventory";
            this.btnDiscontinue.UseVisualStyleBackColor = false;
            this.btnDiscontinue.Click += new System.EventHandler(this.btnDiscontinue_Click);
            // 
            // btnRestock
            // 
            this.btnRestock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnRestock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestock.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRestock.Location = new System.Drawing.Point(0, 276);
            this.btnRestock.Name = "btnRestock";
            this.btnRestock.Size = new System.Drawing.Size(200, 56);
            this.btnRestock.TabIndex = 22;
            this.btnRestock.Text = "View restock requests";
            this.btnRestock.UseVisualStyleBackColor = false;
            this.btnRestock.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // btnNewItem
            // 
            this.btnNewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnNewItem.Location = new System.Drawing.Point(0, 84);
            this.btnNewItem.Name = "btnNewItem";
            this.btnNewItem.Size = new System.Drawing.Size(200, 56);
            this.btnNewItem.TabIndex = 21;
            this.btnNewItem.Text = "Add new item";
            this.btnNewItem.UseVisualStyleBackColor = false;
            this.btnNewItem.Click += new System.EventHandler(this.btnNewItem_Click);
            // 
            // WarehouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "WarehouseManagement";
            this.Text = "WarehouseManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWarehouseItemID;
        private System.Windows.Forms.TextBox tbWarehouseSearch;
        private System.Windows.Forms.RadioButton rbWarehouseBrand;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWarehouseResupply;
        private System.Windows.Forms.TextBox tbWarehouseResupply;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNewItem;
        private System.Windows.Forms.Button btnDiscontinue;
        private System.Windows.Forms.Button btnRestock;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}