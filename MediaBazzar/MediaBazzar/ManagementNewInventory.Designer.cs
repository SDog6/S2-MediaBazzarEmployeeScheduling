﻿
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
            this.SuspendLayout();
            // 
            // lbWarehouseStock
            // 
            this.lbWarehouseStock.FormattingEnabled = true;
            this.lbWarehouseStock.Location = new System.Drawing.Point(21, 46);
            this.lbWarehouseStock.Name = "lbWarehouseStock";
            this.lbWarehouseStock.Size = new System.Drawing.Size(320, 329);
            this.lbWarehouseStock.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(167, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add to current inventory";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select desired inventory";
            // 
            // ManagementNewInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbWarehouseStock);
            this.Name = "ManagementNewInventory";
            this.Text = "ManagementNewInventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWarehouseStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}