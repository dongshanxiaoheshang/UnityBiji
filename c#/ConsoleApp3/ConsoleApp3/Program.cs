using System;

namespace 枚举之间的转化
{
    public enum QQState
    {
        busy,
        online,
        offline,
    }
    class Program
    {

        static void Main(string[] args)
        {
            #region 将枚举类型转化为int
            //  QQState station = QQState.offline;
            // int n = (int)station;
            //Console.WriteLine(n);
            // Console.WriteLine((int)QQState.online);
            // Console.WriteLine((int)QQState.busy);
            // Console.WriteLine("hello world");
            //  Console.ReadKey();
            #endregion

            #region 将int转化为枚举
            // int n = 2;
            // QQState station = (QQState)n;
            // Console.WriteLine(station);
            #endregion

            // QQState state = QQState.online;
            //string s;
            //s = state.ToString();
            //Console.WriteLine(s);
            //string s = "0";
            //QQState state = (QQState)Enum.Parse(typeof(QQState), s);
            //Console.WriteLine(state);
            Console.WriteLine("请输入你的qq在线状态 1--online 2--offline 3--busy");
            string s = Console.ReadLine();
            switch (s)
            {
                case "1":QQState state = (QQState)Enum.Parse(typeof(QQState), s);
                    Console.WriteLine("你的在线状态是{0}",state);
                        break;
                case "2":QQState state1 = (QQState)Enum.Parse(typeof(QQState), s);
                    Console.WriteLine("你定义的在线状态是{0}", state1);
                    break;
            }
        }
    }
}
