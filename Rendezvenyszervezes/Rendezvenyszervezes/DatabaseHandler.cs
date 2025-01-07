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

        public DatabaseHandler(string connectionString) {
            this.connectionString = connectionString;
        }

        public string[][] Query(string queryStr) {
            List<string[]> results = new List<string[]>();

            try {
                using(MySqlConnection conn = new MySqlConnection(connectionString)) {
                    conn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(queryStr, conn)) {
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
                }
            } catch(Exception ex) {
                MessageBox.Show($"Error: {ex.Message}", "Lorem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return results.ToArray();
        }
    }
}
