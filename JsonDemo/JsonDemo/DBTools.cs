using System;
using System.Data.SQLite;

namespace JsonDemo {
    class DBTools
    {
        private static SQLiteConnection connection = CreateDatabaseConnection();
        
        //与指定的数据库(实际上就是一个文件)建立连接
        private static SQLiteConnection CreateDatabaseConnection()
        {
            string ConnecitonString = System.Configuration.ConfigurationManager.ConnectionStrings["ClientDBConn"].ConnectionString;
            return new SQLiteConnection(ConnecitonString);
        }

        // 打开数据库
        private static void Open(SQLiteConnection connection)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        // 获得SqlCommand对象
        public static SQLiteCommand getSQLiteCommand(string sql)
        {
            Open(connection);
            return new SQLiteCommand(sql, connection);
        }

        // 获得SQLiteDataReader对象
        public static SQLiteDataReader getSQLiteDataReader(SQLiteCommand command)
        {
            SQLiteDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return reader;
        }
            
    }
}
