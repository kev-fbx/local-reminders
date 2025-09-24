namespace LocalReminders.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            AddReminder = new Button();
            CategoryTreeView = new TreeView();
            ReminderGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(CategoryTreeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(550, 522);
            splitContainer1.SplitterDistance = 195;
            splitContainer1.TabIndex = 0;
            // 
            // AddReminder
            // 
            AddReminder.Dock = DockStyle.Fill;
            AddReminder.Location = new Point(3, 3);
            AddReminder.Name = "AddReminder";
            AddReminder.Size = new Size(345, 34);
            AddReminder.TabIndex = 1;
            AddReminder.Text = "Add Reminder";
            AddReminder.UseVisualStyleBackColor = true;
            AddReminder.Click += AddReminder_Click;
            // 
            // CategoryTreeView
            // 
            CategoryTreeView.Dock = DockStyle.Fill;
            CategoryTreeView.Location = new Point(0, 0);
            CategoryTreeView.Name = "CategoryTreeView";
            CategoryTreeView.Size = new Size(195, 522);
            CategoryTreeView.TabIndex = 0;
            // 
            // ReminderGroupBox
            // 
            ReminderGroupBox.Dock = DockStyle.Fill;
            ReminderGroupBox.Location = new Point(3, 43);
            ReminderGroupBox.Name = "ReminderGroupBox";
            ReminderGroupBox.Size = new Size(345, 476);
            ReminderGroupBox.TabIndex = 0;
            ReminderGroupBox.TabStop = false;
            ReminderGroupBox.Text = "Reminders";
            ReminderGroupBox.Enter += Reminder_Enter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(AddReminder, 0, 0);
            tableLayoutPanel1.Controls.Add(ReminderGroupBox, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.662835F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.3371658F));
            tableLayoutPanel1.Size = new Size(351, 522);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 522);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Reminders";
            Load += MainForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView CategoryTreeView;
        private GroupBox ReminderGroupBox;
        private Button AddReminder;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
