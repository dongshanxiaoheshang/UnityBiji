using System;

namespace 里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
             //子类可以赋值给父类 如果有一个地方需要一个父类作为参数，我们可以个一个子类代替
            student s = new student();
            person p = s;
            //如果父类中装的是子类对象，
            //那么可以将这个父类强转为子类对象
            //student ss = (student)p;//p为父类对象，里面包含着子类对象，强制转换为子类对象
            //ss.StudentSayHello();

            //teach ss = (teach)p;//p的类氏student，不能转化为teach；
            //ss.TeachSayHello();


            //is 的用法；
            //if(p is teach)
            //{
            //    teach ss=(teach)p;
            //    ss.TeachSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转化失败");
            //}


            //as的用法
           //(错误用法)
            teach t = p as teach;//将p转化为teach类，如果成功则返回t，如果不成功，则返回null；

            //正确用法
            student ss = p as student;
        }
    }
    
}
