using LocalReminders.UI.Forms;
using LocalReminders.App.Interfaces;
using LocalReminders.App.DTO;

namespace LocalReminders.UI
{
    public partial class MainForm : Form
    {
        private readonly IReminderService _reminderService;
        public MainForm(IReminderService reminderService)
        {
            InitializeComponent();
            _reminderService = reminderService;
        }

        private void AddReminder_Click(object sender, EventArgs e)
        {
            ReminderDetailsForm reminderForm = new ReminderDetailsForm(_reminderService);
            reminderForm.ShowDialog();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            List<ReminderDTO> reminders = await _reminderService.GetAllRemindersAsync();
            LoadRemindersToForm(reminders);
        }

        private void LoadRemindersToForm(List<ReminderDTO> reminders)
        {
            RemindersFlowPanel.Controls.Clear();

            foreach (ReminderDTO reminder in reminders)
            {
                Panel panel = new Panel
                {
                    Width = ReminderGroupBox.ClientSize.Width - 10,
                    Height = 90,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(3),
                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                };

                Label label = new Label
                {
                    Text = $"{reminder.Label}",
                    Location = new Point(5, 5),
                    AutoSize = true,
                    Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold)
                };
                panel.Controls.Add(label);

                Label category = new Label
                {
                    Text = $"Category: {reminder.Category ?? ""}",
                    Location = new Point(5, 25),
                    AutoSize = true
                };
                panel.Controls.Add(category);

                Label dueDate = new Label
                {
                    Text = $"Due Date: {(reminder.DueDate?.ToString("G") ?? "")}",
                    Location = new Point(5, 45),
                    AutoSize = true
                };
                panel.Controls.Add(dueDate);

                if (!string.IsNullOrWhiteSpace(reminder.Description))
                {
                    var description = new Label
                    {
                        Text = $"Description: {reminder.Description}",
                        Location = new Point(5, 65),
                        AutoSize = true
                    };
                    panel.Controls.Add(description);
                }

                RemindersFlowPanel.Controls.Add(panel);
            }
        }
    }
}
