using System;

namespace 继承的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            Reporter re = new Reporter("展示", 25, '女', "拍照");
            re.SayHello();
        }
    }
}
