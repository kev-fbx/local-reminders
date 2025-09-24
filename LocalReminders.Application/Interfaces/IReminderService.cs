using LocalReminders.Domain.Entities;
using LocalReminders.App.DTO;

namespace LocalReminders.App.Interfaces
{
    public interface IReminderService
    {
        Task AddReminderAsync(string label, string? description, DateTime? dueDate, string? category);
        Task<List<ReminderDTO>> GetAllRemindersAsync();
    }
}
