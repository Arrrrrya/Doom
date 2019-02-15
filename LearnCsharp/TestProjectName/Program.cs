using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectName {
    class Program {
        static void Main(string[] args) {
            //1.测试标题及控制台字体颜色
            //TestConsoleProperty();
            //Console.WriteLine("hello jessica");

            //2.测试控制台输入和输出
            //TestWriteAndOutput();

            //3.测试返回
            Console.WriteLine("\n\nConsole.ReadKey测试开始:");
            //Console.ReadKey方法为捕捉用户对键盘的点击，然后返回
            //指定true的时候，不会输出用户点击的键盘
            Console.ReadKey(true);
            //不指定或指定false，则会输出
            Console.ReadKey();
            Console.ReadKey(false);
            Console.ReadKey(true);

            //4.测试提示音
            //程序运行到Console.Beep()时，电脑会发出一声 “吡”，作为提示音
            Console.Beep();

            //程序捕捉用户点击键盘，返回，程序结束
            Console.ReadKey(true);
        }

        static void TestConsoleProperty() {
            //设置标题，DateTime.Now可以获取当前时间
            Console.Title = "Test Title " + DateTime.Now;
            //设置控制台前景色（字体颜色）为红色
            Console.ForegroundColor = ConsoleColor.Red;
            //设置控制台背景色为黄色
            Console.BackgroundColor = ConsoleColor.Yellow;
        }

        static void TestWriteAndOutput() {
            Console.Write("请输入: ");
            String userInput = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("用户输入了: " + userInput);
            // {} 是占位符：索引(从零开始)必须大于或等于零，且小于参数列表的大小。
            Console.WriteLine("1.测试占位符: {0}", userInput);
            Console.WriteLine("2.测试多个占位符: {0} length: {1}", userInput, userInput.Length);

            // \n 是换行符
            Console.WriteLine("3.测试换行符: {0}\n length: {1}", userInput, userInput.Length);

            // \t 是制表符，相当于键盘的Tab键
            Console.WriteLine("4.测试制表符: {0}\t length: {1}", userInput, userInput.Length);

            //综合测试
            Console.WriteLine("5.综合测试：\n姓名:\tarya\n年龄:\t18");
        }
    }
}
