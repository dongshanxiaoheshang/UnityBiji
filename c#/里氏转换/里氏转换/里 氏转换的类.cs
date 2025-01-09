using System;
using System.Collections.Generic;
using System.Text;

namespace 里氏转换
{
    class 里_氏转换的类
    {
        public class person
        {
            public void SayHello()
            {
                Console.WriteLine("");
            }
        }
        public class student : person
        {
            public void StudentSayHello()
            {
                Console.WriteLine();
            }
        }
        public class teach:person
        {
            public void TeachSayHello()
            {
                Console.WriteLine();
            }
        }
    }
}
