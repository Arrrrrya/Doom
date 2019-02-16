using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsolePractise {
    class Program {
        static void Main(string[] args) {
            setTitle();
            Console.WriteLine("Hello，今天我来教你念句诗。\n\n");
            Thread.Sleep(1000);

            Console.Write("苟");
            Thread.Sleep(500);
            Console.Write("利");
            Thread.Sleep(500);
            Console.Write("国");
            Thread.Sleep(500);
            Console.Write("家");
            Thread.Sleep(500);
            Console.Write("生");
            Thread.Sleep(500);
            Console.Write("死");
            Thread.Sleep(500);
            Console.Write("以");
            Thread.Sleep(500);
            Console.WriteLine("，");
            Thread.Sleep(500);
            Console.Write("岂");
            Thread.Sleep(500);
            Console.Write("因");
            Thread.Sleep(500);
            Console.Write("祸");
            Thread.Sleep(500);
            Console.Write("福");
            Thread.Sleep(500);
            Console.Write("避");
            Thread.Sleep(500);
            Console.Write("趋");
            Thread.Sleep(500);
            Console.Write("之");
            Thread.Sleep(500);
            Console.WriteLine("。");
            Thread.Sleep(500);

            Console.WriteLine("\n\n你学会了吗？");
            Thread.Sleep(1000);
            Console.WriteLine("\n点击键盘任意键结束。");
            Console.ReadKey(true);
        }

        static void setTitle() {
            Console.Title = "教你念诗-Jessica " + DateTime.Now;
        }
    }
}
