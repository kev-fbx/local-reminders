using LocalReminders.Domain.Entities;

namespace LocalReminders.App.Interfaces
{
    public interface IReminderService
    {
        void AddReminder(Reminder reminder);
        IReadOnlyList<Reminder> GetAllReminders();
        IEnumerable<string> GetCategories();
    }
}
