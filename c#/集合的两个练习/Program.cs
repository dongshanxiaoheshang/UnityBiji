using System;
using System.Collections;

namespace 集合的两个练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个集合，里面添加一些数字，求平均值与和，最大值；
            ArrayList list = new ArrayList();
            list.AddRange(new int[] { 1,2,5,6,9,8,4,5,6,32,5});
            int sum = 0;
            int max = (int)list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if ((int)list[i] > max)
                {
                    max = (int)list[i];
                }
                sum = sum + (int)list[i];//list是object类型的，要转化为int类型才能相加；
            }
            Console.WriteLine(sum);

            //写一个长度为10的集合要求在里面随即放10个数字，但要求不能重复；
        }
    }
}
