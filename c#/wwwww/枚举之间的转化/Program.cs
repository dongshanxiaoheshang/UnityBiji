using System;

namespace 枚举之间的转化
{ public enum QQState
        {
            busy,
            online,
            offline,
        }
    class Program
    {
       
        static void Main(string[] args)
        {
            QQState station = QQState.offline;
            int n = (int)station;
            Console.WriteLine(n);
            Console.WriteLine((int)QQState.online);
            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }
}
