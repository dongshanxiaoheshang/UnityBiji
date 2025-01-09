using System;
using System.Collections.Generic;
using System.Text;

namespace 构造函数练习
{
    public class Tickle
    {
        //写一个tickle函数，有一个距离属性（本属性只读，在构造函数中赋值）
        //不能为负数，有一个价格属性，价格属性只读，并且根据距离distanc计算价格Price（一元/公里）
        //0——100公里    不打折
        //101——200公里  95折
        //201——300公里 9折
        //300公里以上 8折；
        private double _distance;
        public double Distance
        {
            get { return _distance; }
        }
        public Tickle(double distance)
        {
            if (_distance < 0)
            {
                _distance = 0;
            }
            this._distance = distance;
        }
        private double _price;
        public double Price
        {
            get {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if (_distance > 101 && _distance <= 200)
                {
                    return _distance * 0.95;
                }
                else if (_distance > 200 && _distance <= 300)
                {
                    return _distance * 0.9;
                }
                else
                {
                    return _distance * 0.8;
                }
          }
        }
        public void ShowTickle()
        {
            Console.WriteLine("{0}公里的票价是{1}元", Distance, Price);
        }






        string _name;
        //属性的本质就是两个方法，get set
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        char _gender;
        public char Gender { get => _gender; set => _gender = value; }
        int _age;
        public int Age { get => _age; set => _age = value; }

       public void SayHello()//this当前类的对象
        {
            Console.WriteLine("{0},{1},{2}", this.Name, this.Age, this.Gender);
        }
       public Tickle(string name,int age,char gender)
        {
            this.Name=name;
            this.Age=age;
            this.Gender = gender;
        }
    }
}
