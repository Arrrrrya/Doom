using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyDemo {
    class Program {
        static void Main(string[] args) {
            DateTime date = new DateTime(2019, 08, 12);
            date.AddDays(1);
            Console.WriteLine(date);
            Console.WriteLine(date.AddDays(1));

            string str = "hello";
            str.ToUpper();
            Console.WriteLine(str);
            Console.WriteLine(str.ToUpper());

            StaticDemo s = null;
            for(int i = 0; i < 100; i++) {
                s = new StaticDemo();
                s.increase();
            }
            Console.WriteLine("dynamicValue = " + s.dynamicValue);
            Console.WriteLine("staticValue = " + StaticDemo.staticValue);


            Console.ReadKey();
        }
    }

    // 类的实例方法，可以访问类的实例字段和静态成员
    // 类的静态方法，只能访问类的静态字段

    class StaticDemo {
        public int dynamicValue = 0;
        public static int staticValue = 0;

        public void increase() {
            dynamicValue++;
            staticValue++;
        }

        public static void staticIncrease() {
            StaticDemo staticDemo = new StaticDemo();
            staticDemo.increase();
            staticDemo.dynamicValue++;
        }
    }
}
