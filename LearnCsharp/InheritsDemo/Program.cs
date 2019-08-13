using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritsDemo {
    class Program {
        static void Main(string[] args) {
            Child child = new Child();
            // 外界可以通过子类直接访问父类public属性
            Console.WriteLine(child.publicField);
            child.parentMethod();

            // 外界不能通过子类直接访问父类protected属性

            // 外界可以间接访问父类protected属性
            child.childMethod();

            Console.WriteLine(child.publicField);

            Console.ReadKey();
        }
    }
    class Parent {
        public int publicField = 100;
        public void parentMethod() {
            Console.WriteLine("I am pulbic Parent method");
        }
        protected int protectedField = 200;
        protected void protectedMethod() {
            Console.WriteLine("I am protected Parent method");
        }
        private int privateField = 300;
    }
    class Child : Parent {
        public void childMethod() {
            // 子类可以访问父类public和protected的属性
            publicField++;
            parentMethod();
            protectedField++;
            protectedMethod();

            // 子类无法访问父类private属性
        }
    }
}
