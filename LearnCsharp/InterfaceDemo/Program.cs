using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo {
    class Program {
        static void Main(string[] args) {
            Duck d = new Duck();
            d.fly();
            d.cook();
            d.swim();

            Console.ReadKey();
        }
    }
    public abstract class Bird {
        public abstract void fly();
    }
    public interface IFood {
        void cook();
    }
    public interface ISwim {
        void swim();
    }
    public class Duck : Bird, IFood, ISwim {
        public override void fly() {
            Console.WriteLine("i'm a duck and i can fly");
        }
        public void cook() {
            Console.WriteLine("i'm a duck and i can be cooked");
        }
        public void swim() {
            Console.WriteLine("i'm a duck and i can swim");
        }
    }
}
