using Store.Domain;
using Store.Data;

namespace Store.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (StoreContext context = new StoreContext())
            {
                context.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}