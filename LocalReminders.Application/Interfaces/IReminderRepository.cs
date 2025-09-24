using LocalReminders.Domain.Entities;

namespace LocalReminders.App.Interfaces
{
    public interface IReminderRepository
    {
        Task AddAsync(Reminder reminder);
        Task<Reminder?> GetByIdAsync(Guid id);
        Task UpdateAsync(Reminder reminder);
        Task DeleteAsync(Guid id);
        Task<List<Reminder>> GetPendingRemindersAsync();
    }
}
