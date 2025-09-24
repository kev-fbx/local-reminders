using System.Xml.Linq;

namespace LocalReminders.UI.Forms
{
    public partial class ReminderDetailsForm : Form
    {
        public ReminderDetailsForm()
        {
            InitializeComponent();
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

            AmPmComboBox.Items.AddRange(new string[] { "AM", "PM" });

            HourComboBox.SelectedIndex = 8;
            MinuteComboBox.SelectedIndex = 0;
            AmPmComboBox.SelectedIndex = 0;
        }

        private void ConfirmReminder_Click(object sender, EventArgs e)
        {
            string SelectedHour = HourComboBox.SelectedItem!.ToString()!;
            string SelectedMin = MinuteComboBox.SelectedItem!.ToString()!;
            string SelectedAmPm = AmPmComboBox.SelectedItem!.ToString()!;

            DateTime parsedTime = DateTime.Parse($"{SelectedMin}:{SelectedMin} {SelectedAmPm}");
        }

        private void ReminderForm_Load(object sender, EventArgs e)
        {

        }

        private void Notes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
