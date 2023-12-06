using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSuCuaHangQuanAo
{
    internal class Database
    {
        private static string connStr = "Data Source=21AK22-COM\\SERVER;Initial Catalog=QuanLyNhanSuCuaHangQuanAo;Integrated Security=True";
        private static SqlConnection conn = new SqlConnection(connStr);

        public static void Execute(string sql, Dictionary<string, object> parameters = null)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (parameters != null)
            {
                foreach (string key in parameters.Keys)
                {
                    cmd.Parameters.Add(new SqlParameter(key, parameters[key]));
                }
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static DataTable Query(string sql, Dictionary<string, object> parameters = null)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (parameters != null)
            {
                foreach (string key in parameters.Keys)
                {
                    cmd.Parameters.Add(new SqlParameter(key, parameters[key]));
                }
            }
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapt.Fill(table);
            conn.Close();
            return table;
        }
    }
}
