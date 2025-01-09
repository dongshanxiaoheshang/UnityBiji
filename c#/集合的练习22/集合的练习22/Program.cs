using System;
using System.Collections;
using System.Collections.Generic;

namespace 集合的练习22
{
    class Program
    {
        static void Main(string[] args)
        {
            //将一个数组中的奇数放到一个集合中，偶数放到另一个集合中；最终将两个集合合并在一起，
            //并且奇数在集合左边，偶数在集合右边；
            //int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //List<int> listou = new List<int>();
            //List<int> listj = new List<int>();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 == 0)
            //    {
            //        listou.Add(num[i]);
            //    }
            //    else
            //    {
            //        listj.Add(num[i]);
            //    }
            //}
            //listj.AddRange(listou);
            //foreach (int item in listj)
            //{
            //    Console.Write(item);
            //}

            //提示用户输入一个字符串，然后用foreach循环将用户输入的字符串赋值给一个字符；
            //Console.WriteLine("请输入一个字符串");
            //string str = Console.ReadLine();
            //char[] cha = new char[str.Length];
            //int i = 0;
            //foreach (var item in str)
            //{
            //    cha[i] = item;
            //    i++;
            //}
            //foreach (var item in cha)
            //{
            //    Console.WriteLine(item);
            //}




            //统计welcome to china中每个字符串出现的位置，不考虑大小写；
            //字符——————————————》出现的次数、、
            //键————————————————》值;
            string str = "welcome to china";
            Dictionary<char, int> dic = new Dictionary<char, int>();
            for (int i = 0; i < str.Length; i++)
            {
                if(str[i]==' ')
                {
                    continue;
                }
                if (dic.ContainsKey(str[i]))
                {
                    dic[str[i]]++;
                }
                else
                {
                    dic[str[i]] = 1;
                }
            }
            foreach (KeyValuePair<char,int> kv in dic)
            {
                Console.WriteLine("{0}{1}", kv.Key, kv.Value);
            }
        }

    }
}
