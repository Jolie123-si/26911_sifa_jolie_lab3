using System;
using System.Windows.Forms;
using RoomManagement.Data;
using RoomManagement.Views;

namespace RoomManagement
{
    static class Program
    {
        // The program starts here
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Create the database and tables (only the first time)
            try
            {
                DatabaseSetup.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not connect to the database.\n\n" + ex.Message +
                    "\n\nCheck the connection string in App.config.", "Database error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new LoginForm());
        }
    }
}
