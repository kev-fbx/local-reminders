namespace LocalReminders.Domain.Entities
{
    public class Reminder
    {
        public Guid Id { get; private set; }
        public required string Label { get; set; }
        public DateTime DueDate { get; private set; }
        public string? Description { get; private set; }
        public string? Category { get; private set; }
        public bool Completed { get; private set; }
        public DateTime LastUpdated { get; private set; }

        private Reminder() { }

        public Reminder(string label, DateTime dueDate, string? description = null, string? category = null)
        {
            Id = Guid.NewGuid();
            Label = label;
            DueDate = dueDate;
            Description = description;
            Category = category;
            Completed = false;
            LastUpdated = DateTime.UtcNow;
        }

        public void MarkComplete()
        {
            Completed = true;
            LastUpdated = DateTime.UtcNow;
        }
    }
}
