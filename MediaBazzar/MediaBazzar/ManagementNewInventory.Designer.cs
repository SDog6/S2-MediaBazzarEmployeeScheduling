
namespace MediaBazzar
{
    partial class ManagementNewInventory
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
            this.lbWarehouseStock = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbWarehouseStock
            // 
            this.lbWarehouseStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbWarehouseStock.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbWarehouseStock.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbWarehouseStock.FormattingEnabled = true;
            this.lbWarehouseStock.ItemHeight = 17;
            this.lbWarehouseStock.Location = new System.Drawing.Point(21, 46);
            this.lbWarehouseStock.Name = "lbWarehouseStock";
            this.lbWarehouseStock.Size = new System.Drawing.Size(538, 327);
            this.lbWarehouseStock.TabIndex = 0;
            this.lbWarehouseStock.SelectedIndexChanged += new System.EventHandler(this.lbWarehouseStock_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAdd.Location = new System.Drawing.Point(205, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add to current inventory";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select desired inventory";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(316, 389);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(152, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amount needed";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 450);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(0, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "<-BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagementNewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 450);
            this.Controls.Add(this.lbWarehouseStock);
            this.Controls.Add(this.panel1);
            this.Name = "ManagementNewInventory";
            this.Text = "ManagementNewInventory";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbWarehouseStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}