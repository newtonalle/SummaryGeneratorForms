using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace SummaryGeneratorForms
{
    public class Connection
    {
        static private string server = "localhost";
        static private string database = "sistema";
        static private string user = "root";
        static private string password = "";

        public MySqlConnection projectConnection = null;

        static private string databaseConnection = $"server={server};database={database};user id={user};password={password}";
    
        public MySqlConnection GetConnection()
        {
            projectConnection = new MySqlConnection(databaseConnection);
            return projectConnection;
        }

        public DataTable GetData(string sql)
        {
            // Prepare the table
            DataTable data = new DataTable();
            // Open Project Connection
            projectConnection.Open();
            // Prepare Command and Consultation System
            MySqlCommand command = new MySqlCommand(sql, projectConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            // Execute Command
            adapter.Fill(data);
            // Close Connection to preserve Database security
            projectConnection.Close();
            return data;
        }

        public void ChangeData(string sql)
        {
            // Open Project Connection
            projectConnection.Open();
            // Prepare Command and Consultation System
            MySqlCommand command = new MySqlCommand(sql, projectConnection);
            // Execute Command
            command.ExecuteNonQuery();
            // Close Connection to preserve Database security
            projectConnection.Close();
        }
    }
}
