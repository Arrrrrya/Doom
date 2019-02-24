using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVariable {
    class Program {
        static void Main(string[] args) {
            setVariable();
            setString();
            setVar();
            getDataLenth();

            Console.ReadKey(true);
        }

        static void setVariable() {
            Console.WriteLine("--测试基础数据类型--");
            //C#语言内置数据类型，4种：int，long，float，double
            //编译后会转变为CLR支持的基础数据类型：
            //System.Int32，System.Int64，System.Single，System.Double
            int intValue = 100;
            long longValue1 = 100;
            long longValue2 = 100L;
            float floatValue1 = 100;
            float floatValue2 = 100F;
            double doubleValue1 = 100;
            double doubleValue2 = 100D;

            Console.WriteLine(intValue.GetType());
            Console.WriteLine(longValue1.GetType());
            Console.WriteLine(longValue2.GetType());
            Console.WriteLine(floatValue1.GetType());
            Console.WriteLine(floatValue2.GetType());
            Console.WriteLine(doubleValue1.GetType());
            Console.WriteLine(doubleValue2.GetType());

            Console.WriteLine(intValue.GetType() == typeof(int));
        }

        static void setString() {
            Console.WriteLine("--测试定义字符串--");
            //C#中定义字符串，String和string是一样的
            String str1 = "test";
            string str2 = "test";
            Console.WriteLine(str1.GetType());
            Console.WriteLine(str2.GetType());
            Console.WriteLine(typeof(String) == typeof(string));
        }

        static void setVar() {
            Console.WriteLine("--测试var关键字--");
            //隐式类型变量
            var var1 = "100";
            var var2 = 100;
            var var3 = 100000000000000000;
            var var4 = 100.5;//默认为double类型
            var var5 = 100.5F;

            Console.WriteLine(var1.GetType());
            Console.WriteLine(var2.GetType());
            Console.WriteLine(var3.GetType());
            Console.WriteLine(var4.GetType());
            Console.WriteLine(var5.GetType());
        }

        static void getDataLenth() {
            Console.WriteLine("--测试数据类型的字节数，类型转换--");
            Console.WriteLine("int类型占用：{0}字节", sizeof(int));//4
            Console.WriteLine("long类型占用：{0}字节", sizeof(long));//8
            Console.WriteLine("float类型占用：{0}字节", sizeof(float));//4
            Console.WriteLine("double类型占用：{0}字节", sizeof(double));//8

            int intValue = 100;
            long longValue = 100L;
            float floatValue = 100.5F;
            double doubleValue = 100.5D;

            //隐式类型转换
            longValue = intValue;
            floatValue = intValue;
            doubleValue = intValue;
            doubleValue = floatValue;
            doubleValue = floatValue;
            
            //强制类型转换
            intValue = (int)longValue;
            intValue = (int)doubleValue;
            intValue = (int)floatValue;
            floatValue = (float)doubleValue;
        }
    }
}
