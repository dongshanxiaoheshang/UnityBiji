using System;
using System.Diagnostics;
using System.Text;
namespace 字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string str = null;
            Stopwatch sw = new Stopwatch();//创建一个计时器；
            sw.Start();//开始计时；
            for (int i = 0; i < 10000; i++)
            {
                //str += i;
                sb.Append(i);
            }
            sw.Stop();//结束计时；
            Console.WriteLine(sb.ToString());
            Console.WriteLine(sw.Elapsed);
        }
    }
}
