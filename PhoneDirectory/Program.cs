using PhoneDirectory.Entities;

namespace PhoneDirectory
{
    internal static class Program
    {
        public static User user = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new PDirectory());
        }
    }
}