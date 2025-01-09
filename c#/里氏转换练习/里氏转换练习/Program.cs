using System;

namespace 里氏转换练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //student s = new student();
            //person p = new person();

            person[] p = new person[10];
            Random re = new Random();
            
            for (int i = 0; i < p.Length; i++)
            {
                int num = re.Next(1, 7);
                switch (num)
                {
                    case 1:p[i] = new student();
                        break;
                    case 2:p[i] = new women();
                        break;
                    case 3:p[i] = new teach();
                        break;
                    case 4:p[i] = new shuaiguo();
                        break;
                    case 5:p[i] = new yesou();
                        break;
                    case 6:p[i] = new person();
                        break;
                }
            }
            for (int i = 0; i < p.Length; i++)
            {
                //p[i].SayHello();
                if(p[i] is teach)
                {
                    ((teach)p[i]).teachsayhello();
                }
                else if(p[i] is student)
                {
                    ((student)p[i]).studentsayhello();
                }
                else  if(p[i] is shuaiguo)
                {
                    ((shuaiguo)p[i]).shuaiguosayhello();
                }
                else if(p[i] is women)
                {
                    ((women)p[i]).womensayhello();
                }
                else if (p[i] is yesou)
                {
                    ((yesou)p[i]).yesousayhello();
                }
                else if (p[i] is person)
                {

                    ((person)p[i]).SayHello();
                }
            }
        }
    }
    public class person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class student:person
    {
        public void studentsayhello()
        {
            Console.WriteLine("我是学生");
        }
    }
    public class women:person
    {
        public void womensayhello()
        {
            Console.WriteLine("我是美女");
        }
    }
    public class teach:person
    {
        public void teachsayhello()
        {
            Console.WriteLine("我是老师");
        }
    }
    public class shuaiguo : person
    {
        public void shuaiguosayhello()
        {
            Console.WriteLine("我是帅锅");
        }
    }
    public class yesou : person
    {
        public void yesousayhello()
        {
            Console.WriteLine("我是野兽");
        }
    }
}
