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
            LabelDescription = new Label();
            DescriptionTextBox = new TextBox();
            LabelDueDate = new Label();
            DatePicker = new MonthCalendar();
            HourComboBox = new ComboBox();
            MinuteComboBox = new ComboBox();
            AmPmComboBox = new ComboBox();
            LabelCategory = new Label();
            CategoryTextBox = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // Confirm
            // 
            Confirm.Dock = DockStyle.Fill;
            Confirm.Location = new Point(3, 464);
            Confirm.Name = "Confirm";
            Confirm.Size = new Size(273, 26);
            Confirm.TabIndex = 0;
            Confirm.Text = "Confirm";
            Confirm.UseVisualStyleBackColor = true;
            Confirm.Click += ConfirmReminder_Click;
            // 
            // LabelReminder
            // 
            LabelReminder.AutoSize = true;
            LabelReminder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelReminder.Location = new Point(3, 0);
            LabelReminder.Name = "LabelReminder";
            LabelReminder.Size = new Size(36, 15);
            LabelReminder.TabIndex = 2;
            LabelReminder.Text = "Label";
            // 
            // LabelTextBox
            // 
            LabelTextBox.Dock = DockStyle.Fill;
            LabelTextBox.Location = new Point(3, 18);
            LabelTextBox.Name = "LabelTextBox";
            LabelTextBox.Size = new Size(273, 23);
            LabelTextBox.TabIndex = 3;
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelDescription.Location = new Point(3, 88);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(40, 15);
            LabelDescription.TabIndex = 4;
            LabelDescription.Text = "Notes";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Dock = DockStyle.Fill;
            DescriptionTextBox.Location = new Point(3, 106);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(273, 121);
            DescriptionTextBox.TabIndex = 5;
            // 
            // LabelDueDate
            // 
            LabelDueDate.AutoSize = true;
            LabelDueDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelDueDate.Location = new Point(3, 230);
            LabelDueDate.Name = "LabelDueDate";
            LabelDueDate.Size = new Size(60, 15);
            LabelDueDate.TabIndex = 6;
            LabelDueDate.Text = "Due Date";
            // 
            // DatePicker
            // 
            DatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            DatePicker.Location = new Point(26, 290);
            DatePicker.Name = "DatePicker";
            DatePicker.TabIndex = 7;
            // 
            // HourComboBox
            // 
            HourComboBox.Dock = DockStyle.Fill;
            HourComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            HourComboBox.Location = new Point(3, 3);
            HourComboBox.Name = "HourComboBox";
            HourComboBox.Size = new Size(79, 23);
            HourComboBox.TabIndex = 8;
            // 
            // MinuteComboBox
            // 
            MinuteComboBox.Dock = DockStyle.Fill;
            MinuteComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MinuteComboBox.Location = new Point(88, 3);
            MinuteComboBox.Name = "MinuteComboBox";
            MinuteComboBox.Size = new Size(79, 23);
            MinuteComboBox.TabIndex = 9;
            // 
            // AmPmComboBox
            // 
            AmPmComboBox.Dock = DockStyle.Fill;
            AmPmComboBox.Location = new Point(173, 3);
            AmPmComboBox.Name = "AmPmComboBox";
            AmPmComboBox.Size = new Size(90, 23);
            AmPmComboBox.TabIndex = 10;
            // 
            // LabelCategory
            // 
            LabelCategory.AutoSize = true;
            LabelCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LabelCategory.Location = new Point(3, 44);
            LabelCategory.Name = "LabelCategory";
            LabelCategory.Size = new Size(57, 15);
            LabelCategory.TabIndex = 11;
            LabelCategory.Text = "Category";
            // 
            // CategoryTextBox
            // 
            CategoryTextBox.Dock = DockStyle.Fill;
            CategoryTextBox.FormattingEnabled = true;
            CategoryTextBox.Location = new Point(3, 62);
            CategoryTextBox.Name = "CategoryTextBox";
            CategoryTextBox.Size = new Size(273, 23);
            CategoryTextBox.TabIndex = 13;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(LabelTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(Confirm, 0, 9);
            tableLayoutPanel1.Controls.Add(CategoryTextBox, 0, 3);
            tableLayoutPanel1.Controls.Add(LabelReminder, 0, 0);
            tableLayoutPanel1.Controls.Add(LabelCategory, 0, 2);
            tableLayoutPanel1.Controls.Add(LabelDescription, 0, 4);
            tableLayoutPanel1.Controls.Add(LabelDueDate, 0, 6);
            tableLayoutPanel1.Controls.Add(DescriptionTextBox, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 7);
            tableLayoutPanel1.Controls.Add(DatePicker, 0, 8);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(279, 493);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 95F));
            tableLayoutPanel2.Controls.Add(HourComboBox, 0, 0);
            tableLayoutPanel2.Controls.Add(AmPmComboBox, 2, 0);
            tableLayoutPanel2.Controls.Add(MinuteComboBox, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 248);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(266, 30);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // ReminderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 515);
            Controls.Add(tableLayoutPanel1);
            Name = "ReminderDetailsForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New Reminder";
            Load += ReminderDetailsForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Confirm;
        private Label LabelReminder;
        private TextBox LabelTextBox;
        private Label LabelDescription;
        private TextBox DescriptionTextBox;
        private Label LabelDueDate;
        private MonthCalendar DatePicker;
        private ComboBox HourComboBox;
        private ComboBox MinuteComboBox;
        private ComboBox AmPmComboBox;
        private Label LabelCategory;
        private ComboBox CategoryTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}