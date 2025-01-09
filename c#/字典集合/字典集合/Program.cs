using System;
using System.Collections.Generic;

namespace 字典集合
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "张三");
            dic.Add(2, "李四");
            dic.Add(3, "王二");
            dic[1] = "新来的";
            foreach (KeyValuePair<int,string> kv in dic)
            {
                Console.WriteLine("{0}   {1}", kv.Key, kv.Value);
            }
            //foreach (var item in dic.Keys)
            //{
            //    Console.WriteLine("{0},{1}", item, dic[item]);
            //}
        }
    }
}
