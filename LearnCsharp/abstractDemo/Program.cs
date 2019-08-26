using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractDemo {
    class Program {
        static void Main(string[] args) {
            Fruit f;
            f = new Apple();
            f.printLivingArea();
            f.eatFruit();

            f = new Pineapple();
            f.printLivingArea();
            f.eatFruit();



            Console.ReadKey();
        }
    }

    abstract class Fruit {
        public abstract void printLivingArea();
        public void eatFruit() {
            Console.WriteLine("i'm not guuuud to eat.");
        }
    }

    class Apple : Fruit {
        public override void printLivingArea() {
            Console.WriteLine("apple lives in The US.");
        }
    }

    class Pineapple : Fruit {
        public override void printLivingArea() {
            Console.WriteLine("pineapple lives in Singapore");
        }
    }
}
