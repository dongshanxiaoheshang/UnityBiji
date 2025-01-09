using System;

namespace 数组
{
    class Program
    {
        //public enum Gender
        //{
        //    男,
        //    女
        //}
        //public struct Person
        //{
        //    public int _age;
        //    public string _name;
        //    public Gender _gender;
        //}
        static void Main(string[] args)
        {
            //int[] nums = new int[10];
            //string[] str = new string[10];
            //double[] dou = new double[10];
            //Gender gender = Gender.男;
            //Person person;
            //person._gender = Gender.男;
            //person._name = "zhangsha ";
            #region;  数组；
            //int[] nums = {1,2,3,4,5,6,7,8,9,0 };
            //int max =nums[0]
            //int min = nums[];
            //int sum = 0;double avger;
            //int i;
            //for ( i = 0; i < nums.Length; i++)
            //{
            //    sum = sum + nums[i];
            //    if (nums[i] > max)
            //    {
            //        max = nums[i];
            //    }
            //    if (nums[i] < min)
            //    {
            //        min = nums[i];
            //    }
            //}
            //Console.WriteLine("这个数组的最大值是{0}最小值是{1}总和是{2}平均值是", max, min, sum, sum / nums.Length);
            #endregion;
            //string[] names = { "老汉", "老张", "老赵", "老马", "老刘", "老虎" };
            //string str = null;
            //for (int i = 0; i < names.Length-1; i++)
            //{
            //    str = str + names[i]+"|";
            //}
            //Console.WriteLine(str+names[names.Length-1]);
            string[] str = { "a", "b", "c" };
            string str1;
            for (int i = 0; i < str.Length/2; i++)
            {
                str1 = str[i];
                str[i] = str[str.Length - 1 - i];
                str[str.Length - 1 - i] = str1;
            }
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
          

        }
    }
}
