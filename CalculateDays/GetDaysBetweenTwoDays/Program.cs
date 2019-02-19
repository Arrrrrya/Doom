using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDaysBetweenTwoDays {
    class Program {
        static void Main(string[] args) {
            MyDate d1, d2;//起始日期和结束日期
            //起始日期：1999年5月10日
            d1.Year = 1999;
            d1.Month = 5;
            d1.Day = 10;
            //结束日期：2006年3月8日
            d2.Year = 2006;
            d2.Month = 3;
            d2.Day = 8;

            GetDaysFromOneDateToAnother GetDays = new GetDaysFromOneDateToAnother();

            //计算结果
            int days = GetDays.CalculateDaysOfTwoDate(d1, d2);
            String str = "{0}年{1}月{2}日到{3}年{4}月{5}日共有天数为：{6}";
            str = String.Format(str, d1.Year, d1.Month, d1.Day, d2.Year, d2.Month, d2.Day, days);
            Console.WriteLine(str);

            //使用系统自带方法
            Console.WriteLine("系统算法得出结果为：" + testDateTime());

            //点击任意键结束
            Console.WriteLine("\n点击任意键结束...");
            Console.ReadKey(true);
        }

        static double testDateTime() {
            DateTime d1 = new DateTime(1999, 5, 10);
            DateTime d2 = new DateTime(2006, 3, 8);
            double days = (d2 - d1).TotalDays;
            return days;
        }
    }
}
