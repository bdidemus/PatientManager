namespace PatientManager.Forms
{
    partial class BookNextAppDialog
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
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.cbAppTypeFri = new System.Windows.Forms.ComboBox();
            this.cbAppTypeThu = new System.Windows.Forms.ComboBox();
            this.cbAppTypeWed = new System.Windows.Forms.ComboBox();
            this.cbAppTypeTue = new System.Windows.Forms.ComboBox();
            this.dtFriday = new System.Windows.Forms.DateTimePicker();
            this.dtThursday = new System.Windows.Forms.DateTimePicker();
            this.dtWednesday = new System.Windows.Forms.DateTimePicker();
            this.dtTuesday = new System.Windows.Forms.DateTimePicker();
            this.dtMonday = new System.Windows.Forms.DateTimePicker();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weekOffset = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.cbLinkTimes = new System.Windows.Forms.CheckBox();
            this.cbAppTypeMon = new System.Windows.Forms.ComboBox();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.cbAppTypeFri);
            this.gbMain.Controls.Add(this.cbAppTypeThu);
            this.gbMain.Controls.Add(this.cbAppTypeWed);
            this.gbMain.Controls.Add(this.cbAppTypeTue);
            this.gbMain.Controls.Add(this.cbAppTypeMon);
            this.gbMain.Controls.Add(this.dtFriday);
            this.gbMain.Controls.Add(this.dtThursday);
            this.gbMain.Controls.Add(this.dtWednesday);
            this.gbMain.Controls.Add(this.dtTuesday);
            this.gbMain.Controls.Add(this.dtMonday);
            this.gbMain.Controls.Add(this.cbFriday);
            this.gbMain.Controls.Add(this.cbThursday);
            this.gbMain.Controls.Add(this.cbWednesday);
            this.gbMain.Controls.Add(this.cbTuesday);
            this.gbMain.Controls.Add(this.cbMonday);
            this.gbMain.Controls.Add(this.label2);
            this.gbMain.Controls.Add(this.weekOffset);
            this.gbMain.Controls.Add(this.label1);
            this.gbMain.Location = new System.Drawing.Point(12, 12);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(501, 201);
            this.gbMain.TabIndex = 0;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Book For";
            // 
            // cbAppTypeFri
            // 
            this.cbAppTypeFri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppTypeFri.FormattingEnabled = true;
            this.cbAppTypeFri.Location = new System.Drawing.Point(212, 170);
            this.cbAppTypeFri.Name = "cbAppTypeFri";
            this.cbAppTypeFri.Size = new System.Drawing.Size(275, 21);
            this.cbAppTypeFri.TabIndex = 27;
            // 
            // cbAppTypeThu
            // 
            this.cbAppTypeThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppTypeThu.FormattingEnabled = true;
            this.cbAppTypeThu.Location = new System.Drawing.Point(212, 144);
            this.cbAppTypeThu.Name = "cbAppTypeThu";
            this.cbAppTypeThu.Size = new System.Drawing.Size(275, 21);
            this.cbAppTypeThu.TabIndex = 27;
            // 
            // cbAppTypeWed
            // 
            this.cbAppTypeWed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppTypeWed.FormattingEnabled = true;
            this.cbAppTypeWed.Location = new System.Drawing.Point(212, 119);
            this.cbAppTypeWed.Name = "cbAppTypeWed";
            this.cbAppTypeWed.Size = new System.Drawing.Size(275, 21);
            this.cbAppTypeWed.TabIndex = 27;
            // 
            // cbAppTypeTue
            // 
            this.cbAppTypeTue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppTypeTue.FormattingEnabled = true;
            this.cbAppTypeTue.Location = new System.Drawing.Point(212, 93);
            this.cbAppTypeTue.Name = "cbAppTypeTue";
            this.cbAppTypeTue.Size = new System.Drawing.Size(275, 21);
            this.cbAppTypeTue.TabIndex = 27;
            // 
            // dtFriday
            // 
            this.dtFriday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtFriday.Location = new System.Drawing.Point(98, 171);
            this.dtFriday.Name = "dtFriday";
            this.dtFriday.ShowUpDown = true;
            this.dtFriday.Size = new System.Drawing.Size(88, 20);
            this.dtFriday.TabIndex = 26;
            this.dtFriday.ValueChanged += new System.EventHandler(this.dtMonday_ValueChanged);
            // 
            // dtThursday
            // 
            this.dtThursday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtThursday.Location = new System.Drawing.Point(98, 145);
            this.dtThursday.Name = "dtThursday";
            this.dtThursday.ShowUpDown = true;
            this.dtThursday.Size = new System.Drawing.Size(88, 20);
            this.dtThursday.TabIndex = 26;
            this.dtThursday.ValueChanged += new System.EventHandler(this.dtMonday_ValueChanged);
            // 
            // dtWednesday
            // 
            this.dtWednesday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtWednesday.Location = new System.Drawing.Point(98, 119);
            this.dtWednesday.Name = "dtWednesday";
            this.dtWednesday.ShowUpDown = true;
            this.dtWednesday.Size = new System.Drawing.Size(88, 20);
            this.dtWednesday.TabIndex = 26;
            this.dtWednesday.ValueChanged += new System.EventHandler(this.dtMonday_ValueChanged);
            // 
            // dtTuesday
            // 
            this.dtTuesday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTuesday.Location = new System.Drawing.Point(98, 93);
            this.dtTuesday.Name = "dtTuesday";
            this.dtTuesday.ShowUpDown = true;
            this.dtTuesday.Size = new System.Drawing.Size(88, 20);
            this.dtTuesday.TabIndex = 26;
            this.dtTuesday.ValueChanged += new System.EventHandler(this.dtMonday_ValueChanged);
            // 
            // dtMonday
            // 
            this.dtMonday.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtMonday.Location = new System.Drawing.Point(98, 67);
            this.dtMonday.Name = "dtMonday";
            this.dtMonday.ShowUpDown = true;
            this.dtMonday.Size = new System.Drawing.Size(88, 20);
            this.dtMonday.TabIndex = 26;
            this.dtMonday.ValueChanged += new System.EventHandler(this.dtMonday_ValueChanged);
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Location = new System.Drawing.Point(9, 176);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(54, 17);
            this.cbFriday.TabIndex = 3;
            this.cbFriday.Text = "Friday";
            this.cbFriday.UseVisualStyleBackColor = true;
            this.cbFriday.CheckedChanged += new System.EventHandler(this.cbMonday_CheckedChanged);
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Location = new System.Drawing.Point(9, 150);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(70, 17);
            this.cbThursday.TabIndex = 3;
            this.cbThursday.Text = "Thursday";
            this.cbThursday.UseVisualStyleBackColor = true;
            this.cbThursday.CheckedChanged += new System.EventHandler(this.cbMonday_CheckedChanged);
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Location = new System.Drawing.Point(9, 124);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(83, 17);
            this.cbWednesday.TabIndex = 3;
            this.cbWednesday.Text = "Wednesday";
            this.cbWednesday.UseVisualStyleBackColor = true;
            this.cbWednesday.CheckedChanged += new System.EventHandler(this.cbMonday_CheckedChanged);
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Location = new System.Drawing.Point(9, 98);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(67, 17);
            this.cbTuesday.TabIndex = 3;
            this.cbTuesday.Text = "Tuesday";
            this.cbTuesday.UseVisualStyleBackColor = true;
            this.cbTuesday.CheckedChanged += new System.EventHandler(this.cbMonday_CheckedChanged);
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Location = new System.Drawing.Point(9, 72);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(64, 17);
            this.cbMonday.TabIndex = 3;
            this.cbMonday.Text = "Monday";
            this.cbMonday.UseVisualStyleBackColor = true;
            this.cbMonday.CheckedChanged += new System.EventHandler(this.cbMonday_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "weeks, on";
            // 
            // weekOffset
            // 
            this.weekOffset.Location = new System.Drawing.Point(54, 28);
            this.weekOffset.Maximum = new decimal(new int[] {
            52,
            0,
            0,
            0});
            this.weekOffset.Name = "weekOffset";
            this.weekOffset.Size = new System.Drawing.Size(35, 20);
            this.weekOffset.TabIndex = 1;
            this.weekOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book in";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(357, 216);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(75, 23);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(438, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(525, 18);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // cbLinkTimes
            // 
            this.cbLinkTimes.AutoSize = true;
            this.cbLinkTimes.Checked = true;
            this.cbLinkTimes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLinkTimes.Location = new System.Drawing.Point(21, 220);
            this.cbLinkTimes.Name = "cbLinkTimes";
            this.cbLinkTimes.Size = new System.Drawing.Size(77, 17);
            this.cbLinkTimes.TabIndex = 27;
            this.cbLinkTimes.Text = "Link Times";
            this.cbLinkTimes.UseVisualStyleBackColor = true;
            // 
            // cbAppTypeMon
            // 
            this.cbAppTypeMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppTypeMon.FormattingEnabled = true;
            this.cbAppTypeMon.Location = new System.Drawing.Point(212, 66);
            this.cbAppTypeMon.Name = "cbAppTypeMon";
            this.cbAppTypeMon.Size = new System.Drawing.Size(275, 21);
            this.cbAppTypeMon.TabIndex = 27;
            // 
            // BookNextAppDialog
            // 
            this.AcceptButton = this.btnBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(827, 245);
            this.Controls.Add(this.cbLinkTimes);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.gbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookNextAppDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Next Appointment";
            this.Load += new System.EventHandler(this.BookNextAppDialog_Load);
            this.gbMain.ResumeLayout(false);
            this.gbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown weekOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtFriday;
        private System.Windows.Forms.DateTimePicker dtThursday;
        private System.Windows.Forms.DateTimePicker dtWednesday;
        private System.Windows.Forms.DateTimePicker dtTuesday;
        private System.Windows.Forms.DateTimePicker dtMonday;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.CheckBox cbLinkTimes;
        private System.Windows.Forms.ComboBox cbAppTypeFri;
        private System.Windows.Forms.ComboBox cbAppTypeThu;
        private System.Windows.Forms.ComboBox cbAppTypeWed;
        private System.Windows.Forms.ComboBox cbAppTypeTue;
        private System.Windows.Forms.ComboBox cbAppTypeMon;
    }
}