using System;
using System.Diagnostics;
using System.Text;

namespace KMPDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string t = "abcd";
            StringBuilder ss = new StringBuilder();
            for (int i = 0; i < 40000000; i++)
            {
                ss.Append("abc");
            }
            ss.Append(t);
            Stopwatch sw = new Stopwatch();

            sw.Start();
            Console.WriteLine(findString(ss.ToString(), t));
            sw.Stop();
            Console.WriteLine("findString用时：\t" + sw.Elapsed.TotalMilliseconds);

            sw.Reset();
            sw.Start();
            Console.WriteLine(kmpMatch(ss.ToString(), t));
            sw.Stop();
            Console.WriteLine("kmpMatch用时：\t" + sw.Elapsed.TotalMilliseconds);

            Console.ReadKey();
        }

        public static int findString(string s, string t)
        {
            for (int i = 0; i < s.Length - t.Length + 1; i++)
            {
                if (s.Substring(i, t.Length) == t)
                {
                    return i;
                }
            }
            return -1;
        }

        /**
         * 对主串s和模式串t进行KMP模式匹配
         * @param s 主串
         * @param t 模式串
         * @return 若匹配成功，返回t在s中的位置（第一个相同字符对应的位置），若匹配失败，返回-1
         */
        public static int kmpMatch(string s, string t)
        {
            char[] s_arr = s.ToCharArray();
            char[] t_arr = t.ToCharArray();
            int[] next = getNextArray(t_arr);
            int i = 0, j = 0;
            while (i < s_arr.Length && j < t_arr.Length)
            {
                if (j == -1 || s_arr[i] == t_arr[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = next[j];
                }
            }
            if (j == t_arr.Length)
            {
                return i - j;
            }
            else
            {
                return -1;
            }

        }

        /**
         * 求出一个字符数组的next数组
         * @param t 字符数组
         * @return next数组
         */
        public static int[] getNextArray(char[] t)
        {
            int[] next = new int[t.Length];
            next[0] = -1;
            next[1] = 0;
            int k;
            for (int j = 2; j < t.Length; j++)
            {
                k = next[j - 1];
                while (k != -1)
                {
                    if (t[j - 1] == t[k])
                    {
                        next[j] = k + 1;
                        break;
                    }
                    else
                    {
                        k = next[k];
                    }
                    next[j] = 0; //当k==-1而跳出循环时，next[j] = 0，否则next[j]会在break之前被赋值
                }
            }
            return next;
        }
    }
}
