using System;

namespace jiekou
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
    public class person
    {
        public void CHLS()
        {
            Console.WriteLine("我可以吃喝拉撒睡");
        }
    }
    public class NBAPlayer
    {
        public void kouLan()
        {
            Console.WriteLine("我可以扣篮");

        }
    }
    public class student:person,ikoulan
    {
        public void kouLan()
        {
            Console.WriteLine("我已可以扣蓝了");
        }
    }
    public interface ikoulan
    {
        void kouLan();
    }
}
