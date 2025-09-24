namespace LocalReminders.UI.Forms
{
    partial class ReminderDetailsForm
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
            Confirm = new Button();
            LabelReminder = new Label();
            LabelTextBox = new TextBox();
            LabelNotes = new Label();
            NotesTextBox = new TextBox();
            LabelDueDate = new Label();
            DatePicker = new MonthCalendar();
            HourComboBox = new ComboBox();
            MinuteComboBox = new ComboBox();
            AmPmComboBox = new ComboBox();
            LabelCategory = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // Confirm
            // 
            Confirm.Location = new Point(14, 490);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(225, 23);
            Confirm.TabIndex = 0;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += ConfirmReminder_Click;
            // 
            // LabelReminder
            // 
            LabelReminder.AutoSize = true;
            LabelReminder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelReminder.Location = new Point(13, 9);
            LabelReminder.Name = "LabelReminder";
            LabelReminder.Size = new Size(36, 15);
            LabelReminder.TabIndex = 2;
            LabelReminder.Text = "Label";
            // 
            // LabelTextBox
            // 
            LabelTextBox.Location = new Point(13, 27);
            LabelTextBox.Name = "LabelTextBox";
            LabelTextBox.Size = new Size(226, 23);
            LabelTextBox.TabIndex = 3;
            // 
            // LabelNotes
            // 
            LabelNotes.AutoSize = true;
            LabelNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelNotes.Location = new Point(13, 119);
            LabelNotes.Name = "LabelNotes";
            LabelNotes.Size = new Size(40, 15);
            LabelNotes.TabIndex = 4;
            LabelNotes.Text = "Notes";
            // 
            // NotesTextBox
            // 
            NotesTextBox.Location = new Point(13, 137);
            NotesTextBox.Multiline = true;
            NotesTextBox.Name = "NotesTextBox";
            NotesTextBox.Size = new Size(226, 111);
            NotesTextBox.TabIndex = 5;
            NotesTextBox.TextChanged += Notes_TextChanged;
            // 
            // LabelDueDate
            // 
            LabelDueDate.AutoSize = true;
            LabelDueDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelDueDate.Location = new Point(13, 263);
            LabelDueDate.Name = "LabelDueDate";
            LabelDueDate.Size = new Size(60, 15);
            LabelDueDate.TabIndex = 6;
            LabelDueDate.Text = "Due Date";
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(13, 316);
            DatePicker.Name = "DatePicker";
            DatePicker.TabIndex = 7;
            // 
            // HourComboBox
            // 
            HourComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HourComboBox.Location = new Point(14, 281);
            HourComboBox.Name = "HourComboBox";
            HourComboBox.Size = new Size(60, 23);
            HourComboBox.TabIndex = 8;
            // 
            // MinuteComboBox
            // 
            MinuteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MinuteComboBox.Location = new Point(80, 281);
            MinuteComboBox.Name = "MinuteComboBox";
            MinuteComboBox.Size = new Size(60, 23);
            MinuteComboBox.TabIndex = 9;
            // 
            // AmPmComboBox
            // 
            AmPmComboBox.Location = new Point(146, 281);
            AmPmComboBox.Name = "AmPmComboBox";
            AmPmComboBox.Size = new Size(60, 23);
            AmPmComboBox.TabIndex = 10;
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCategory.Location = new Point(13, 61);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(57, 15);
            LabelCategory.TabIndex = 11;
            LabelCategory.Text = "Category";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 79);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(226, 23);
            comboBox1.TabIndex = 13;
            // 
            // ReminderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 530);
            Controls.Add(comboBox1);
            Controls.Add(LabelCategory);
            Controls.Add(AmPmComboBox);
            Controls.Add(MinuteComboBox);
            Controls.Add(HourComboBox);
            Controls.Add(DatePicker);
            Controls.Add(LabelDueDate);
            Controls.Add(NotesTextBox);
            Controls.Add(LabelNotes);
            Controls.Add(LabelTextBox);
            Controls.Add(LabelReminder);
            Controls.Add(Confirm);
            Name = "ReminderDetailsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Reminder";
            Load += ReminderForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Confirm;
        private Label LabelReminder;
        private TextBox LabelTextBox;
        private Label LabelNotes;
        private TextBox NotesTextBox;
        private Label LabelDueDate;
        private MonthCalendar DatePicker;
        private ComboBox HourComboBox;
        private ComboBox MinuteComboBox;
        private ComboBox AmPmComboBox;
        private Label LabelCategory;
        private ComboBox comboBox1;
    }
}