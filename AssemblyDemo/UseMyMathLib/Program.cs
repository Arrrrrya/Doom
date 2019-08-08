using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary;

namespace UseMyMathLib {
    class Program {
        static void Main(string[] args) {
            MathLibrary mathLib = new MathLibrary();
            Console.WriteLine(mathLib.Add(1, 2));
            Console.ReadKey();
        }
    }
}
