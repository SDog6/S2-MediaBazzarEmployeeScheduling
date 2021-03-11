
namespace MediaBazaar
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddEmpl = new System.Windows.Forms.Button();
            this.panel_AddEmpl = new System.Windows.Forms.Panel();
            this.btnPAddEmpl = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxState = new System.Windows.Forms.TextBox();
            this.tbxCity = new System.Windows.Forms.TextBox();
            this.tbxStreet = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxSname = new System.Windows.Forms.TextBox();
            this.tbxFname = new System.Windows.Forms.TextBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.btnAddDep = new System.Windows.Forms.Button();
            this.panelAddDep = new System.Windows.Forms.Panel();
            this.btnPAddDep = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_AddEmpl.SuspendLayout();
            this.panelAddDep.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(22, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(340, 148);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show Employees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddEmpl
            // 
            this.btnAddEmpl.Location = new System.Drawing.Point(243, 242);
            this.btnAddEmpl.Name = "btnAddEmpl";
            this.btnAddEmpl.Size = new System.Drawing.Size(95, 46);
            this.btnAddEmpl.TabIndex = 3;
            this.btnAddEmpl.Text = "Add Employee";
            this.btnAddEmpl.UseVisualStyleBackColor = true;
            this.btnAddEmpl.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel_AddEmpl
            // 
            this.panel_AddEmpl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_AddEmpl.Controls.Add(this.btnPAddEmpl);
            this.panel_AddEmpl.Controls.Add(this.label8);
            this.panel_AddEmpl.Controls.Add(this.label7);
            this.panel_AddEmpl.Controls.Add(this.label6);
            this.panel_AddEmpl.Controls.Add(this.label5);
            this.panel_AddEmpl.Controls.Add(this.label4);
            this.panel_AddEmpl.Controls.Add(this.label3);
            this.panel_AddEmpl.Controls.Add(this.label2);
            this.panel_AddEmpl.Controls.Add(this.tbxEmail);
            this.panel_AddEmpl.Controls.Add(this.tbxState);
            this.panel_AddEmpl.Controls.Add(this.tbxCity);
            this.panel_AddEmpl.Controls.Add(this.tbxStreet);
            this.panel_AddEmpl.Controls.Add(this.tbxPhone);
            this.panel_AddEmpl.Controls.Add(this.tbxSname);
            this.panel_AddEmpl.Controls.Add(this.tbxFname);
            this.panel_AddEmpl.Location = new System.Drawing.Point(388, 28);
            this.panel_AddEmpl.Name = "panel_AddEmpl";
            this.panel_AddEmpl.Size = new System.Drawing.Size(408, 301);
            this.panel_AddEmpl.TabIndex = 4;
            this.panel_AddEmpl.Visible = false;
            // 
            // btnPAddEmpl
            // 
            this.btnPAddEmpl.Location = new System.Drawing.Point(161, 255);
            this.btnPAddEmpl.Name = "btnPAddEmpl";
            this.btnPAddEmpl.Size = new System.Drawing.Size(78, 22);
            this.btnPAddEmpl.TabIndex = 5;
            this.btnPAddEmpl.Text = "Add";
            this.btnPAddEmpl.UseVisualStyleBackColor = true;
            this.btnPAddEmpl.Click += new System.EventHandler(this.btnPAddEmpl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "City";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Street";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Second Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(132, 213);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(254, 22);
            this.tbxEmail.TabIndex = 6;
            // 
            // tbxState
            // 
            this.tbxState.Location = new System.Drawing.Point(132, 170);
            this.tbxState.Name = "tbxState";
            this.tbxState.Size = new System.Drawing.Size(254, 22);
            this.tbxState.TabIndex = 5;
            // 
            // tbxCity
            // 
            this.tbxCity.Location = new System.Drawing.Point(132, 142);
            this.tbxCity.Name = "tbxCity";
            this.tbxCity.Size = new System.Drawing.Size(254, 22);
            this.tbxCity.TabIndex = 4;
            // 
            // tbxStreet
            // 
            this.tbxStreet.Location = new System.Drawing.Point(132, 114);
            this.tbxStreet.Name = "tbxStreet";
            this.tbxStreet.Size = new System.Drawing.Size(254, 22);
            this.tbxStreet.TabIndex = 3;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(132, 73);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(254, 22);
            this.tbxPhone.TabIndex = 2;
            // 
            // tbxSname
            // 
            this.tbxSname.Location = new System.Drawing.Point(132, 45);
            this.tbxSname.Name = "tbxSname";
            this.tbxSname.Size = new System.Drawing.Size(254, 22);
            this.tbxSname.TabIndex = 1;
            // 
            // tbxFname
            // 
            this.tbxFname.Location = new System.Drawing.Point(132, 17);
            this.tbxFname.Name = "tbxFname";
            this.tbxFname.Size = new System.Drawing.Size(254, 22);
            this.tbxFname.TabIndex = 0;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(111, 28);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(170, 28);
            this.cbxDepartment.TabIndex = 5;
            // 
            // btnAddDep
            // 
            this.btnAddDep.Location = new System.Drawing.Point(139, 294);
            this.btnAddDep.Name = "btnAddDep";
            this.btnAddDep.Size = new System.Drawing.Size(112, 46);
            this.btnAddDep.TabIndex = 6;
            this.btnAddDep.Text = "New Department";
            this.btnAddDep.UseVisualStyleBackColor = true;
            this.btnAddDep.Click += new System.EventHandler(this.btnAddDep_Click);
            // 
            // panelAddDep
            // 
            this.panelAddDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddDep.Controls.Add(this.btnPAddDep);
            this.panelAddDep.Controls.Add(this.textBox1);
            this.panelAddDep.Location = new System.Drawing.Point(368, 12);
            this.panelAddDep.Name = "panelAddDep";
            this.panelAddDep.Size = new System.Drawing.Size(267, 84);
            this.panelAddDep.TabIndex = 7;
            this.panelAddDep.Visible = false;
            // 
            // btnPAddDep
            // 
            this.btnPAddDep.Location = new System.Drawing.Point(92, 48);
            this.btnPAddDep.Name = "btnPAddDep";
            this.btnPAddDep.Size = new System.Drawing.Size(78, 22);
            this.btnPAddDep.TabIndex = 14;
            this.btnPAddDep.Text = "Add";
            this.btnPAddDep.UseVisualStyleBackColor = true;
            this.btnPAddDep.Click += new System.EventHandler(this.btnPAddDep_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 406);
            this.Controls.Add(this.panelAddDep);
            this.Controls.Add(this.btnAddDep);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.panel_AddEmpl);
            this.Controls.Add(this.btnAddEmpl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_AddEmpl.ResumeLayout(false);
            this.panel_AddEmpl.PerformLayout();
            this.panelAddDep.ResumeLayout(false);
            this.panelAddDep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddEmpl;
        private System.Windows.Forms.Panel panel_AddEmpl;
        private System.Windows.Forms.TextBox tbxFname;
        private System.Windows.Forms.TextBox tbxStreet;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxSname;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxState;
        private System.Windows.Forms.TextBox tbxCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPAddEmpl;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.Button btnAddDep;
        private System.Windows.Forms.Panel panelAddDep;
        private System.Windows.Forms.Button btnPAddDep;
        private System.Windows.Forms.TextBox textBox1;
    }
}

