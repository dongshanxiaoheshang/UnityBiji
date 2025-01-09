using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    class student
    {
        //构造函数

        public student(string name,int age,char gender ,int chinese ,int math,int english)//没有返回值，名称必须和类名一致；
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Math = math;
            this.Enlish = english;
            this.Chinese = chinese;
        }
        public student(string name,int chinesn,int math,int english):this(name,0,'c',chinesn,math,english)
        {
            //this.Name = name;
            //this.Chinese = chinesn;
            //this.Enlish = english;
            //this.Math = math;
        }
        public student(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        private string _name;//字段    对象
        public string Name//字段的属性
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value < 0 && value >= 100)
                {
                    value = 0;
                }
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get {
                if (_gender!='男' && _gender!='女'){
                    _gender = '男';
                }
                return _gender; }
            set { _gender = value; }
        }
        private int _chinese;
        public int Chinese
        {
            get { return _chinese;}
            set { _chinese = value; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
        private int _enlish;
        public int Enlish
        {
            get { return _enlish; }
            set { _enlish = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0}，今年我{1}岁了，我是{2}生", this.Name, this.Age, this.Gender);
        }
        public void ShoeScore()
        {
            Console.WriteLine("我的语文成绩是{0}，数学成绩是{1},英语成绩是{2}", this.Chinese, this.Math, this.Enlish);
        }





        //析构函数
    }
}
