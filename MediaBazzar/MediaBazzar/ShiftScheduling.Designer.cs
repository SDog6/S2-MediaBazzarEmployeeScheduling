
namespace MediaBazzar
{
    partial class ShiftScheduling
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
            this.cbShiftType = new System.Windows.Forms.ComboBox();
            this.btnManagementShiftAssignEmployee = new System.Windows.Forms.Button();
            this.lbMorningShifts = new System.Windows.Forms.ListBox();
            this.lbManagementShiftEmployeesToAssign = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbAfternoonshifts = new System.Windows.Forms.ListBox();
            this.lbEveningShifts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbShiftType
            // 
            this.cbShiftType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.cbShiftType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbShiftType.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbShiftType.FormattingEnabled = true;
            this.cbShiftType.Items.AddRange(new object[] {
            "Morning (7AM-2PM)",
            "Afternoon (1PM-6PM)",
            "Night (5PM-10PM)"});
            this.cbShiftType.Location = new System.Drawing.Point(464, 193);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(121, 21);
            this.cbShiftType.TabIndex = 8;
            // 
            // btnManagementShiftAssignEmployee
            // 
            this.btnManagementShiftAssignEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnManagementShiftAssignEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManagementShiftAssignEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagementShiftAssignEmployee.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManagementShiftAssignEmployee.Location = new System.Drawing.Point(297, 220);
            this.btnManagementShiftAssignEmployee.Name = "btnManagementShiftAssignEmployee";
            this.btnManagementShiftAssignEmployee.Size = new System.Drawing.Size(141, 36);
            this.btnManagementShiftAssignEmployee.TabIndex = 5;
            this.btnManagementShiftAssignEmployee.Text = "Assign shift";
            this.btnManagementShiftAssignEmployee.UseVisualStyleBackColor = false;
            this.btnManagementShiftAssignEmployee.Click += new System.EventHandler(this.btnManagementShiftAssignEmployee_Click);
            // 
            // lbMorningShifts
            // 
            this.lbMorningShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbMorningShifts.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbMorningShifts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbMorningShifts.FormattingEnabled = true;
            this.lbMorningShifts.ItemHeight = 17;
            this.lbMorningShifts.Location = new System.Drawing.Point(26, 327);
            this.lbMorningShifts.Name = "lbMorningShifts";
            this.lbMorningShifts.Size = new System.Drawing.Size(311, 123);
            this.lbMorningShifts.TabIndex = 7;
            // 
            // lbManagementShiftEmployeesToAssign
            // 
            this.lbManagementShiftEmployeesToAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbManagementShiftEmployeesToAssign.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbManagementShiftEmployeesToAssign.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbManagementShiftEmployeesToAssign.FormattingEnabled = true;
            this.lbManagementShiftEmployeesToAssign.ItemHeight = 17;
            this.lbManagementShiftEmployeesToAssign.Location = new System.Drawing.Point(99, 27);
            this.lbManagementShiftEmployeesToAssign.Name = "lbManagementShiftEmployeesToAssign";
            this.lbManagementShiftEmployeesToAssign.Size = new System.Drawing.Size(486, 157);
            this.lbManagementShiftEmployeesToAssign.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.monthCalendar1.Location = new System.Drawing.Point(642, 27);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.ControlText;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lbAfternoonshifts
            // 
            this.lbAfternoonshifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbAfternoonshifts.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbAfternoonshifts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbAfternoonshifts.FormattingEnabled = true;
            this.lbAfternoonshifts.ItemHeight = 17;
            this.lbAfternoonshifts.Location = new System.Drawing.Point(370, 327);
            this.lbAfternoonshifts.Name = "lbAfternoonshifts";
            this.lbAfternoonshifts.Size = new System.Drawing.Size(311, 123);
            this.lbAfternoonshifts.TabIndex = 9;
            // 
            // lbEveningShifts
            // 
            this.lbEveningShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.lbEveningShifts.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lbEveningShifts.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbEveningShifts.FormattingEnabled = true;
            this.lbEveningShifts.ItemHeight = 17;
            this.lbEveningShifts.Location = new System.Drawing.Point(711, 327);
            this.lbEveningShifts.Name = "lbEveningShifts";
            this.lbEveningShifts.Size = new System.Drawing.Size(311, 123);
            this.lbEveningShifts.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(364, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Afternoon";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnAuto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnManagementShiftAssignEmployee);
            this.panel1.Controls.Add(this.monthCalendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 524);
            this.panel1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(444, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Remove shift";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.btnAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAuto.Location = new System.Drawing.Point(99, 200);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(141, 56);
            this.btnAuto.TabIndex = 15;
            this.btnAuto.Text = "Auto assign shifts";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(20, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 33);
            this.label3.TabIndex = 15;
            this.label3.Text = "Morning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(705, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Evening";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ShiftScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbEveningShifts);
            this.Controls.Add(this.lbAfternoonshifts);
            this.Controls.Add(this.cbShiftType);
            this.Controls.Add(this.lbMorningShifts);
            this.Controls.Add(this.lbManagementShiftEmployeesToAssign);
            this.Controls.Add(this.panel1);
            this.Name = "ShiftScheduling";
            this.Text = "ShiftScheduling";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbShiftType;
        private System.Windows.Forms.Button btnManagementShiftAssignEmployee;
        private System.Windows.Forms.ListBox lbMorningShifts;
        private System.Windows.Forms.ListBox lbManagementShiftEmployeesToAssign;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox lbAfternoonshifts;
        private System.Windows.Forms.ListBox lbEveningShifts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button button1;
    }
}