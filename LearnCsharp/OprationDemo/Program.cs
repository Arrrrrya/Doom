using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OprationDemo {
    /// <summary>
    /// 测试运算符
    /// </summary>
    class Program {
        static void Main(string[] args) {
            double result = testOperation();
            Console.WriteLine(result);
            Console.WriteLine(9 / 6.0);
            
            int a = 100;
            int b = 100;

            testPlusPlus(a, b);

            if(a == b) {
                testIF();
            } else {
                testElse();
            }
            
            Console.WriteLine(a);
            Console.WriteLine(b);

            if(a++ == ++b) {
                testIF();
            } else {
                testElse();
            }

            Console.WriteLine(a==b?"a=b":"a!=b");

            testSwitch(a);
            testSwitch(a - 1000);

            int ns = 0;
            int n = 1;
            testDoWhile(ns, n);

            testWhile();

            testFor();

            testBreak();

            testContinue();

            testInfinityFor();

            Console.WriteLine("\n\npress any key to end:");
            Console.ReadKey(true);
        }
        static double testOperation() {
            double result = 9 / 6;
            return result;
        }

        static void testIF() {
            Console.WriteLine("i am if");
        }

        static void testElse() {
            Console.WriteLine("i am else");
        }

        static void testPlusPlus(int a, int b) {
            Console.WriteLine(a++);
            Console.WriteLine(++b);
        }

        static void testSwitch(int a) {
            if(a > 1) {
                a = 1000;
            }

            switch(a) {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 1:
                    Console.WriteLine(1);
                    break;
                case 1000:
                    Console.WriteLine("bingo");
                    break;
                default:
                    Console.WriteLine("Not find");
                    break;
            }
        }

        static void testDoWhile(int ns, int n) {
            do {
                ns += n;
                n++;
            } while(n <= 100);
            Console.WriteLine(ns);
        }

        static void testWhile() {
            String x = "";
            Console.WriteLine("the password is '123'");
            while(x != "123") {
                x = Console.ReadLine();
            }
            Console.WriteLine("Get!");
        }

        static void testFor() {
            int sum = 0;
            for(int i = 1; i <= 100; i++) {
                sum += i;
            }
            Console.WriteLine("sum = {0}", sum);
        }

        static void testBreak() {
            int x = 0;
            int y = 10;
            for(int i = 0; i < 100; i++) {
                x += 2;
                if(x == y) {
                    Console.WriteLine("stop, x = y = {0}", x);
                    break;
                }
                y++;
            }
            Console.WriteLine("at last, x = {0}, y = {1}", x, y);
        }

        static void testContinue() {
            int x = 0;
            int y = 10;
            for(int i = 0; i < 100; i++) {
                x += 2;
                if(x == y) {
                    Console.WriteLine("stop, x = y = {0}", x);
                    continue;
                }
                y++;
            }
            Console.WriteLine("at last, x = {0}, y = {1}", x, y);
        }

        static void testInfinityFor() {
            int sum = 0;
            int n = 0;
            while(true) {
                sum += n;
                n++;
                if(n > 100) {
                    break;
                }
            }
            Console.WriteLine("sum = {0}", sum);
        }


    }
}
