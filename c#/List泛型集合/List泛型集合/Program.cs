using System;
using System.Collections.Generic;

namespace List泛型集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建泛用性集合对象；
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(5);
            list.AddRange(new int[] { 1, 2, 3, 5, 6, 9, 8, 6, 5, 4, });

            //list泛用性集合可以转换为数组；
            int[] num=list.ToArray();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
        }
    }
}
