using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TreeViewDemo.ViewModel;

namespace TreeViewDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        MainWindowViewModel viewModel = new MainWindowViewModel();
        List<FileTreeModel> fileTreeData = new List<FileTreeModel>();
        public MainWindow() {
            InitializeComponent();
        }
        /// <summary>
        /// 每一天照片统计
        /// </summary>
        public static int total = 0;
        /// <summary>
        /// 获取照片目录集合
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public List<FileTreeModel> GetAllFiles(DirectoryInfo dir, FileTreeModel d) {
            List<FileTreeModel> FileList = new List<FileTreeModel>();
            FileInfo[] allFile = dir.GetFiles();
            total = allFile.Count();
            foreach(FileInfo fi in allFile)
                d.Subitem.Add(new FileTreeModel() { FileName = fi.Name, FilePath = fi.FullName, FileType = (int)FieleTypeEnum.Picture, Icon = "../refresh/picture.ico" });

            DirectoryInfo[] allDir = dir.GetDirectories();
            foreach(DirectoryInfo dif in allDir) {
                FileTreeModel fileDir = new FileTreeModel() { FileName = dif.Name, FilePath = dif.FullName, FileType = (int)FieleTypeEnum.Folder, Icon = "../refresh/folder.ico" };
                GetAllFiles(dif, fileDir);
                fileDir.SubitemCount = string.Format($"({total})");
                FileList.Add(fileDir);

            }
            return FileList;
        }
        /// <summary>
        /// Tab选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(e.Source is TabControl) {
                if(e.AddedItems != null && e.AddedItems.Count > 0) {
                    if(e.AddedItems[0] is TabItem) {
                        TabItem tabItem = e.AddedItems[0] as TabItem;
                        if(tabItem.Header.ToString() == "过磅记录") {

                        }
                        if(tabItem.Header.ToString() == "照片预览") {
                            string dataDir = AppDomain.CurrentDomain.BaseDirectory + "ImageLogs\\";

                            fileTreeData = GetAllFiles(new System.IO.DirectoryInfo(dataDir), new FileTreeModel()).OrderByDescending(s => s.FileName).ToList();
                            this.departmentTree.ItemsSource = fileTreeData;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 文件树选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void departmentTree_PreviewMouseUp(object sender, MouseButtonEventArgs e) {
            try {
                if(departmentTree.SelectedItem != null) {
                    FileTreeModel selectedTnh = departmentTree.SelectedItem as FileTreeModel;
                    viewModel.Model.SelectFileleName = selectedTnh.FileName;

                    if(selectedTnh.FileType == (int)FieleTypeEnum.Picture) {
                        BitmapImage imagesouce = new BitmapImage();
                        imagesouce = new BitmapImage(new Uri(selectedTnh.FilePath));//Uri("图片路径")
                        MyImage.Source = imagesouce.Clone();
                    }
                }
            } catch(Exception ex) {
                MessageBox.Show(ex.ToString());
            }


        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            // 绑定数据源
            this.DataContext = viewModel;
        }


    }
}