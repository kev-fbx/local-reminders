using LocalReminders.App.Interfaces;
using LocalReminders.Domain.Entities;

namespace LocalReminders.App.Services
{
    public class ReminderService : IReminderService
    {
        private readonly List<Reminder> _reminders = new List<Reminder>();
        public void AddReminder(Reminder reminder)
        {
            _reminders.Add(reminder);
        }

        public IReadOnlyList<Reminder> GetAllReminders()
        {
            return _reminders.AsReadOnly();
        }

        public IEnumerable<string> GetCategories()
        {
            return _reminders
                .Where(r => !string.IsNullOrWhiteSpace(r.Category))
                .Select(r => r.Category!)
                .Distinct();
        }
    }
}
