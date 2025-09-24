using LocalReminders.App.Interfaces;
using LocalReminders.Domain.Entities;
using Npgsql;

namespace LocalReminders.Infrastructure.DAL
{
    public class PostgresReminderRepository : IReminderRepository
    {
        private readonly string _connectionString;

        public PostgresReminderRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task AddAsync(Reminder reminder)
        {
            await using NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            string query = @"INSERT INTO reminders 
                       (id, label, description, duedate, category, completed, lastupdated)
                       VALUES (@Id, @Label, @Description, @DueDate, @Category, @Completed, @LastUpdated)";

            await using NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", reminder.Id);
            command.Parameters.AddWithValue("@Label", reminder.Label);
            command.Parameters.AddWithValue("@Description", reminder.Description ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@DueDate", reminder.DueDate ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Category", reminder.Category ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@Completed", reminder.Completed);
            command.Parameters.AddWithValue("@LastUpdated", reminder.LastUpdated);

            await command.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            await using NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            string query = @"DELETE FROM reminders
                        WHERE id = @Id";

            await using NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            await command.ExecuteNonQueryAsync();
        }

        public Task<Reminder?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Reminder reminder)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reminder>> GetPendingRemindersAsync()
        {
            List<Reminder> reminders = [];

            await using NpgsqlConnection connection = new NpgsqlConnection(_connectionString);
            await connection.OpenAsync();

            string query = @" SELECT id, label, description, duedate, category, completed, lastupdated
                    FROM reminders
                    WHERE completed = FALSE
                    ORDER BY duedate NULLS LAST;";

            using NpgsqlCommand command = new NpgsqlCommand(query, connection);
            using NpgsqlDataReader reader = await command.ExecuteReaderAsync();
            
            while (await reader.ReadAsync())
            {
                Reminder reminder = new Reminder(
                    label: reader.GetString(reader.GetOrdinal("label")),
                    description: reader.IsDBNull(reader.GetOrdinal("description")) ? null : reader.GetString(reader.GetOrdinal("description")),
                    dueDate: reader.IsDBNull(reader.GetOrdinal("duedate")) ? null : reader.GetDateTime(reader.GetOrdinal("duedate")),
                    category: reader.IsDBNull(reader.GetOrdinal("category")) ? null : reader.GetString(reader.GetOrdinal("category"))
                );

                reminder.Id = reader.GetGuid(reader.GetOrdinal("id"));
                reminder.Completed = reader.GetBoolean(reader.GetOrdinal("completed"));
                reminder.LastUpdated = reader.GetDateTime(reader.GetOrdinal("lastupdated"));

                reminders.Add(reminder);
            }

            return reminders;
        }
    }
}
