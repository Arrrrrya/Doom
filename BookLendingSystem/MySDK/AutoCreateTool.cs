using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySDK {
    public class AutoCreateTool {
        public static void Main(string[] args) {

            Trace.WriteLine(getNowDate("yyyyMMdd"));
            Trace.WriteLine(getBookID());
            Trace.WriteLine(getBookID());
            Trace.WriteLine(getBookID());
            Trace.WriteLine(getBookID());
            Trace.WriteLine(getBookID());
            Trace.WriteLine(getBookID());
            Trace.WriteLine(getBookID());
            Trace.WriteLine(getBookID());


            Trace.WriteLine(getNextBookInDate("19921203"));
            Trace.WriteLine(getNextBookInDate("19920131"));

            Console.ReadKey();

        }

        // 获得指定日期格式的日期字符串
        public static string getNowDate(string dateFormat) {
            return System.DateTime.Now.ToString(dateFormat);
        }

        // 获取图书编号
        public static string getBookID() {
            return "BK_" + getNowDate("yyyyMMdd_HHmmssffff");
        }

        // 获取借阅编号
        public static string getlendID() {
            return "LD_" + getNowDate("yyyyMMdd_HHmmssffff");
        }

        // 获取申请编号
        public static string getApplyID() {
            return "AP_" + getNowDate("yyyyMMdd_HHmmssffff");
        }

        // 自动续期到按期归还的日期下一个月28号
        public static string getNextBookInDate(string outDate) {
            int year = Convert.ToInt32(outDate.Substring(0, 4));
            int month = Convert.ToInt32(outDate.Substring(4, 2));

            int tempMonth = month + 1;
            if(tempMonth > 12) {
                year++;
                month = 1;
            } else {
                month++;
            }

            string yearStr = year < 10 ? ("0" + year) : ("" + year);
            string monthStr = month < 10 ? ("0" + month) : ("" + month);

            return yearStr + monthStr + "28";

        }
    }
}
