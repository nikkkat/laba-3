using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class DateService
    {
        public static void GetDay(string s)
        {
            string t = "";
            string r = "";
            string s1 = "";

            s1 += s[0];
            s1 += s[1];

            t += s[3];
            t += s[4];

            r += s[6];
            r += s[7];
            r += s[8];
            r += s[9];

            int day = Int32.Parse(s1);
            int month = Int32.Parse(t);
            int year = Int32.Parse(r);

            DateTime dt = new DateTime(year, month, day);
            Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);
        }

        public static void GetDaysSpan(int day, int month, int year)
        {
            int d = 5;
            int m = 4;
            int y = 2022;

            int da = Math.Abs(day - d);
            int mo = Math.Abs(month - m);
            int ye = Math.Abs(year - y);


            Console.WriteLine($"пройдёт {da} дней, {mo} месяцев, {ye} лет");
        }
    }
}
