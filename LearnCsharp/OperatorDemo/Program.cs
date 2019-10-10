using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorDemo {
    class Program {
        static string a = "a";
        static string b = null;
        static string c = null;

        static void Main(string[] args) {
            a = "a";
            Console.WriteLine("a ?? null : " + a ?? b); // a
            Console.WriteLine("null ?? a : " + b ?? a); // blank
            Console.WriteLine("a ?? null ?? null : " + a ?? b ?? c);// a

            b = string.Format("{0,5}", a);
            Console.WriteLine("b.length : " + b.Length); // 5
            b = $"{a,5}";
            Console.WriteLine("b.length : " + b.Length); // 5

            a = "000;-#;(0)";
            b = 1.ToString(a);
            Console.WriteLine("b : " + b); // 001
            b = (-1).ToString(a);
            Console.WriteLine("b : " + b); // -1
            b = 0.ToString(a);
            Console.WriteLine("b : " + b); // 0


            Console.ReadKey();
        }
    }
}
