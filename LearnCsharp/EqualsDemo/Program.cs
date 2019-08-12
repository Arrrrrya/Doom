using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualsDemo {
    class Program {
        static void Main(string[] args) {
            int a = 100;
            int b = 100;
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine("int 类型是值类型");

            MyClass c1 = new MyClass();
            MyClass c2 = new MyClass();
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));
            Console.WriteLine("== 运算符比较引用类型变量，实际上是比对二者是否引用同一个对象");

            MyClass c3 = new MyClass();
            MyClass c4 = new MyClass();
            c3.Value = 1;
            c4.Value = 1;
            Console.WriteLine(c3 == c4);
            Console.WriteLine(c3.Equals(c4));
            Console.WriteLine("重写equals方法可以实现按值比较对象");

            string s1 = "c#";
            string s2 = "c#";
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine("string是引用类型，但它的'=='经过了重写，功能与equals一样，都是比较字符串内容是否一样");


            Console.ReadKey();
        }
    }

    class MyClass {
        private int value = 100;
        public int Value {
            get;
            set;
        }

        // 重写Object类的Equals()，同时需要重写GetHashCode()

        public override bool Equals(object obj) {
            if(obj == null) {
                return false;
            } else {
                if(obj is MyClass) {
                    return (this.value == (obj as MyClass).value && this.Value == (obj as MyClass).Value);
                }
            }
            return false;
        }

        public override int GetHashCode() {
            return value;
        }
    }
}
