using DotNetEnv;
using LocalReminders.App.Interfaces;
using LocalReminders.App.Services;
using LocalReminders.Infrastructure.DAL;

namespace LocalReminders.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Env.Load();

            string host = Env.GetString("DB_HOST");
            string port = Env.GetString("DB_PORT");
            string name = Env.GetString("DB_NAME");
            string user = Env.GetString("DB_USER");
            string pass = Env.GetString("DB_PASS");

            string connectionString = $"Host={host};Port={port};Database={name};Username={user};Password={pass}";

            IReminderRepository reminderRepository = new PostgresReminderRepository(connectionString);
            IReminderService reminderService = new ReminderService(reminderRepository);

            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.Run(new MainForm(reminderService));
        }
    }
}