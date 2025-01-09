using System;

namespace 简单工厂设计模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你想要的品牌");
            string band = Console.ReadLine();
            NotBook nb = GetNotBook(band);
            nb.sayHello();  
        }
        public static NotBook GetNotBook(string band)
        {
            NotBook nb = null;
            switch (band)
            {
                case "Acre":nb = new Acre();
                    break;
                case "Leneovo":nb = new Leneovo();
                    break;
                case "Dell":nb = new Dell();
                    break;
                case "Icm":nb = new ICM();
                    break;
            }
            return nb;
        }    
    }
    public abstract class NotBook
    {
        public abstract void sayHello();
    }
    public class Acre: NotBook
    {
        public override void sayHello()
        {
            Console.WriteLine("我是宏基");
        }
    }
    public class ICM: NotBook
    {
        public override void sayHello()
        {
            Console.WriteLine("我是ICM");
        }
    }
    public class Leneovo : NotBook
    {
        public override void sayHello()
        {
            Console.WriteLine("我是联想");
        }
    }
    public class Dell : NotBook
    {
        public override void sayHello()
        {
            Console.WriteLine("我是戴尔");
        }
    }
}
