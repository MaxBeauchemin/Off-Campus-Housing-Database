using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OffCampusHousingDatabase
{
    class DatabaseHelper
    {
        String connectionString;

        public DatabaseHelper(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public ArrayList DatabaseSelect(String tableName)
        {
            return DatabaseSelect(tableName, "");
        }

        public ArrayList DatabaseSelect(String tableName, String whereClause)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            String sql = "SELECT * FROM `" + tableName + "` ";

            if (!whereClause.Equals(""))
            {
                sql += " WHERE " + whereClause;
            }

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();

            //number of columns
            int numCols = reader.FieldCount;

            ArrayList output = new ArrayList();

            while (reader.Read())
            {
                String[] row = new String[numCols];
                for (int i = 0; i < numCols; i++)
                {
                    row[i] = (reader.GetString(i));
                }
                output.Add(row);
            }

            conn.Close();

            return output;
        }

        public void DatabaseInsert(String tableName, String Columns, String values)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            String sql = "INSERT INTO `" + tableName + "`(" + Columns + ") VALUES (" + values + ")";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.ExecuteReader();
            conn.Close();
        }

        public void DatabaseUpdate(String tableName, String updateColumns, String whereClause)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            String sql = "UPDATE `" + tableName + "` SET " + updateColumns + " WHERE " + whereClause;

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.ExecuteReader();
            conn.Close();
        }

        private void DatabaseDelete(String tableName, String whereClause)
        {

            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            String sql = "DELETE FROM `" + tableName + "` WHERE " + whereClause;

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.ExecuteReader();
            conn.Close();
        }
    }
}