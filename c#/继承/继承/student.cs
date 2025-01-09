using System;
using System.Collections.Generic;
using System.Text;

namespace 继承
{
    class person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private void CHLAS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
        public person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
    class student : person//person是student的父类，student可以直接使用person的neirong；
    {
        public student(string name, int age, char gender,int id) : base(name, age, gender)
        {
            this.Id = id;
        }
        private int _id;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public void Xuexi()
        {
            Console.WriteLine("我会学习");
        }
    }
    class teacher:person
    {
        public teacher(string name,int age,char gender,double salary) : base(name, age, gender)
        {
            this.Salary=salary;
        }
        private double _salary;
        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        //private void CHLAS()
        //{
        //    Console.WriteLine("吃喝拉撒睡");
        //}
        public void Teach()
        {
            Console.WriteLine("我会教书");
        }

    }
    class drive
    {
        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        //private char _gender;
        //public char Gender
        //{
        //    get { return _gender; }
        //    set { _gender = value; }
        //}
        //private int _age;
        //public int Age
        //{
        //    get { return _age; }
        //    set { _age = value; }
        //}
        //private double _driveTime;
        //public double DriveTime
        //{
        //    get { return _driveTime; }
        //    set { _driveTime = value; }
        //}
        //public void CHLAS()
        //{
        //    Console.WriteLine("吃喝拉撒睡");
        //}
        public void Drive()
        {
            Console.WriteLine("我会开车");
        }

    }
}
