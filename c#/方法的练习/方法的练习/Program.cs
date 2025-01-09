using System;

namespace 方法的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，求得数组的最大值，最小值，总和，平均值；
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ////int[] ans = GetMaxMinSumAvge(number);
            ////Console.WriteLine("最大值为{0},最小值为{1},总和为{2},平均值为{3}", ans[0], ans[1], ans[2], ans[3]);
            //int max;
            //int min;
            //int sum;
            //int avge;
            //bool b;
            //double c;
            //string d;
            //Test(number, out max, out min, out sum, out avge,out b,out c,out d);
            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine(sum);
            //Console.WriteLine(avge);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            Console.WriteLine("请输入用户名");
           string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            string msg;
           bool b= IsLongin(name, pwd, out msg);
            Console.WriteLine("登录结果{0}", b);
            Console.WriteLine("登录信息{0}", msg);

        }
        /// <summary>
        ///  //写一个方法，求得数组的最大值，最小值，总和，平均值
        /// </summary>
        /// <param name="number">定义一个数组，存放最大值，最小值，总和，平均值</param>
        /// <returns>返回值</returns>
        //public static int[] GetMaxMinSumAvge(int[] number)
        //{

        //    int[] res = new int[4];//定义一个数组，存放最大值，最小值，总和，平均值
        //    res[0] = number[0];//最大值；
        //    res[1] = number[0];//最小值；
        //    res[2] = 0;//总和；
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        if (number[i] > res[0])
        //        {
        //            res[0] = number[i];
        //        }
        //        if (number[i] < res[0])
        //        {
        //            res[1] = number[i];
        //        }
        //        res[2] = res[2] + number[i];
        //    }
        //    res[3] = res[2] / number.Length;
        //    return res;
        //}
        
        //public static void Test(int[] number, out int max, out int min, out int sum, out int avge,out bool b,out double c,out string d)//可以输不同类型的值
        //{
        //    min = number[0];
        //    max = number[1];
        //    sum = 0;
        //    avge = 0;
        //    b = true;
        //    c = 3.14159;
        //    d = "123";
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        if (number[i] > max)
        //        {
        //            max = number[i];
        //        }
        //        if (number[i] < min)
        //        {
        //            min = number[i];
        //        }
        //        sum = sum + number[i];
        //        avge = sum / number.Length;
        //    }
        //}
        public static bool IsLongin(string name,string pwd,out string msg)
        {
           
            if (name == "aaaaa"&&pwd=="888888")
            {
                msg = "登录成功";
                return true;
            }
            else if (name == "aaaaa")
            {
                msg = "密码错误";
                return false;
            }
            else if (pwd == "888888")
            {
                msg = "名字错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }



    }  
}
