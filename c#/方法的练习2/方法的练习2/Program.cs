using System;

namespace 方法的练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //递归的实现，在方法中调用另一个方法；
            TellStory();
           
        }
       public static int i=0;
        public static void TellStory()
        {
            Console.WriteLine("从前有座山，");
            Console.WriteLine("山上有个庙");
            Console.WriteLine("庙里有个老和尚");
            Console.WriteLine("有一天，老和尚给小和尚说，我给你讲个故事吧");
           i++;
            if (i >= 10)
            {
                return;
            } 
            TellStory();
        }
    }
}
