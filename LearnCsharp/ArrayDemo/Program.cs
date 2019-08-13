using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo {
    class Program {
        static void Main(string[] args) {
            int[] arr = new int[8] { 1, 4, 78, 2, 7, 9, 0, 10 };

            foreach(var element in arr) {
                Console.WriteLine(element);
            }

            arr[arr.Length - 1]++;
            Console.WriteLine("the last element: " + arr[arr.Length - 1]);

            int a = arr[arr.Length - 1]++;
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("the last element: " + arr[arr.Length - 1]);

            int b = ++arr[arr.Length - 1];
            Console.WriteLine("b: {0}", b);
            Console.WriteLine("the last element: " + arr[arr.Length - 1]);

            Console.WriteLine("\n\n");

            string[] strArr = new string[] { "Hello", "csharp" };

            foreach(var element in strArr) {
                Console.WriteLine(element);
            }
            for(int i = 0; i < strArr.Length; i++) {
                strArr[i] = strArr[i].ToUpper();
            }
            foreach(var element in strArr) {
                Console.WriteLine(element);
            }

            // should notice that
            // 数组中对象的修改，只是改变了对象引用，而不是对象本身。


            Console.ReadKey();
             
        }
    }
}
