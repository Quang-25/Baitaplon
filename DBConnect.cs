using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanHang
{
    public class DBConnect
    {
        string connStr = @"Data Source=PHAMVANTRUONG\VANTRUONG;
                   Initial Catalog=quanlybanhang;
                   Integrated Security=True;
                   TrustServerCertificate=True";
        public DataTable GetData(string query)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}