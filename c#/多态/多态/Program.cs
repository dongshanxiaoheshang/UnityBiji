using System;

namespace 多态
{
    class Program
    {
        static void Main(string[] args)
        {
            
            chinese c1 = new chinese("韩梅梅");
            chinese c2 = new chinese("李磊");
            japanese j1 = new japanese("村上春树");
            japanese j2 = new japanese("京便是");
            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("金贤秀");
            America a1 = new America("科比布莱恩特");
            America a2 = new America("奥尼尔");
            person[] pers =  { c1,c2,j1,j2,k1,k2,a1,a2};
            for (int i = 0; i < pers.Length; i++)
            {
                pers[i].SayHello();//如果想看到每个人的，需要强转；
                //if(pers[i] is chinese)
                //{
                //    ((chinese)pers[i]).SayHello();
                //}
                //else if(pers[i] is japanese)
                //{
                //    ((japanese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Korea)
                //{
                //    ((Korea)pers[i]).SayHello();
                //}
                //else if(pers[i] is America)
                //{
                //    ((America)pers[i]).SayHello();
                //}
            }
        }
    }
    //lei
    public class person
    {
        //字段，属性，构造函数，方法；
        private string _name;
        public string Nmae
        {
            get { return _name; }
            set { _name = value; }
        }
        public person(string name)
        {
            this.Nmae = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }            
    }

    public class chinese : person
    {
        public chinese(string name):base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我教{0}",this.Nmae);
        }
    }

    public class japanese:person
    {
        public japanese(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是脚盆国人，我叫{0}", this.Nmae); 
        }
    }
    public class Korea : person
    {
        public Korea(string name) : base(name)
        {

        }
        public override void SayHello()
        {
            Console.WriteLine("我是高丽人，我叫{0}", this.Nmae);
        }
    }
    public class America : person
    {
        public America(string name) : base(name)
        {

        }
        public override void  SayHello()
        {
            Console.WriteLine("我是垃圾国人，我叫{0}", this.Nmae);
        }
    }



}
