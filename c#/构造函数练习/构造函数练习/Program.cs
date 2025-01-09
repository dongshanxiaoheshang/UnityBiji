using System;

namespace 构造函数练习
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tickle t = new Tickle(150);
            t.ShowTickle();//实例的调用方法   对象.方法名；
            //Tickle.ShowTickle();//静态的调用方法   类名.方法名
            Console.ReadKey();
        }
    }
}
