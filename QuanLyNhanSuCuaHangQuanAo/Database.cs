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
        private static string connStr = "Data Source=DESKTOP-DAVINCI;Initial Catalog=QuanLyNhanSuCuaHangQuanAo;Integrated Security=True";

        public static void Execute(string sql, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        foreach (string key in parameters.Keys)
                        {
                            cmd.Parameters.Add(new SqlParameter(key, parameters[key]));
                        }
                    }
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataTable Query(string sql, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        foreach (string key in parameters.Keys)
                        {
                            cmd.Parameters.Add(new SqlParameter(key, parameters[key]));
                        }
                    }
                    using (SqlDataAdapter adapt = new SqlDataAdapter(cmd))
                    {
                        DataTable table = new DataTable();
                        adapt.Fill(table);
                        return table;
                    }
                }
            }
        }



        public static string getConn()
            {
            return connStr;
            }
        }

    }

