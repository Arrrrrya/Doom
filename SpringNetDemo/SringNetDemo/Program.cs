using Spring.Context;
using Spring.Context.Support;
using System;

namespace SringNetDemo
{
    class Program
    {
        static void Main(string[] args)
        { //spring.net读取配置文件，获取上下文
            IApplicationContext context = ContextRegistry.GetContext();
            //从配置文件中读取name属性为user的对象实例，并向上转型为User实例
            User user = context.GetObject("user") as User;
            Console.WriteLine("userName:\t" + user.userName + "\r\nuserPassword:\t" + user.userPassword);
            Console.ReadKey();
        }
    }
}
