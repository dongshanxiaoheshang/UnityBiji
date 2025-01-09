using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //将p这个对象传输到对方的电脑；
            //person p = new person();
            //p.Name = "张三";
            //p.Age = 25;
            //p.Gender = '男';
            //using (FileStream fsWrite = new FileStream(@"C:\Users\小伤刘\Desktop\笔记\111.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fsWrite, p);
            //}
            person k;
            using (FileStream fsRead=new FileStream(@"C:\Users\小伤刘\Desktop\笔记\111.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                k=(person)bf.Deserialize(fsRead);
            }
            Console.WriteLine(k.Age);
        }
    }
    public class person
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
    }
}
