using System;
using System.Data.SqlClient;

namespace MySDK {
    public class DBTools {
        // 数据库信息
        private static string conn = "Data Source=.;Initial Catalog=DB_book_lending;Integrated Security=True";
        private static SqlConnection sqlConnection = null;

        // 连接到数据库
        public static void connectToDB() {
            sqlConnection = new SqlConnection(conn);
            sqlConnection.Open();
        }

        // 断开数据库连接
        public static void disconnectToDB() {
            sqlConnection.Close();
        }

        // 获得SqlCommand对象
        public static SqlCommand getSqlCommand(String sql) {
            connectToDB();
            return new SqlCommand(sql, sqlConnection);
        }
    }
}
