using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace 饮品店点餐收银系统
{
    internal class DataWork
    {
        private static string connstr = "Data Source=LAPTOP-LR1IJJBN;database=TeaManagement;Integrated Security=True";
        public static DataTable DataQuery(string str)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(str, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }
        public static int DataExcute(string str)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            int i = cmd.ExecuteNonQuery();
            conn.Close();
            return i;
        }
        public static int ExecuteScalar(string str)
        {
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(str, conn);
            int i = int.Parse(cmd.ExecuteScalar().ToString());
            conn.Close();
            return i;
        }
    }
}
