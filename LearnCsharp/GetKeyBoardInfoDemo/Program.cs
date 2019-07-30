using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetKeyBoardInfoDemo {
    class Program {
        static void Main(string[] args) {
            // testGetESC();
            // testForceQuit();
            testDisableCtrlC();



            Console.ReadKey(true);
        }

        static void testGetESC() {
            Console.WriteLine("本测试程序目的：捕获键盘上的ESC");
            ConsoleKeyInfo key;
            do {
                // 用户敲了吗
                while(!Console.KeyAvailable) {
                    // 等待
                }
                key = Console.ReadKey(true);
                Console.WriteLine();
                Console.WriteLine("Modifiers值 = {0}", key.Modifiers);
                Console.WriteLine("KeyChar值 = {0}", (int)key.KeyChar);
                Console.WriteLine("Key值 = {0}", key.Key);

                // CapsLock这个键不能被捕获，但可以检测出键盘的状态
                if(Console.CapsLock) {
                    Console.WriteLine("当前处于大写状态");
                }
                // NumberLock这个键不能被捕获，但可以检测出键盘的状态
                if(Console.NumberLock) {
                    Console.WriteLine("小键盘numberLock被按下");
                }

                // 检测控制键
                if(key.Modifiers != 0) {
                    if((key.Modifiers & ConsoleModifiers.Alt) != 0) {
                        Console.WriteLine("Alt键被按下");
                    }
                    if((key.Modifiers & ConsoleModifiers.Control) != 0) {
                        Console.WriteLine("Ctrl键被按下");
                    }
                    if((key.Modifiers & ConsoleModifiers.Shift) != 0) {
                        Console.WriteLine("Shift键被按下");
                    }
                }
            } while(key.Key != ConsoleKey.Escape);
            Console.WriteLine("\n检测到ESC, 按任意键退出。");

            Console.ReadKey(true);
        }

        static void testForceQuit() {
            // Ctrl+C/Break 是系统内置功能，中止控制台程序
            Console.WriteLine("当前为死循环，请使用 Ctrl+C/Break 强制中止。");
            while(true) {
                Console.WriteLine("当前时间: " + DateTime.Now.ToLocalTime());
                Thread.Sleep(1000);
            }
        }

        static void testDisableCtrlC() {
            Console.WriteLine("本程序无法使用ctrl+c退出。");
            Console.TreatControlCAsInput = true;
            do {
                var key = Console.ReadKey(true);
                if(key.Key == ConsoleKey.Escape) {
                    Console.WriteLine("检测到ESC，按任意键退出。");
                    break;
                }
            } while(true);
        }
    }
}
