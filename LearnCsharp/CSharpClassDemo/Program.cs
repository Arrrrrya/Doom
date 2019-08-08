using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
            Console.ReadKey();
        }
    }
}
