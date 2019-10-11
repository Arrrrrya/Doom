using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace PersonalResourceContro {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        // 当前树的根节点
        TreeViewItem item = null;
        // 存放所有文件名,父目录名
        Dictionary<string, string> files = null;
        string fileName = "";
        string parentFileName = "";

        public MainWindow() {
            InitializeComponent();
            Initialize();
        }

        /// <summary>
        /// 初始化树节点选中事件及树结构重置
        /// </summary>
        private void Initialize() {
            // 选中事件
            this.treeView.SelectedItemChanged += TreeView_SelectedItemChanged;

            // 树结构重置
            if(treeView.Items != null) {
                treeView.Items.Clear();
                files = new Dictionary<string, string>();
            }
        }

        /// <summary>
        /// 树节点选中事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e) {
            string filePath = "";
            TreeViewItem currentItem = treeView.SelectedItem as TreeViewItem;
            string parentPath = "";
            if(currentItem != null) {
                if(currentItem.Parent.GetType() != typeof(TreeView)) {
                    TreeViewItem parentItem = currentItem.Parent as TreeViewItem;
                    parentPath = parentItem.Header.ToString();
                }
            }

            // 拼装文件路径
            if(treeView.SelectedItem.ToString().Contains(".")) {
                string current = currentItem.Header.ToString();
                if(parentPath != "") {
                    filePath = txtPath.Text + "\\" + parentPath + "\\" + current;
                } else {
                    filePath = txtPath.Text + "\\" + current;
                }

            }

            // 显示图片
            if(filePath.EndsWith("png") || filePath.EndsWith("jpg")) {
                image.Source = new BitmapImage(new Uri(filePath));
                image.Visibility = Visibility.Visible;
                richTextBox.Visibility = Visibility.Collapsed;
            }

            // 显示纯文本
            if(filePath.EndsWith("txt") || filePath.EndsWith("docx")) {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                using(fs) {
                    TextRange text = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                    text.Load(fs, DataFormats.Text);
                }
                richTextBox.Visibility = Visibility.Visible;
                image.Visibility = Visibility.Collapsed;
            }
        }

        /// <summary>
        /// 点击选择文件路径按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_choose_Click(object sender, RoutedEventArgs e) {
            // 每次选择文件夹目录时都会重置当前树结构
            Initialize();

            // 弹窗，选择文件夹
            System.Windows.Forms.FolderBrowserDialog folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                txtPath.Text = folderBrowserDialog.SelectedPath;
            }

            // 创建树结构
            CreateTreeView(txtPath.Text.Trim());
        }

        /// <summary>
        /// 绑定树结构
        /// </summary>
        /// <param name="v"></param>
        private void CreateTreeView(string path) {
            // 显示选择的文件夹
            item = new TreeViewItem() { Header = $"{getFileName(path)}" };
            treeView.Items.Add(item);

            // 获取所有文件名
            getAllDirector(path);

            // 将文件夹的名字放入list，便于之后添加到树节点
            List<string> menu = new List<string>();
            foreach(var file in files) {
                if(file.Value != getFileName(path) && !menu.Contains(file.Value)) {
                    menu.Add(file.Value);
                }
            }

            TreeViewItem currentItem = null;
            TreeViewItem tempItem = null;
            List<string> treeMenu = new List<string>();

            // 循环添加树的子节点目录
            foreach(string name in menu) {
                if(files.ContainsKey(name) && files[name] == getFileName(path)) {
                    currentItem = new TreeViewItem() { Header = $"{name}" };
                    item.Items.Add(currentItem);
                    treeMenu.Add(name);
                } else if(files.ContainsKey(name) && !(files[name] == getFileName(path))) {
                    for(int i = 0; i < item.Items.Count; i++) {
                        if(((TreeViewItem)item.Items[i]).Header.ToString() == files[name]) {
                            currentItem = (TreeViewItem)item.Items[i];
                            tempItem = new TreeViewItem() { Header = $"{name}" };
                            currentItem.Items.Add(tempItem);
                        }
                    }
                }
            }

            // 循环添加树的子节点文件
            foreach(var var in files) {
                if(!menu.Contains(var.Key)) {
                    for(int i = 0; i < item.Items.Count; i++) {
                        if(((TreeViewItem)item.Items[i]).Header.ToString() == var.Value) {
                            currentItem = (TreeViewItem)item.Items[i];
                            tempItem = new TreeViewItem() { Header = $"{var.Key}" };
                            currentItem.Items.Add(tempItem);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 递归获取文件名
        /// </summary>
        /// <param name="path"></param>
        public void getAllDirector(string path) {
            if(path != "") {
                DirectoryInfo dir = new DirectoryInfo(path);
                FileSystemInfo[] dirs = dir.GetFileSystemInfos();

                //遍历检索的文件和子目录
                foreach(FileSystemInfo file in dirs) {
                    if(file is DirectoryInfo && file.FullName != path) {
                        fileName = getFileName(file.FullName);
                        parentFileName = getParentFileName(file.FullName);
                        if(!files.ContainsKey(fileName)) {
                            files.Add(fileName, parentFileName);
                        }
                        //递归调用
                        getAllDirector(file.FullName);
                    } else {
                        fileName = getFileName(file.FullName);
                        parentFileName = getParentFileName(file.FullName);
                        if(!files.ContainsKey(fileName)) {
                            files.Add(fileName, parentFileName);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 获取文件父目录名
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string getParentFileName(string path) {
            string[] fileNames = path.Split('\\');
            return fileNames[fileNames.Length - 2];
        }

        /// <summary>
        /// 获取文件名
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string getFileName(string path) {
            string[] fileNames = path.Split('\\');
            return fileNames[fileNames.Length - 1];
        }
    }
}
