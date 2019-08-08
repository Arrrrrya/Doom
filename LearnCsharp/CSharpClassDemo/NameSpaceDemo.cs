using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassDemo {
    class NameSpaceDemo {
        public void doSth() {
            Console.WriteLine("nameSpaceDemo");
        }
    }
    namespace InnerNameSpace {
        public class InnerClassDemo {
            public void doSth() {
                Console.WriteLine("innerNameSpace");
            }
        }
    }
}
