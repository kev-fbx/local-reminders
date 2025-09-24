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
            CategoryTreeView = new TreeView();
            RightPanelTableLayout = new TableLayoutPanel();
            AddReminder = new Button();
            ReminderGroupBox = new GroupBox();
            RemindersFlowPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            RightPanelTableLayout.SuspendLayout();
            ReminderGroupBox.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(RightPanelTableLayout);
            splitContainer1.Size = new Size(550, 522);
            splitContainer1.SplitterDistance = 189;
            splitContainer1.TabIndex = 0;
            // 
            // CategoryTreeView
            // 
            CategoryTreeView.Dock = DockStyle.Fill;
            CategoryTreeView.Location = new Point(0, 0);
            CategoryTreeView.Name = "CategoryTreeView";
            CategoryTreeView.Size = new Size(189, 522);
            CategoryTreeView.TabIndex = 0;
            // 
            // RightPanelTableLayout
            // 
            RightPanelTableLayout.ColumnCount = 1;
            RightPanelTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            RightPanelTableLayout.Controls.Add(AddReminder, 0, 0);
            RightPanelTableLayout.Controls.Add(ReminderGroupBox, 0, 1);
            RightPanelTableLayout.Dock = DockStyle.Fill;
            RightPanelTableLayout.Location = new Point(0, 0);
            RightPanelTableLayout.Name = "RightPanelTableLayout";
            RightPanelTableLayout.RowCount = 2;
            RightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 7.662835F));
            RightPanelTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 92.3371658F));
            RightPanelTableLayout.Size = new Size(357, 522);
            RightPanelTableLayout.TabIndex = 0;
            // 
            // AddReminder
            // 
            AddReminder.Dock = DockStyle.Fill;
            AddReminder.Location = new Point(3, 3);
            AddReminder.Name = "AddReminder";
            AddReminder.Size = new Size(351, 34);
            AddReminder.TabIndex = 1;
            AddReminder.Text = "Add Reminder";
            AddReminder.UseVisualStyleBackColor = true;
            AddReminder.Click += AddReminder_Click;
            // 
            // ReminderGroupBox
            // 
            ReminderGroupBox.Controls.Add(RemindersFlowPanel);
            ReminderGroupBox.Dock = DockStyle.Fill;
            ReminderGroupBox.Location = new Point(3, 43);
            ReminderGroupBox.Name = "ReminderGroupBox";
            ReminderGroupBox.Size = new Size(351, 476);
            ReminderGroupBox.TabIndex = 0;
            ReminderGroupBox.TabStop = false;
            ReminderGroupBox.Text = "Reminders";
            // 
            // RemindersFlowPanel
            // 
            RemindersFlowPanel.AutoScroll = true;
            RemindersFlowPanel.Dock = DockStyle.Fill;
            RemindersFlowPanel.FlowDirection = FlowDirection.TopDown;
            RemindersFlowPanel.Location = new Point(3, 19);
            RemindersFlowPanel.Name = "RemindersFlowPanel";
            RemindersFlowPanel.Size = new Size(345, 454);
            RemindersFlowPanel.TabIndex = 0;
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
            RightPanelTableLayout.ResumeLayout(false);
            ReminderGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView CategoryTreeView;
        private GroupBox ReminderGroupBox;
        private Button AddReminder;
        private TableLayoutPanel RightPanelTableLayout;
        private FlowLayoutPanel RemindersFlowPanel;
    }
}
