using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDemo {
    class Program {
        static void Main(string[] args) {
            Parent parent = new Child();
            parent.testOverLoad();// 调用父类方法
            parent.testOverRide();// 调用子类方法
            (parent as Child).testOverLoad(100);// 调用子类方法

            Parent p = new Parent();
            Child c = new Child();
            p.doTheSame();// 调用父类
            c.doTheSame();// 调用子类
            p = c;
            p.doTheSame();// 调用父类 因为方法完全相同，由变量定义时的类型决定调用关系
            (p as Child).doTheSame();// 调用子类，因为已经强制转换类型

            Console.WriteLine(p.n);// 同上
            Console.WriteLine((p as Child).n);


            
            Console.ReadKey();
        }
    }
    class Parent {
        public int n = 100;
        public void testOverLoad() {
            Console.WriteLine("parent.overLoad()");
        }
        public virtual void testOverRide() {
            Console.WriteLine("parent.overRide()");
        }

        public void doTheSame() {
            Console.WriteLine("parent.doTheSame()");
        }
    }
    class Child : Parent {
        public int n = 200;
        public void testOverLoad(int n) {
            Console.WriteLine("child: {0}", n);
        }
        public override void testOverRide() {
            Console.WriteLine("child.overRide()");
        }

        public void doTheSame() {
            Console.WriteLine("child.doTheSame()");
        }
    }
}
