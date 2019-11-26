using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows;

namespace JsonDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private string sql = System.Configuration.ConfigurationManager.AppSettings.Get("BehaviorSelect");
        private string[] fields = { "ID", "IDUser", "IDResource", "DateUpload", "BlnBackup", "Remark" };
        private DataTable dt = new DataTable();

        public MainWindow()
        {
            InitializeComponent();

            foreach (string fieldName in fields)
            {
                dt.Columns.Add(fieldName, Type.GetType("System.String"));
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SQLiteCommand command = DBTools.getSQLiteCommand(sql);
            SQLiteDataReader reader = DBTools.getSQLiteDataReader(command);
            
            if (reader != null)
            {
                DataRow dr;
                while (reader.Read())
                {
                    dr = dt.NewRow();
                    foreach (string fieldName in fields)
                    {
                        dr[fieldName] = reader[fieldName].ToString();
                    }
                    dt.Rows.Add(dr);
                }
            }

            string jsonString = dt.Rows.Count > 0 ? JsonConvert.SerializeObject(dt) : "";
            Console.WriteLine(jsonString);
            Console.WriteLine(dt.Rows.Count);
        }
    }
}
