using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1001; i++)
            {
                Thread.Sleep(1);
            }
            sw.Stop();
            Console.WriteLine("for i< 用时：\t" + (sw.Elapsed.TotalMilliseconds));
            sw.Reset();
            sw.Start();
            for (int i = 0; i <= 1000; i++)
            {
                Thread.Sleep(1);
            }
            sw.Stop();
            Console.WriteLine("for i<= 用时：\t" + (sw.Elapsed.TotalMilliseconds));
            int[] array = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                array[i] = i;
            }
            sw.Reset();
            sw.Start();
            foreach (int i in array)
            {
                Thread.Sleep(1);
            }
            sw.Stop();
            Console.WriteLine("foreach 用时：\t" + (sw.Elapsed.TotalMilliseconds));
            sw.Reset();
            sw.Start();
            Parallel.For(0, 1000, i =>
            {
                Thread.Sleep(1);
            });
            Console.WriteLine("Parallel.For 用时：\t" + (sw.Elapsed.TotalMilliseconds));

            sw.Start();
            Parallel.ForEach(array, item =>
            {
                Thread.Sleep(1);
            });
            Console.WriteLine("Parallel.ForEach 用时：\t" + (sw.Elapsed.TotalMilliseconds));

            Console.ReadKey();
        }
    }
}
