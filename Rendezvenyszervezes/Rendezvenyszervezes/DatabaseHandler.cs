using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendezvenyszervezes {
    public class DatabaseHandler {
        private readonly string connectionString;
        private MySqlConnection connection;

        public DatabaseHandler(string connectionString) {
            this.connectionString = connectionString;
            ConnectToDb();
        }
        public void ConnectToDb() {
            if (this.connectionString != null) {
                connection = new MySqlConnection(this.connectionString);
                connection.Open();
            } else {
                MessageBox.Show("Couldn't connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string[][] Query(string queryStr) {
            List<string[]> results = new List<string[]>();

            try {
                
                    using(MySqlCommand cmd = new MySqlCommand(queryStr, connection)) {
                        using(MySqlDataReader reader = cmd.ExecuteReader()) {
                            int columnCount = reader.FieldCount;

                            while(reader.Read()) {
                                string[] row = new string[columnCount];
                                for(int i = 0; i < columnCount; i++) {
                                    row[i] = reader.GetValue(i).ToString();
                                }
                                results.Add(row);
                            }
                        }
                    }
                
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Lorem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return results.ToArray();
        }
    }
}
