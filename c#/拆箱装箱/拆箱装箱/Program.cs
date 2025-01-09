using System;
using System.Collections;

namespace 拆箱装箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 3;
            //object c = n;//装箱，把值类型转换给引用类型；
            //int ss = (int)c;//拆箱，把引用类型转换给值类型；

            ArrayList list = new ArrayList();
            for (int i = 0; i < 10000000; i++)
            {
                list.Add(i);//装箱；
            }

        }
    }
}
