using System;

namespace 方法的总结
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] number = { 1, 2, 3, 5 };
            //double s=GetAvg(number);

            //Console.WriteLine(s);
            //Console.WriteLine("请输入一个人数字，");
            //string s=Console.ReadLine();
            //int number=GeySumnber(s);
            //bool b = IsPrism(number);
            //Console.WriteLine(b);

            //int score = Convert.ToInt32(Console.ReadLine());{  成绩的好坏}
            //string level = GetLeven(score);
            //Console.WriteLine(level);

            //数组内的内容反转；
            //string[] name = { "中国", "日本", "印度", "美国", "澳大利亚", "德国" };
            //for (int i = 0; i < name.Length/2; i++)
            //{
            //    string temp = name[i];
            //    name[i] = name[name.Length - 1 - i];
            //    name[name.Length - 1 - i] =temp;
            //}
            //for (int i = 0; i < name.Length ; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}
            double r = 5;
            double perimeter;
            double area;
            GetPerimeterArea(r,out perimeter ,out area );
            Console.WriteLine(r);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);

        }
        //public static double GetAvg(int[] d)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < d.Length; i++)
        //    {
        //        sum = sum + d[i];
        //    }
        //    double avg = sum / d.Length;
        //    return avg;
        //}
        public static bool IsPrism(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
        /// <summary>
        /// 判断成绩的好坏；
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        public static string GetLeven(int score)
        {
            string leven = "";
            switch (score / 10)
            {
                case 10:
                case 9: leven = "优";break;
                case 8: leven = "良";break;
                case 7: leven = "中";break;
                case 6: leven = "及格";break;
                //case 5:
                //case 4:
                //case 3:
                //case 2:
                //case 1:
                //case 0:leven = "不及格";break;
                default:leven = "不及格";break;
            }
            return leven;
        }
        
        public static void GetPerimeterArea(double r,out double perimeter,out double area)
        {
            perimeter = 3.14 * 2 * r;
            area = 3.14 * r * r;
        }
        
        
        public static int GeySumnber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("你输入的不对，请重新输入");
                    s= Console.ReadLine();
                  
                }
            }
            }
    }
}
