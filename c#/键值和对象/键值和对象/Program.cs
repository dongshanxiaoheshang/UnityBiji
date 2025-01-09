using System;
using System.Collections;

namespace 键值和对象
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable ht = new Hashtable();
            ht.Add(1, "张山");
            ht.Add(2, '男');
            ht.Add(3, true);
            ht.Add(false, "错误的");
            ht[5] = "新来的";//这也是一种添加数据的方法；
            ht[1] = "把张三干掉";


            //ht.Clear();//清空
            ht.Remove(3);//移除键为3 的值；
            //abc-----cba
            if (!ht.ContainsKey("abc"))
            {
                ht.Add("abc", "bac");
            }
            else
            {
                Console.WriteLine("已经包含了");
            }
            //在键值对集合中，是根据键找值；
            Console.WriteLine(ht[1]);
            Console.WriteLine(ht[2]);
            Console.WriteLine(ht[3]);
            Console.WriteLine(ht[false]);
            foreach(var item in ht.Keys)//ht.keys是ht中的键的集合；
            {
                Console.WriteLine("键是{0}，，，值是{1}", item, ht[item]);
            }




            //for (int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht[i]);
            //}
        }
    }
}
