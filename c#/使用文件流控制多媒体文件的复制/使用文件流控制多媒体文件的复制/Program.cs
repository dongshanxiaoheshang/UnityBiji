using System;
using System.IO;

namespace 使用文件流控制多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            string soure = @"C:\Users\小伤刘\Desktop\电子相册.mp4";
            string trager = @"C:\Users\小伤刘\Desktop\new.mp4";
            Copy(soure, trager);
        }
        public static void Copy(string soure,string trager)
        {
            //我们创建一个负责读取的流；
            using(FileStream flread=new FileStream(soure, FileMode.Open, FileAccess.Read))
            {
                //创建一个写入流
                using(FileStream flWrite=new FileStream(trager, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffte = new byte[1024 * 1024 * 5];
                    //因为文件有可能比较大，我们应该通过一个循环去读
                    while (true)
                    {
                        //返回本次读取到的实际字节
                        int r = flread.Read(buffte, 0, buffte.Length);
                        //如果r==0，则说明读取完毕；
                        if (r == 0)
                        {
                            break;
                        }
                        flWrite.Write(buffte, 0, r);
                    }
                } 
            }
        }
    }
}
