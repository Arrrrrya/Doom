using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// title:计算两个固定日期间的天数
/// author:syl
/// </summary>
namespace CalculateDays {
    class Program {

        //存放每月天数
        static int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

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
            //计算结果
            int days = CalculateDaysOfTwoDate(d1, d2);

            String str = "{0}年{1}月{2}日到{3}年{4}月{5}日共有天数为：";
            str = String.Format(str, d1.Year, d1.Month, d1.Day, d2.Year, d2.Month, d2.Day);
            Console.WriteLine(str + days);

            //点击任意键结束
            Console.WriteLine("点击任意键结束...");
            Console.ReadKey(true);
        }

        //计算两个日期之间的整天数
        static int CalculateDaysOfTwoDate(MyDate beginDate, MyDate endDate) {
            int days = 0;
            days = CalculateDaysOfTwoYear(beginDate.Year, endDate.Year);
            if(beginDate.Year == endDate.Year) {
                days += CalculateDaysOfTwoMonth(beginDate, endDate, true);
            } else {
                days += CalculateDaysOfTwoMonth(beginDate, endDate, false);
            }
            return days;
        }

        //计算两年之间的整年天数，不足一年的去掉
        static int CalculateDaysOfTwoYear(int beginYear, int endYear) {
            int days = 0;
            for(int i = beginYear + 1; i < endYear; i++) {
                if(IsLeapYear(i)) {
                    days += 366;
                } else {
                    days += 365;
                }
            }
            return days;
        }

        //根据两个日期，计算出这两个日期之间的天数
        static int CalculateDaysOfTwoMonth(MyDate beginDate, MyDate endDate, bool IsInOneYear) {
            int beginDays = 0;
            int endDays = 0;
            // 计算起始年份的月份天数总和
            for(int i = beginDate.Month + 1; i <= 12; i++) {
                beginDays += months[i];
            }
            beginDays += (months[beginDate.Month] - beginDate.Day);

            // 计算结束年份的月份天数总和
            for(int i = 1; i < endDate.Month; i++) {
                endDays += months[i];
            }
            endDays += endDate.Day;

            if(IsInOneYear) {
                return endDays - beginDays;
            }
            return beginDays + endDays;
        }

        //根据年判断是否是闰年
        static bool IsLeapYear(int year) {
            //1.能被400整除，是闰年
            //2.能被4整除，但不能被100整除，是闰年
            if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) {
                return true;
            }
            return false;
        }
    }
}
