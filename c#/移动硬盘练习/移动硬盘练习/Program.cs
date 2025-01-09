using System;
using System.IO;

namespace 移动硬盘练习
{
    class Program
    {
        static void Main(string[] args)
        {
            father fa = new upan();
            computer cp = new computer();
            cp.cpuread(fa);
            cp.cpuwrite(fa);
        }
    }
}
