using LocalReminders.UI.Forms;
using LocalReminders.App.Services;
using LocalReminders.App.Interfaces;

namespace LocalReminders.UI
{
    public partial class MainForm : Form
    {
        private readonly IReminderService _reminderService;
        public MainForm()
        {
            InitializeComponent();
            _reminderService = new ReminderService();
        }

        private void Reminder_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddReminder_Click(object sender, EventArgs e)
        {
            ReminderDetailsForm reminderForm = new ReminderDetailsForm();
            
            if (reminderForm.ShowDialog() == DialogResult.OK)
            {
                
            }
        }
    }
}
