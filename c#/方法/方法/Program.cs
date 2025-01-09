using System;

namespace 方法
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int a = Console.ReadLine();
            ////int max = GetMax(20 ,10);
            ////Console.WriteLine(max);
            //int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int sum = GetSum(number);
            //Console.WriteLine(sum);
            //#region
            ////bool b = IsRun(2000);
            ////Console.WriteLine(b);
            ////Console.WriteLine("请输入你要输入的值");
            ////string str = Console.ReadLine();
            ////int b = GetMax(str);
            ////Console.WriteLine(b);
            //#endregion
            //int sum = GetMax(1, 2, 3, 4, 5, 6, 7, 8, 9);111111params参数
            //Console.WriteLine(sum);111111
        }
        #region
        /// <summary>
        /// 判断年份是否为闰年
        /// </summary>
        /// <param name="years"></param>
        /// <returns>返回值</returns>
        //static bool IsRun(int years)
        //{
        //    bool b = (years % 400 == 0) || (years % 100 == 4) && (years % 100 == 4);
        //    return b;
        //        }
        //static int GetMax(string s)
        //{
        //    while (true)
        //    {
        //        try
        //        {
        //            int number = Convert.ToInt32(s);
        //            return number;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("请重新输入");
        //            s = Console.ReadLine();
        //        }
        //    }
        //}
        #endregion
        
        //
        //static int GetMax(int n1,int n2)
        //{
        //  int max=  n1 > n2 ? n1 : n2;
        //    return max;
        //}
        
        //static int  GetSum(int[] number)
        //{   int sum = 0;
        //    for (int i = 0; i < number.Length; i++)
        //    {
        //        sum = sum + number[i];
              
        //    }  return sum;
        //}
        //static void IsYesOrNo(string str)
        //{
        //    while (true)
        //    {
        //        if (str == "yes"||str=="no")
        //        {
        //            return str;
        //        }
        //        else
        //        {
        //            Console.WriteLine("输入不对，请重新输入");

        //        }
        //    }
        //}
        public static int GetMax(params int[] n)//params 可变参数；
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum = sum + n[i];
            }
            return sum;
        }

    }
}
//Out参数  一个人方法可以返回多个不同类型的值，
//    params参数
//    ref参数