using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class MyFunction
    {
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
        public static int laysongaytrongthang(int thang, int nam)
        {
            return DateTime.DaysInMonth(thang, nam);
        }
    }
}
