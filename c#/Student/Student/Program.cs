using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            student wrPerson = new student("wanger", 100, 100, 100);
            wrPerson.SayHello();
            wrPerson.ShoeScore();
            student zsstudent = new student("张三",12,'男',88,23,56);//对象的实例化；构造函数，
            //zsstudent.Name = "张三";
            //zsstudent.Age = 22;
            //zsstudent.Gender = '男';
            //zsstudent.Chinese = 50;
            //zsstudent.Enlish = 17;
            //zsstudent.Math = 99;
            zsstudent.SayHello();
            zsstudent.ShoeScore();

            student xlstudent = new student("小兰",23,'女',55 ,65 ,96);
            
            xlstudent.SayHello();
            xlstudent.ShoeScore();
            student lsstunder = new student("li", 25, '男');
        }
    }
}
