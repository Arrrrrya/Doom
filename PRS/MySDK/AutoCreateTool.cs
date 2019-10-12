using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySDK {
    public class AutoCreateTool {
        // 获得指定日期格式的日期字符串
        public static string getNowDate(string dateFormat) {
            return System.DateTime.Now.ToString(dateFormat);
        }

        // 获取文件序列号
        public static string getSeq() {
            return "FILE_" + getNowDate("yyyyMMdd_HHmmssffff");
        }
    }
}
