using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace PaymentRecorder
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<PaymentData> paymentTable { get; set; }
        string filePath { get; set; } = "c:\\PaymentRecord.txt";

        public MainWindow()
        {
            InitializeComponent();
            show();
        }

        #region 初始化显示列表
        private void show()
        {
            // DataGrid数据绑定
            paymentTable = new ObservableCollection<PaymentData>();
            dataGrid.ItemsSource = paymentTable;

            getAllRecords();
        }
        #endregion

        #region 窗口可拖动
        private void title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        #endregion

        #region 新增一条数据
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            PaymentData p = new PaymentData()
            {
                seq_no = paymentTable.Count > 0 ? ("" + (Convert.ToInt32(paymentTable[paymentTable.Count - 1].seq_no) + 1)) : ("" + 1),
                datetime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                payment = "0.00",
                comment = "null"
            };
            paymentTable.Add(p);
        }
        #endregion

        #region 删除当前行记录
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PaymentData item = dataGrid.SelectedCells[0].Item as PaymentData;
            paymentTable.Remove(item);
            //删除数据后必须重新绑定 否则会报错
            this.dataGrid.ItemsSource = paymentTable;
        }
        #endregion

        #region 绑定文本数据
        private void getAllRecords()
        {
            string records = readFileContent(filePath);
            try
            {
                string line;
                PaymentData p;
                double totalCost = 0;
                double payment = 0;
                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line != "")
                        {
                            string[] str = line.Split('\t');
                            p = new PaymentData()
                            {
                                seq_no = str[0],
                                datetime = str[1],
                                payment = str[2],
                                comment = str[3]
                            };
                            paymentTable.Add(p);
                            double.TryParse(p.payment, out payment);
                            totalCost += payment;
                        }
                    }
                }
                this.totalCost.Content = totalCost + "（元）";
            }
            catch (Exception)
            {
                MessageBox.Show("err founded，try again please！");
            }
        }
        #endregion

        #region 点击保存
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string content = "";
            double totalCost = 0;
            double payment = 0;
            foreach (PaymentData p in paymentTable)
            {
                content += (p.seq_no + "\t" + p.datetime + "\t" + p.payment + "\t" + p.comment + "\r\n");
                double.TryParse(p.payment, out payment);
                totalCost += payment;
            }
            this.totalCost.Content = totalCost + "（元）";
            clearFile(filePath);
            bool saveResult = writeToFile(filePath, content);
            if (saveResult)
            {
                MessageBox.Show("save sucecessfully!");
            }else
            {
                MessageBox.Show("save failed,try again please!");
            }
        }
        #endregion

        #region 写入到文件
        private bool writeToFile(string filePath, string fileContent)
        {
            try
            {
                File.AppendAllText(filePath, fileContent + "\n");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        #endregion

        #region 清空记录
        private void clearFile(string filePath)
        {
            try
            {
                File.Delete(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion

        #region 读取文本
        private string readFileContent(string filePath)
        {
            string fileContent = "";
            try
            {
                fileContent = File.ReadAllText(filePath);
            }
            catch (Exception)
            {
                try
                {
                    File.Create(filePath).Close();
                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.Message);
                }
            }
            return fileContent;
        }
        #endregion

        private void miniBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void closeBtn_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure to quit？", "", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void link_Click(object sender, RoutedEventArgs e)
        {
            Hyperlink link = sender as Hyperlink;
            Process.Start(new ProcessStartInfo(link.NavigateUri.AbsoluteUri));
        }
    }
}
