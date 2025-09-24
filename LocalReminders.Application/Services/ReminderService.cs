using LocalReminders.App.Interfaces;
using LocalReminders.App.DTO;
using LocalReminders.Domain.Entities;

namespace LocalReminders.App.Services
{
    public class ReminderService : IReminderService
    {
        private readonly IReminderRepository _repository;

        public ReminderService(IReminderRepository repository)
        {
            _repository = repository;
        }

        public async Task AddReminderAsync(string label, string? description = null, DateTime? dueDate = null, string? category = null)
        {
            Reminder reminder = new(label, description, dueDate, category);
            await _repository.AddAsync(reminder);
        }

        public async Task<List<ReminderDTO>> GetAllRemindersAsync()
        {
            List<Reminder> reminders = await _repository.GetPendingRemindersAsync();

            return reminders.Select(r => new ReminderDTO
            {
                Id = r.Id,
                Label = r.Label,
                Description = r.Description,
                DueDate = r.DueDate,
                Category = r.Category,
                Completed = r.Completed
            }).ToList();
        }
    }
}
