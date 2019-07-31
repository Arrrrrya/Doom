using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo {
    class Program {
        static void Main(string[] args) {
            int a = 100;
            int b = 22;
            printSum(a, b);

            double c= 100;
            double d = 22.1;
            printSum(c, d);

            string e = "100";
            string f = "22.1";
            printSum(e, f);

            Console.WriteLine("\n按任意键结束：");
            Console.ReadKey(true);
        }

        static void printSum(int a, int b) {
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }

        static void printSum(double a, double b) {
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }

        static void printSum(string a, string b) {
            Console.WriteLine("{0} + {1} = {2}", a, b, (a + b));
        }
    }
}
