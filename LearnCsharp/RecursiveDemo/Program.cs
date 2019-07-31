using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveDemo {
    class Program {
        static void Main(string[] args) {
            int n = 6;
            Console.WriteLine("{0}! = {1}", n, doFactorial(n));

            int x = 12;
            Console.WriteLine("第{0}数为: {1}", x, doSum(x));

            Console.ReadKey(true);
        }

        static long doFactorial(int n) {
            if(n > 1) {
                return (n * doFactorial(n - 1));
            } else {
                return n;
            }
        }

        static long doSum(int n) {
            if(n == 1 || n == 2) {
                return 1;
            } else if(n > 2) {
                return doSum(n - 2) + doSum(n - 1);
            } else {
                return 0;
            }
        }
    }
}
