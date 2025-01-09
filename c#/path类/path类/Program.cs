using System;
using System.IO;

namespace path类
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string str = @"C:\Users\小伤刘\Desktop\c#";
        //    Path.GetFileName(str);
        //    //int index = str.LastIndexOf("\\");
        //    //str = str.Substring(index + 1);
        //    //Console.WriteLine(str);
        //    Console.WriteLine(Path.GetFileName(str));
        //file类可以创建真正的文件；
            File.Create(@"C:\Users\小伤刘\Desktop\xiaoshangliu.txt");
            File.Delete(@"C:\Users\小伤刘\Desktop\xiaoshangliu.txt");//删除一个文件；
            Console.WriteLine();
        }
       
    }
}
