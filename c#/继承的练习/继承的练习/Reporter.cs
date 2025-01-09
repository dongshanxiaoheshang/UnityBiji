using System;
using System.Collections.Generic;
using System.Text;

namespace 继承的练习
{
    public class person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public person(string name,int age,char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
    public class Reporter:person
    {
        public Reporter(string name,int age ,char gender,string hobby) : base(name, age, gender)
        {
            this.Hobby = hobby;
        }
        private string _hobby;
        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }
      public void SayHello()
        {
            Console.WriteLine("我叫{0}，我喜欢{1}，我是{2}生，我今年{3}达了", this.Name, this.Hobby, this.Gender, this.Age);
        }
    }
}
