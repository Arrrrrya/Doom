using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDaysBetweenTwoDays {
    public class GetDaysFromOneDateToAnother {
        //存放每月天数
        private static int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        //计算两个指定日期间的天数
        public int CalculateDaysOfTwoDate(MyDate beginDate, MyDate endDate) {
            int days = 0;
            days = CalculateDaysOfTwoYear(beginDate.Year, endDate.Year);
            if(beginDate.Year == endDate.Year) {
                days += CalculateDaysOfTwoMonth(beginDate, endDate, true);
            } else {
                days += CalculateDaysOfTwoMonth(beginDate, endDate, false);
            }
            return days;
        }

        //计算两个年份之间的整年天数，不足一年的去掉
        private int CalculateDaysOfTwoYear(int beginYear, int endYear) {
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

        //计算起始日期那一年和结束日期那一年的天数
        private int CalculateDaysOfTwoMonth(MyDate beginDate, MyDate endDate, bool IsInOneYear) {
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
        private bool IsLeapYear(int year) {
            //1.能被400整除，是闰年
            //2.能被4整除，但不能被100整除，是闰年
            if((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)) {
                return true;
            }
            return false;
        }
    }
}
