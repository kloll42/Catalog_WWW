using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System.Data;
using System.Windows.Forms;
using System.IO;


namespace Kursovaya_BD1
{
    

    public class DB
    {
        public static MySqlConnection connection = new MySqlConnection();

        public static string dataconnect()
        {
            StreamReader sdsda = new StreamReader("Data.txt");
            string conndata = sdsda.ReadLine();
            return conndata;
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public List<string> SelectDate(string Text)
        {
            List<DateTime> request = new List<DateTime>();
            List<string> result = new List<string>();
            MySqlCommand command = new MySqlCommand(Text, connection);

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            DbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    request.Add(reader.GetDateTime(i));
                }
            }
            reader.Close();
            command.Dispose();
            foreach (DateTime datetime in request)
                result.Add(datetime.ToString("yyyy-MM-dd"));
            return result;


        }

        public List<string> Select(string Text)
        {
            List<string> results = new List<string>();

            MySqlCommand command = new MySqlCommand(Text, connection);

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            DbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    results.Add(reader.GetString(i));
            }
            reader.Close();
            command.Dispose();
            return results;
        }

        public List<int> SelectID(string Text)
        {
            List<int> results = new List<int>();

            MySqlCommand command = new MySqlCommand(Text, connection);

            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();

            DbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    results.Add(reader.GetInt32(i));
            }
            reader.Close();
            command.Dispose();
            return results;
        }
    }
}
