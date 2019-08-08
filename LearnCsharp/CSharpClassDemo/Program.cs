using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpClassDemo;
using CSharpClassDemo.InnerNameSpace;

namespace CSharpClassDemo {
    class Program {
        static void Main(string[] args) {
            MyClass myClass = new MyClass();
            myClass.Age = -1;
            myClass.age = 2;
            Console.WriteLine(myClass.Age);
            
            MyClass definedMyClass = new MyClass() {
                age = 100
            };

            Console.WriteLine(definedMyClass.age);

            myClass.doPrint();

            NameSpaceDemo demo = new NameSpaceDemo();
            demo.doSth();

            InnerClassDemo inDemo = new InnerClassDemo();
            inDemo.doSth();


            Console.ReadKey();
        }
    }
}
