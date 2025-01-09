using System;
using System.IO;
using System.Text;

namespace streamReader和streamWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //steamReader读入文件；
            //using(StreamReader sr=new StreamReader(@"C:\Users\小伤刘\Desktop\笔记\c#.txt",Encoding.Default))
            //{
            //    while (!sr.EndOfStream)//判断是否读到了最后；
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}



            //用streamWrite写一个文件
            using (StreamWriter sw = new StreamWriter(@"C:\Users\小伤刘\Desktop\笔记\new.txt",true))
            {
                sw.WriteLine("jjksnxhuskhdikksj");
            }
        }
    }
}
