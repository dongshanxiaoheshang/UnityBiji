using System;

namespace 联系
{
    class Program
    {
        static void Main(string[] args)
        {
            bool b = Isrun(2000);
            Console.WriteLine(b);
        }
        /// <summary>
        /// 判断年份是否为闰年
        /// </summary>
        /// <param name="year">判断年份</param>
        /// <returns>返回结果</returns>
       static bool Isrun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 == 0);
            return b;
        }
    } 
}
 