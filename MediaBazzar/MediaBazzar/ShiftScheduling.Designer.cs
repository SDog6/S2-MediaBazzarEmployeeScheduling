
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
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbShiftType
            // 
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
            this.btnManagementShiftAssignEmployee.Location = new System.Drawing.Point(444, 220);
            this.btnManagementShiftAssignEmployee.Name = "btnManagementShiftAssignEmployee";
            this.btnManagementShiftAssignEmployee.Size = new System.Drawing.Size(141, 36);
            this.btnManagementShiftAssignEmployee.TabIndex = 5;
            this.btnManagementShiftAssignEmployee.Text = "Assign shift";
            this.btnManagementShiftAssignEmployee.UseVisualStyleBackColor = true;
            this.btnManagementShiftAssignEmployee.Click += new System.EventHandler(this.btnManagementShiftAssignEmployee_Click);
            // 
            // lbMorningShifts
            // 
            this.lbMorningShifts.FormattingEnabled = true;
            this.lbMorningShifts.Location = new System.Drawing.Point(26, 327);
            this.lbMorningShifts.Name = "lbMorningShifts";
            this.lbMorningShifts.Size = new System.Drawing.Size(311, 134);
            this.lbMorningShifts.TabIndex = 7;
            // 
            // lbManagementShiftEmployeesToAssign
            // 
            this.lbManagementShiftEmployeesToAssign.FormattingEnabled = true;
            this.lbManagementShiftEmployeesToAssign.Location = new System.Drawing.Point(99, 27);
            this.lbManagementShiftEmployeesToAssign.Name = "lbManagementShiftEmployeesToAssign";
            this.lbManagementShiftEmployeesToAssign.Size = new System.Drawing.Size(486, 160);
            this.lbManagementShiftEmployeesToAssign.TabIndex = 6;
            this.lbManagementShiftEmployeesToAssign.SelectedIndexChanged += new System.EventHandler(this.lbManagementShiftEmployeesToAssign_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(645, 18);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // lbAfternoonshifts
            // 
            this.lbAfternoonshifts.FormattingEnabled = true;
            this.lbAfternoonshifts.Location = new System.Drawing.Point(370, 327);
            this.lbAfternoonshifts.Name = "lbAfternoonshifts";
            this.lbAfternoonshifts.Size = new System.Drawing.Size(311, 134);
            this.lbAfternoonshifts.TabIndex = 9;
            // 
            // lbEveningShifts
            // 
            this.lbEveningShifts.FormattingEnabled = true;
            this.lbEveningShifts.Location = new System.Drawing.Point(711, 327);
            this.lbEveningShifts.Name = "lbEveningShifts";
            this.lbEveningShifts.Size = new System.Drawing.Size(311, 134);
            this.lbEveningShifts.TabIndex = 10;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(20, 279);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(108, 31);
            this.lb1.TabIndex = 11;
            this.lb1.Text = "Morning";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Afternoon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Evening";
            // 
            // ShiftScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 524);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.lbEveningShifts);
            this.Controls.Add(this.lbAfternoonshifts);
            this.Controls.Add(this.cbShiftType);
            this.Controls.Add(this.btnManagementShiftAssignEmployee);
            this.Controls.Add(this.lbMorningShifts);
            this.Controls.Add(this.lbManagementShiftEmployeesToAssign);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "ShiftScheduling";
            this.Text = "ShiftScheduling";
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
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}