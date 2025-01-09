using System;

namespace _222222
{
    class Program
    {
        //public struct Person
        //{
        //    public string _name;
        //    public int _age;
        //    public Gernde _gender;
        //}
        //public enum Gernde
        //{
        //    男,
        //    女
        //}
        //public struct MyColor
        //{
        //    public int _red;
        //    public int _green;
        //    public int _blue;
        //}
        public struct Person
        {
            public string _name;
            public int _age;
            public Gender _gender;
        }
        public enum Gender
        {
            男,
            女
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Person zsPerson;
            //zsPerson._name = "张三";
            //zsPerson._age = 20;
            //zsPerson._gender = Gernde.男;
            //Console.WriteLine(zsPerson._gender);
            //Person lsPerson;
            //lsPerson._name = "李四";
            //lsPerson._age = 22;
            //lsPerson._gender = Gernde.女;
            //MyColor mc;
            //mc._red = 255;
            //mc._green = 0;
            //mc._blue = 255;

            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 18;
            zsPerson._gender = Gender.男;
            Console.WriteLine("我叫{0},我今年{1},我是{2}生", zsPerson._name, zsPerson._age, zsPerson._gender);


           
        }
    }
}
