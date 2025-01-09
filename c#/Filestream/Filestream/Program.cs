using System;
using System.IO;
using System.Text;

namespace Filestream
{
    class Program
    {
        static void Main(string[] args)
        {

            //使用FileStram来读入数据；

            ////FileStream  文件流
            ////StreamWrite和StreamReader
            //FileStream flread = new FileStream(@"C:\Users\小伤刘\Desktop\笔记\c#.txt",FileMode.OpenOrCreate);
            //byte[] by = new byte[1024 * 1024 * 5];
            ////假设文件只有3.8m  申请的内存有5m ，
            ////返回的实际值只有3.8m
            //int r=flread.Read(by, 0, by.Length);
            ////将字节数组中的没一个元素按照指定的编码格式解码成字符串；
            //string s=Encoding.Default.GetString(by,0,r);

            ////关闭流
            //flread.Close();
            ////释放所占用的资源；
            //flread.Dispose();
            //Console.WriteLine(s);



            //使用FileStream来写入文件
            using (FileStream flWrite = new FileStream(@"C:\Users\小伤刘\Desktop\笔记\new.txt", FileMode.OpenOrCreate))
            {
                string str = "看我把你覆盖掉";
                byte[] by = Encoding.UTF8.GetBytes(str);
                flWrite.Write(by, 0, by.Length);

            }

        }
    }
}
