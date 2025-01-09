using System;

namespace 字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //随即说出你心中想的一个名字，然后输出他的字符串长度  Length：字符串的长度；
            //Console.WriteLine("说出你心中想的一个名字");
            //string name = Console.ReadLine();
            //Console.WriteLine("他的字符串长度为{0}", name.Length);



            //两个学员输入各自喜欢的课程名称，判断是否一致，如果相等，则输出你们喜欢的课程
            //如果不相等，输出各自的课程；c#和 C#同一门课程；
            //Console.WriteLine("输入喜欢的课程名称");
            //string lessonOne = Console.ReadLine();
            // lessonOne = lessonOne.ToUpper();//将字符串中的小写全部转换为大写；
            //lessonOne = lessonOne.ToLower();//将字符串中的小写全部转换为小写；
            //Console.WriteLine("输入喜欢的课程名称");
            //string lessonTwo = Console.ReadLine();
            //lessonTwo = lessonTwo.ToUpper();
            ////if (lessonOne == lessonTwo)
            ////{
            ////    Console.WriteLine("");
            ////}
            //if (lessonOne.Equals(lessonTwo,StringComparison.OrdinalIgnoreCase))//比较时可以忽略字符串的大小写；
            //{
            //    Console.WriteLine("");
            //}
            //else
            //{
            //    Console.WriteLine();
            //}


            //string s = "a  b  c  =  _  +  ,,";
            //char[] chs = { ' ', '=', '_', '+', ',' };//分割字符串split；
            //string[] str = s.Split(chs, StringSplitOptions.RemoveEmptyEntries);
            //Console.ReadKey();

            //从字符串（2008-08-08）分析出年月日；2008年08月08日；
            //让用户输入一个日期格式如2008-01-02，你输入的日期为2008年1月2日；
            //string s = "2008-08-08";
            //char[] cha = { '-' };
            //string[] date = s.Split(cha, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日", date[0], date[1], date[2]);
            //Console.ReadKey();



            //替换字符串中的关键字
            //string s = "国家关键人物 小尚";
            //if (s.Contains("小尚"))
            //{
            //    s=s.Replace("小尚", "**");
            //}
            //Console.WriteLine(s);

            //Substring   截取字符串；
            //string str = "今天天气好晴朗，处处好风光";
            ////str = str.Substring(2);//数字是几 ，从第几除开始截取；
            //str = str.Substring(1, 2);//从下标为1的位置开始截取俩个字符；
            //Console.WriteLine(str);
            //Console.ReadKey();


            //string str = "今天天气好晴朗，处处好风光";
            // int index = str.IndexOf("天");//第一次出现的位置
            //Console.WriteLine(index);
            //Console.ReadKey();


            //string str = "今天天气好晴朗，处处好风光";
            //int index = str.LastIndexOf("好");//最后一个出现的位置
            //Console.WriteLine(index);


            //目的：拿到周杰伦.mp3
            //LastIndex  Substring  @取消斜线在字符串中的转译作用；
            //string path = @"c:\b\f\d\a\s\f\ff周g\fs\gs\g周gsg\s\s\ad\asf\a\周杰伦.mp3";
            //int index = path.LastIndexOf("\\");//\\代表一个\
            //path = path.Substring(index+1);
            //Console.WriteLine(path);

            //目的 去空格
            //string str = "      hahahahha       ";
            //str = str.Trim();//去掉所有的空格
            //str = str.TrimEnd();//去掉后面的
            //str = str.TrimStart();//去掉前面的


            //目的  添加|
            string[] name = { "张三", "李四", "王二", "王五", "赵六" };
            string nameNew = string.Join("|", name);//jion 在字符串中的每个元素后面添加"|"，最后一个元素不加；
            Console.WriteLine(nameNew);

        }
    }
}
