using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSaver
{
    class database
    {
        public string insertToDatabase(List<KeyValuePair<string, string>> objectDB, string table)
        {
            string dataFields = null;
            string data = null;

            foreach (var item in objectDB)
            {
                dataFields += item.Key;
                dataFields += ", ";
                data += "@" + item.Key;
                data += ", ";
            }
            dataFields = dataFields.Remove(dataFields.Length - 2, 2);
            data = data.Remove(data.Length - 2, 2);

            string query = "INSERT INTO " + table + " (" + dataFields + ") VALUES (" + data + ")";

            SqlConnection conn = new SqlConnection(constants.connectionString);
            SqlCommand objectDBcmd = new SqlCommand(query, conn);

            foreach (var item in objectDB)
            {
                objectDBcmd.Parameters.AddWithValue("@" + item.Key, item.Value);
            }

            conn.Open();
            objectDBcmd.ExecuteNonQuery();
            conn.Close();
            return query;

        }

        public ArrayList getDataFromDatabase(string sql)
        {
            string query = sql;
            SqlConnection conn = new SqlConnection(constants.connectionString);
            SqlCommand objectDBcmd = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = objectDBcmd;

            DataTable tb = new DataTable();
            tb.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(tb);

            ArrayList arrayList = new ArrayList(tb.Rows.Count);
            foreach(DataRow row in tb.Rows)
            {
                arrayList.Add(row);
            }

            return arrayList;
        }

        public string updateToDatabase(List<KeyValuePair<string, string>> objectDB, string table, int id)
        {

            string dataFields = null;

            foreach (var item in objectDB)
            {
                dataFields += item.Key + " = @" + item.Key;
                dataFields += ", ";

            }
            dataFields = dataFields.Remove(dataFields.Length - 2, 2);
            string query = "UPDATE " + table + " SET " + dataFields + " WHERE id = @id";

            SqlConnection conn = new SqlConnection(constants.connectionString);
            SqlCommand objectDBcmd = new SqlCommand(query, conn);
            objectDBcmd.Parameters.AddWithValue("@id", id);
            foreach (var item in objectDB)
            {
                objectDBcmd.Parameters.AddWithValue("@" + item.Key, item.Value);
            }

            conn.Open();
            objectDBcmd.ExecuteNonQuery();
            conn.Close();
            return query;

        }

        public string deleteFromDatabase(string table, int id)
        {
            string query = "DELETE FROM " + table + "  WHERE id = @id";
            SqlConnection conn = new SqlConnection(constants.connectionString);
            SqlCommand credentialcmd = new SqlCommand(query, conn);
            credentialcmd.Parameters.AddWithValue("@id", id);
            conn.Open();
            credentialcmd.ExecuteNonQuery();
            conn.Close();
            return query;
        }

    }

    class Games
    {
        public string name { get; set; }
        public string image { get; set; }
        public string path { get; set; }
        public string savepath { get; set; }
    }

    class Saves
    {
        public string game_id { get; set; }
        public string path { get; set; }
        public string datetime { get; set; }
    }


}
