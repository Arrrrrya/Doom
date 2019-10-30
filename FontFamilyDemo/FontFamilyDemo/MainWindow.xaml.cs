using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FontFamilyDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        public void win_LoadedEvent(object sender, RoutedEventArgs e) {
            foreach(FontFamily _f in Fonts.SystemFontFamilies) {
                LanguageSpecificStringDictionary _fontDic = _f.FamilyNames;
                if(_fontDic.ContainsKey(XmlLanguage.GetLanguage("zh-cn"))) {
                    string _fontName = null;
                    if(_fontDic.TryGetValue(XmlLanguage.GetLanguage("zh-cn"), out _fontName)) {
                        cbo_Demo.Items.Add(_fontName);
                    }
                }
            }
        }

        private void cbo_Demo_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            textBlock1.FontFamily = new FontFamily(cbo_Demo.Text);
            textBlock2.FontFamily = new FontFamily(cbo_Demo.Text);
            textBlock3.FontFamily = new FontFamily(cbo_Demo.Text);
            textBlock4.FontFamily = new FontFamily(cbo_Demo.Text);
        }
    }
}
