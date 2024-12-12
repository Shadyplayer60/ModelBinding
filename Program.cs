using System;
using System.Windows.Forms;

namespace ModelBinding
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create a new PersonListDataSource instance
            IPersonDataSource dataSource = new PersonListDataSource();

            // Pass the data source into the main form's constructor
            Application.Run(new Assignment5b(dataSource));
        }
    }
}
