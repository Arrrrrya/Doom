using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EveryDay {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        string filePath = "c:\\";
        string fileName = "";

        public MainWindow() {
            InitializeComponent();
            date_time.Content = DateTime.Now.ToString("yyyy-MM-dd");
            fileName = findFile(filePath);
            user_name.Content = fileName != "" ? fileName.Split(' ')[1] : "用户名";
        }

        #region 点击用户名的操作
        private void user_name_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            if(user_name.Content.ToString() != "用户名") {
                if(what_i_write_today.Text != "") {
                    MessageBoxResult result = MessageBox.Show("是否丢弃当前输入的内容？", "警告", MessageBoxButton.YesNo);
                    if(result == MessageBoxResult.Yes) {
                        what_i_write_today.Text = readFileContent(filePath, fileName);
                    }
                } else {
                    what_i_write_today.Text = readFileContent(filePath, fileName);
                }
            } else {
                user_name.Visibility = Visibility.Collapsed;
                name_canvas.Visibility = Visibility.Visible;
            }
        }
        #endregion

        #region 修改用户名的确认与取消
        private void name_confirm_Click(object sender, RoutedEventArgs e) {
            if(name_textBox.Text == "用户名") {
                MessageBox.Show("不能使用\"用户名\"作为用户名！");
                return;
            }
            MessageBoxResult result = MessageBox.Show("确定使用\"" + name_textBox.Text + "\"作为用户名吗？", "提示", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes) {
                fileName = "everyday " + name_textBox.Text + " " + ".txt";
                try {
                    File.Create(filePath + fileName).Close();
                } catch(Exception e1) {
                    Console.WriteLine(e1.Message);
                }

                user_name.Content = name_textBox.Text;
                user_name.Visibility = Visibility.Visible;
                name_canvas.Visibility = Visibility.Collapsed;
            }
        }
        private void name_cancel_Click(object sender, RoutedEventArgs e) {
            user_name.Visibility = Visibility.Visible;
            name_canvas.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region 显示和隐藏名言警句
        private void tip_panel_MouseRightButtonUp(object sender, MouseButtonEventArgs e) {
            Canvas.SetLeft(hide_tip, Mouse.GetPosition(e.Source as FrameworkElement).X);
            Canvas.SetTop(hide_tip, Mouse.GetPosition(e.Source as FrameworkElement).Y + SystemParameters.CaptionHeight);
            hide_tip.Visibility = Visibility.Visible;
        }
        private void tip_panel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            hide_tip.Visibility = Visibility.Collapsed;
        }
        private void hide_tip_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            tip_panel.Visibility = Visibility.Collapsed;
            hide_tip.Visibility = Visibility.Collapsed;
        }
        #endregion

        #region 登录时查找用户保存的记录
        private string findFile(string filePath) {
            DirectoryInfo di = new DirectoryInfo(filePath);
            foreach(FileInfo fi in di.GetFiles()) {
                if(fi.Name.StartsWith("everyday")) {
                    return fi.Name;
                }
            }
            return "";
        }
        #endregion

        #region 保存与清空操作
        private void btn_save_Click(object sender, RoutedEventArgs e) {
            if(what_i_write_today.Text != "") {
                if(user_name.Content.ToString() == "用户名") {
                    MessageBox.Show("请先设置用户名");
                    return;
                }
                MessageBoxResult result = MessageBox.Show("是否要保存？", "提示", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes) {
                    string fileContent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\r\n" + what_i_write_today.Text;
                    if(writeToFile(filePath, fileName, fileContent)) {
                        MessageBox.Show("保存成功");
                        what_i_write_today.Text = "";
                    } else {
                        MessageBox.Show("由于未知的原因，保存失败，请再次尝试保存。");
                    }
                }
            }
        }
        private void btn_reset_Click(object sender, RoutedEventArgs e) {
            if(what_i_write_today.Text != "") {
                MessageBoxResult result = MessageBox.Show("确定要清空内容吗？", "警告", MessageBoxButton.YesNo);
                if(result == MessageBoxResult.Yes) {
                    what_i_write_today.Text = "";
                }
            }
        }
        #endregion

        #region 追加写入到文件
        private bool writeToFile(string filePath, string fileName, string fileContent) {
            try {
                //File.Create(filePath + fileName).Close();
                File.AppendAllText(filePath + fileName, fileContent + "\r\n\r\n");
                return true;
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        #endregion

        #region 读取用户保存的历史内容
        private string readFileContent(string filePath, string fileName) {
            return File.ReadAllText(filePath + fileName);
        }
        #endregion
    }
}
