using System;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗汪汪叫，猫喵喵叫；
            animal an = new dog();
            an.bark();

        }
        public abstract class animal
        {
            public abstract void bark();//抽象函数没有方法体；
           
        }
        public class dog : animal
        {
            public override void bark()
            {
                Console.WriteLine("狗在叫");
            }
        }
        public class cat : animal
        {
            public override void bark()
            {
                Console.WriteLine("猫在叫");
            }
        }
    }
}
