using System;
using System.Collections;

namespace 集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //集合里可以添加所有的类型
            ArrayList list = new ArrayList();
            list.Add(522);
            list.Add("jhdkdnhcha");
            list.Add(3.14);
            list.Add('n');
            list.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });
            person p = new person();
            list.Add(p);
            list.AddRange(new int[] { 5, 6, 9, 8, 5, 46, 9, 9, 995, 5 });
            //list.Clear();移除所有元素；
            //list.Remove(522);移除单个元素
            //list.RemoveAt(0);移除下标为0的元素l
            //list.RemoveRange(0, 3);移除下标为0，1，2的元素
            //list.Sort();升序排列
            //list.Reverse()反转
            //list.Insert(1, "charu");在指定位置插入
            //list.InsertRange(0, new string[] { "kjd", "积极肯定" });在指定的位置插入数组；
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
                if(list[i] is person)
                {
                    ((person)list[i]).sayhello();
                }
                else if(list[i] is int[])
                {
                    for (int j = 0; j < ((int[])list[i]).Length; j++)
                    {
                        Console.WriteLine(((int[])list[i])[j]);
                    }
                }
            }
        }
        public class person
        {
            public void sayhello()
            {
                Console.WriteLine("nihao ");
            }
        }
    }
}
