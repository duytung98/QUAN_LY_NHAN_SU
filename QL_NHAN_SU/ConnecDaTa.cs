using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_NHAN_SU
{
    public class ConnecDaTa
    {
        public SqlConnection conn;
        public void connect()
        {
            string strCon = @"Data Source=.;Initial Catalog=QUAN_LY_NHAN_SU;Integrated Security=True";
            try
            {
                conn = new SqlConnection(strCon);
                conn.Open();
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi: " + ex.Message);
            }
        }
        public void disconnect()
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }
        public Boolean exeSQL(string cmd)
        {
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
