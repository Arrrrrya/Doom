using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDemo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\n遍历整数集合");
            var intValues = new List<int>() { 1, 2, 3, 4 };
            foreach(var value in intValues) {
                Console.WriteLine(value);
            }

            var myClasses = new List<MyClass>();
            for(int i = 1; i < 5; i++) {
                myClasses.Add(new MyClass() {
                    ID = i,
                    Description = "MyClass对象" + i
                });
            }
            Console.WriteLine("\n遍历对象集合");
            foreach(var myClassObj in myClasses) {
                Console.WriteLine("{0}:{1}",myClassObj.ID,myClassObj.Description);
            }

            // 使用foreach遍历时，不要 对集合做  增删  操作

            Console.WriteLine("\n遍历数组");
            int[] numbers = { 1, 3, 5 };
            foreach(var number in numbers) {
                Console.WriteLine(number);
            }



            Console.ReadKey(true);

        }
    }
}
