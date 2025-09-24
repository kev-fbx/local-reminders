using LocalReminders.App.Interfaces;

namespace LocalReminders.UI.Forms
{
    public partial class ReminderDetailsForm : Form
    {

        private readonly IReminderService _reminderService;
        public ReminderDetailsForm(IReminderService reminderService)
        {
            InitializeComponent();
            _reminderService = reminderService;
            LoadOptions();
        }

        private void LoadOptions()
        {
            for (int i = 1; i <= 12; i++)
            {
                HourComboBox.Items.Add(i.ToString("D2"));
            }

            for (int i = 0; i < 60; i += 5)
            {
                MinuteComboBox.Items.Add(i.ToString("D2"));
            }

            AmPmComboBox.Items.AddRange(["AM", "PM"]);

            HourComboBox.SelectedIndex = 8;
            MinuteComboBox.SelectedIndex = 0;
            AmPmComboBox.SelectedIndex = 0;
        }

        private async void ConfirmReminder_Click(object sender, EventArgs e)
        {
            string label = LabelTextBox.Text;
            string? description = DescriptionTextBox.Text;
            string? category = CategoryTextBox.Text;

            int hour = int.Parse(HourComboBox.SelectedItem!.ToString()!);
            int minute = int.Parse(MinuteComboBox.SelectedItem!.ToString()!);
            string ampm = AmPmComboBox.SelectedItem!.ToString()!;

            if (ampm == "PM" && hour < 12) hour += 12;
            if (ampm == "AM" && hour == 12) hour = 0;

            DateTime selectedDate = DatePicker.SelectionStart.Date;
            DateTime dueDate = selectedDate.AddHours(hour).AddMinutes(minute);

            if (string.IsNullOrWhiteSpace(label))
            {
                MessageBox.Show("Label is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                await _reminderService.AddReminderAsync(label, description, dueDate, category);
                await _reminderService.GetAllRemindersAsync();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add reminder: {ex.Message}", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReminderDetailsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
