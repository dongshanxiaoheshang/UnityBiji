using System;

namespace lianxilll
{
    class Program
    {
        static void Main(string[] args)
        {
            //调用示例成员；
            //person p = new person();//创建对象；
            //p.m1();//调用m1调用非静态方法（实例），对象名.实例成员；
            //person.m2();//调用m2调用静态方法，类名.静态成员名；
            //Console.ReadLine();


            person p = new person();//类的实例化
            p.Age = 23;
            p.Name = "zhangsna ";
            p.Gender = '男';//对象的初始化
            p.SayHello();
           


        }
    }
}
