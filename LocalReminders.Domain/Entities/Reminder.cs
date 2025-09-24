namespace LocalReminders.Domain.Entities
{
    public class Reminder
    {
        public Guid Id { get; set; }
        public string Label { get; set; }
        public DateTime? DueDate { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public bool Completed { get; set; } = false;
        public DateTime LastUpdated { get; set; }

        public Reminder(string label, string? description = null, DateTime? dueDate = null, string? category = null)
        {
            Id = Guid.NewGuid();
            Label = label;
            DueDate = dueDate;
            Description = description;
            Category = category;
            Completed = false;
            LastUpdated = DateTime.UtcNow;
        }

        private Reminder() { }

        public void MarkComplete()
        {
            Completed = true;
            LastUpdated = DateTime.UtcNow;
        }
    }
}
