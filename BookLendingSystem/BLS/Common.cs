using BLS.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 常用变量
/// </summary>
namespace BLS {
    class Common {
        /// <summary>
        /// 当前登录的用户
        /// </summary>
        public static User user {
            get; set;
        }
        
        /// <summary>
        /// 用户信息详情
        /// </summary>
        public static User userDetail {
            get; set;
        }
        
        /// <summary>
        /// 图书信息详情
        /// </summary>
        public static Book bookDetail {
            get; set;
        }
        
        /// <summary>
        /// 当前显示的列表名
        /// </summary>
        public static string currentDataGrid {
            get; set;
        }

        /// <summary>
        /// 图书借阅状态常量：可借
        /// </summary>
        public static string bookStatus_1 = "可借";

        /// <summary>
        /// 图书借阅状态常量：已被借出
        /// </summary>
        public static string bookStatus_2 = "已被借出";
    }
}
