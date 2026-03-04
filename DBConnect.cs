using System.Data;
using System.Data.SqlClient;

public class DBConnect
{
    SqlConnection conn;

    public DBConnect()
    {
        conn = new SqlConnection(
          @"Data Source=DESKTOP-ACVJ7GL;Initial Catalog=quanlybanhang;Integrated Security=True");
    }

    public DataTable GetData(string sql)
    {
        SqlDataAdapter da = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
}