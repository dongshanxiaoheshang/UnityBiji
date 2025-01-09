using System;

namespace 多态的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //realDuck rd = new realDuck();
            //mudDUck md = new mudDUck();
            //xpMud xd = new xpMud();
            //realDuck[] ducks = { rd, md, xd };
            //for (int i = 0; i < ducks.Length; i++)
            //{
            //    ducks[i].duck();
            //}




            //经理十一点打卡，员工九点打卡   程序员不打卡；
            emplayer yuan = new emplayer();
            manager jingli = new manager();
            chengxuyuan chengxu = new chengxuyuan();
            emplayer[] em = { yuan, jingli, chengxu };
            for (int i = 0; i < em.Length; i++)
            {
                em[i].daka();
            }


        }
        //public  class realDuck
        //{
        //    public virtual void duck()
        //    {
        //        Console.WriteLine("嘎嘎叫");
        //    }
        //}
        //public  class mudDUck:realDuck
        //{
        //    public override void duck()
        //    {
        //        Console.WriteLine("吱吱叫");
        //    }
        //}
        //public class xpMud:realDuck
        //{
        //    public override void duck()
        //    {
        //        Console.WriteLine("汪汪叫");
        //    }
        //}//嘎嘎叫
        


        public class emplayer
        {
            public virtual void daka()
            {
                Console.WriteLine("员工九点打卡");
            }
        }
        public class manager:emplayer
        {
            public override void daka()
            {
                Console.WriteLine("经理十一点打卡");
            }
        }
        public class chengxuyuan:emplayer
        {
            public override void daka()
            {
                Console.WriteLine("程序员不打卡");
            }
        }
    }
}
