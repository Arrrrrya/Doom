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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Viewport3DDemo {
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window {
        DispatcherTimer dispatTime = null;
        double AxAngle = 90;

        public MainWindow() {
            InitializeComponent();

            if(dispatTime == null)
                dispatTime = new DispatcherTimer();
            dispatTime.Tick += new EventHandler(DT_Tick);
            dispatTime.Interval = new TimeSpan(0, 0, 0, 0, 2);
        }


        private void DT_Tick(object sender, EventArgs e) {
            AxisAngleRot.Angle += 1;
            if(AxisAngleRot.Angle >= AxAngle)
                dispatTime.Stop();
        }

        private void FrontSide_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            AxisAngleRot.Angle = 0;
            AxAngle = 90;
            dispatTime.Start();
        }

        private void LeftSide_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            AxAngle = 360;
            dispatTime.Start();
        }

        private void BackSide_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            AxAngle = 270;
            dispatTime.Start();
        }


        private void RightSide_PreviewMouseDown(object sender, MouseButtonEventArgs e) {
            AxAngle = 180;
            dispatTime.Start();
        }
    }
}
