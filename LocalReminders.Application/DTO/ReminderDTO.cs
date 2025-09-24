namespace LocalReminders.App.DTO
{
    public class ReminderDTO
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public DateTime? DueDate { get; set; }
        public bool Completed { get; set; }
    }
}
