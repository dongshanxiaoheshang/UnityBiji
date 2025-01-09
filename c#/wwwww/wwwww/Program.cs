using System;

namespace 枚举
{
    class Program
    {
        public enum Gender
        {
            男,
            女
        }
        public enum Qqstation
        {
            online,
            offline,
            busy
        }
        static void Main(string[] args)
        {
            //const int number = 50;
            //Console.WriteLine("number");
            Gender gerder = Gender.男;
            Gender gerders = Gender.女;
            // Console.WriteLine("gerder");
            Qqstation stion = Qqstation.busy;
            Qqstation stions = Qqstation.offline;

              
        }
    }
}
