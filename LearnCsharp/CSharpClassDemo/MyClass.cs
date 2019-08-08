using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpClassDemo {
    class MyClass {
        public string name = "name0";
        public int age = 0;

        public string Name {
            get {
                return name;
            }
        }

        public int Age {
            get {
                return age;
            }
            set {
                if(value < 0) {
                    age = 0;
                } else {
                    age = value;
                }
            }

        }
    }
}
