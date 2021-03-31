using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;

namespace Links
{
    class utils
    {
        /// <summary>
        /// 运行单例exe
        /// </summary>
        #region 运行单例exe
        public static void runSingleExe()
        {
            string exeName = System.IO.Path.GetFileName(System.Reflection.Assembly.GetEntryAssembly().GetName().Name);
            Process[] ps = Process.GetProcessesByName(exeName);
            if (ps.Length > 1)
            {
                foreach (Process p in ps)
                {
                    ShowWindowAsync(p.MainWindowHandle, 3);
                    SetForegroundWindow(p.MainWindowHandle);
                }

                System.Threading.Thread.Sleep(1000);
                System.Environment.Exit(1);
            }
        }
        /// <summary>   
        /// 该函数设置指定窗口的显示状态。
        /// </summary>
        [DllImport("User32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
        //返回值：如果窗口原来可见，返回值为非零；如果函数原来被隐藏，返回值为零。
        public static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        /// <summary>    
        /// 该函数将创建指定窗口的线程设置到前台，并且激活该窗口。
        /// 键盘输入转向该窗口，并为用户改各种可视的记号。系统给创建前台窗口的
        /// 线程分配的权限稍高于其他线程。
        /// 实践证明：该函数能将最小化WIN复原；2019-12-11；
        /// </summary>   
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        static public extern bool SetForegroundWindow(IntPtr hWnd);
        #endregion
    }
}
