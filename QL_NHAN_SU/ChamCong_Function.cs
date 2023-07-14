using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHAN_SU
{
    public class ChamCong_Function
    {
        // đếm số ngày trong tháng

        //public static int Demsongaylamviectrongthang(int thang,int nam)
        //{
        //    int dem = 0;
        //    DateTime f = new DateTime(nam, thang, 1);
        //    int x = f.Month + 1;
        //    while (f.Month < x)
        //    {
        //        dem = dem + 1;
        //        if(f.DayOfWeek == DayOfWeek.Sunday)
        //        {
        //            dem = dem + 1;

        //        }
        //        f = f.AddDays(1);
        //    }
        //    return dem;
        //}
        public static int demngaycongtrongthang(int thang, int nam)
        {

            DateTime startDate = new DateTime(nam, thang, 1);
            int totalDays = startDate.AddMonths(1).Subtract(startDate).Days;
            int songaychunhat = Enumerable.Range(1, totalDays)
                .Select(item => new DateTime(nam, thang, item))
                .Where(date => date.DayOfWeek == DayOfWeek.Sunday)
                .Count();
            int result = DateTime.DaysInMonth(nam, thang) - songaychunhat;
            return result;

        }
        public static int laysongaytrongthang(int thang,int nam)
        {
            return DateTime.DaysInMonth(thang, nam);
        }
        public static string Laythutrongtuan(int nam,int thang, int ngay)
        {
            string thu = "";
            DateTime newDate = new DateTime(nam, thang, ngay);
            switch (newDate.DayOfWeek.ToString())
            {
                case "Monday":
                    thu = "Thứ Hai";
                    break;
                case "Tuesday":
                    thu = "Thứ Ba";
                    break;
                case "Wednesday":
                    thu = "Thứ Tư";
                    break;
                case "Thursday":
                    thu = "Thứ Năm";
                    break;
                case "Friday":
                    thu = "Thứ Sáu";
                    break;
                case "Saturday":
                    thu = "Thứ Bảy";
                    break;
                case "Sunday":
                    thu = "Chủ Nhật";
                    break;
            }
            return thu;
        }
        static SqlConnection con = new SqlConnection();
        public static void taoketnoi()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=QUAN_LY_NHAN_SU;Integrated Security=True";
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi : "+ex.Message);
            }
        }
        public static void dongketnoi()
        {
            con.Close();
        }
        public static DataTable GetData(string query)
        {
            taoketnoi();
            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(tb);
            dongketnoi();
            return tb;
        }
        public static DataSet GetDataSet(string query)
        {
            taoketnoi();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public static void exeQuery(string qr)
        {
            taoketnoi();
            SqlCommand cmd = new SqlCommand(qr, con);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dongketnoi();
        }
    }
}
