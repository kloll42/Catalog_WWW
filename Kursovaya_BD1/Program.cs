using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_BD1
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
            DB.connection = new MySql.Data.MySqlClient.MySqlConnection();
            DB.connection.ConnectionString = DB.dataconnect();
            DB.connection.Open();
            Application.Run(new Login());
            DB.connection.Close();
        }
    }
}
