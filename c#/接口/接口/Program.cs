using System;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable fly = new Brid();
            //fly.fly();//接口中的飞；
            //Brid fly1 = new Brid();
            //fly1.fly();


            //小练习
            //真鸭子会游泳，木头鸭子不会游泳，橡皮鸭会游泳；
            ISwimming reduck = new xpDuck();//new ReadDuck();
            reduck.swimming();
          

        }
    }
    public class Brid:IFlyable
    {
        public void fly()
        {
            Console.WriteLine("我是类中的飞");
        }
        void IFlyable.fly()//显示实现接口，可以解决重名问题。
        {
            Console.WriteLine("我是接口的飞");
        }

    }
    public interface IFlyable
    {
        void fly();
    }


    public class ReadDuck:ISwimming
    {
       public void swimming()
        {
            Console.WriteLine("真鸭子会游泳");
        }
    }
    public class muDuck
    {

    }
    public class xpDuck:ISwimming
    {
        public void swimming()
        {
            Console.WriteLine("橡皮鸭子会游泳");
        }
    }
    interface ISwimming
    {
        void swimming()
        {

        }
    }

}
