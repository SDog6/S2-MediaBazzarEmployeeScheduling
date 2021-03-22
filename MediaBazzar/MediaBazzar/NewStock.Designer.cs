
namespace MediaBazzar
{
    partial class NewStock
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
            this.components = new System.ComponentModel.Container();
            this.tbNewStockName = new System.Windows.Forms.TextBox();
            this.tbNewStockID = new System.Windows.Forms.TextBox();
            this.tbNewStockBrand = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblNewStockName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewStockAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNewStockPrice = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewStockName
            // 
            this.tbNewStockName.Location = new System.Drawing.Point(117, 58);
            this.tbNewStockName.Name = "tbNewStockName";
            this.tbNewStockName.Size = new System.Drawing.Size(100, 20);
            this.tbNewStockName.TabIndex = 0;
            // 
            // tbNewStockID
            // 
            this.tbNewStockID.Location = new System.Drawing.Point(117, 174);
            this.tbNewStockID.Name = "tbNewStockID";
            this.tbNewStockID.Size = new System.Drawing.Size(100, 20);
            this.tbNewStockID.TabIndex = 1;
            // 
            // tbNewStockBrand
            // 
            this.tbNewStockBrand.Location = new System.Drawing.Point(117, 118);
            this.tbNewStockBrand.Name = "tbNewStockBrand";
            this.tbNewStockBrand.Size = new System.Drawing.Size(100, 20);
            this.tbNewStockBrand.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblNewStockName
            // 
            this.lblNewStockName.AutoSize = true;
            this.lblNewStockName.Location = new System.Drawing.Point(64, 58);
            this.lblNewStockName.Name = "lblNewStockName";
            this.lblNewStockName.Size = new System.Drawing.Size(38, 13);
            this.lblNewStockName.TabIndex = 4;
            this.lblNewStockName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Brand:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Amount:";
            // 
            // tbNewStockAmount
            // 
            this.tbNewStockAmount.Location = new System.Drawing.Point(323, 58);
            this.tbNewStockAmount.Name = "tbNewStockAmount";
            this.tbNewStockAmount.Size = new System.Drawing.Size(100, 20);
            this.tbNewStockAmount.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Price:";
            // 
            // tbNewStockPrice
            // 
            this.tbNewStockPrice.Location = new System.Drawing.Point(323, 114);
            this.tbNewStockPrice.Name = "tbNewStockPrice";
            this.tbNewStockPrice.Size = new System.Drawing.Size(100, 20);
            this.tbNewStockPrice.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add stock to warehouse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 272);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNewStockPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewStockAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNewStockName);
            this.Controls.Add(this.tbNewStockBrand);
            this.Controls.Add(this.tbNewStockID);
            this.Controls.Add(this.tbNewStockName);
            this.Name = "NewStock";
            this.Text = "NewStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewStockName;
        private System.Windows.Forms.TextBox tbNewStockID;
        private System.Windows.Forms.TextBox tbNewStockBrand;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblNewStockName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewStockAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewStockPrice;
        private System.Windows.Forms.Button button1;
    }
}