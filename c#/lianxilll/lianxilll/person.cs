using System;
using System.Collections.Generic;
using System.Text;

namespace lianxilll
{
   public class person
    {
        public void m1()
        {
            Console.WriteLine("我是非静态方法");//实例成员
        }
        public static void m2()
        {
            Console.WriteLine("我是静态方法");
        }
        //字段，属性，方法；
        private string _name;//字段只能在当前类中使用
        public string Name//想要访问字段，必须需要属性来访问 
        {
            get {
                if (_name != "张三")
                {
                    _name = "张三";
                }
                
                return _name; }//判断属性的值是否为张三
            set { _name = value; }//赋值   判断value的值
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if (value < 0 && value > 100)
                {
                    value = 0;
                }
                
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get {
                if (_gender != '男' && _gender != '女') ;
                {
                    _gender = '男';
                }
                
                return _gender; }
            set { _gender = value; }
        }
       public  void SayHello()
        {
            Console.WriteLine("你好。我叫{0}，我今年{1}岁了，我是{2}生",this.Name,this.Age,this.Gender);
        }
    }
}
