using Spring.Context;
using Spring.Context.Support;
using System;

namespace SringNetDemo
{
    /// <summary>
    /// 通过注入的方法为对象和属性赋值
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext context = ContextRegistry.GetContext();// spring.net读取配置文件，获取上下文
            User user = context.GetObject("user") as User;// 从配置文件中读取name属性为user的对象实例，并向上转型为User实例
            Console.WriteLine("userName:\t" + user.userName + "\r\nuserPassword:\t" + user.userPassword);

            Skills skill = context.GetObject("skills") as Skills;
            Console.WriteLine("\r\nskillName:\t" + skill.skillName + "\r\nskillDescribe:\t" + skill.skillDescribe);

            Skills skill_2 = context.GetObject("skills_2") as Skills;
            Console.WriteLine("\r\nskillName:\t" + skill_2.skillName + "\r\nskillDescribe:\t" + skill_2.skillDescribe);

            Console.ReadKey();
        }
    }

    class Skills
    {
        public string skillName { get; set; }
        public string skillDescribe { get; set; }
    }
}
