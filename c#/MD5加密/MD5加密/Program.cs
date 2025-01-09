using System;
using System.Security.Cryptography;
using System.Text;

namespace MD5加密
{
    class Program
    {
        static void Main(string[] args)
        {
           string str= Getmd("123");
            Console.WriteLine(str);
        }
        public static string Getmd(string str)
        {
            //创建md5对象
            MD5 md = MD5.Create();
            //开始加密

            //将str转化为字节数组
            byte[] butter = Encoding.Default.GetBytes(str);
            //返回一个字节数组。
            byte[] mdbutter=md.ComputeHash(butter);
            //将字节数组转化为string


            //return Encoding.Default.GetString(mdbutter);

            string strs = "";
            for (int i = 0; i < mdbutter.Length; i++)
            {
                strs = strs + mdbutter[i].ToString("x2");
            }
            return strs;
        }
    }
}
