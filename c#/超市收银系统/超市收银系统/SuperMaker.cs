using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统
{
    class SuperMaker
    {
        //创建一个仓库对象
        cangku ck = new cangku();

        //创建仓库对象的时候，给货架上导入货物。
        public SuperMaker()
        {
            ck.GetPros("notebook", 1500);
            ck.GetPros("jiangyou", 3000);
            ck.GetPros("SamSung", 2500);
            ck.GetPros("banana", 620);
        }
        //询问客户的需求。
        public void AskBuying()
        {
            Console.WriteLine("欢饮光临，请问需要点什么");
            string strtype = Console.ReadLine();
            Console.WriteLine("你需要多少？");
            int num=Convert.ToInt32(Console.ReadLine());

            //去仓库取货。
            prodectFather[] pros= ck.OutPros(strtype, num);
            //算钱
            double money=getmoney(pros);
            Console.WriteLine("总共应付{0}元", money);
            Console.WriteLine("请你选择打折的方式，1---不打折，2--打九折，3--八五折，4--满300减五十，4--满500键一百");
            string input = Console.ReadLine();

            calfather cal=getcal(input);//getcal方法中返回值为calfather，所以要返回calfather
            double totalmoney=cal.GetTotallMoner(money);
            Console.WriteLine("打完折，你应支付{0}元", totalmoney);
        }
        //根据用户选择的打折方式，返回一个打折对象。
        public calfather getcal(string input)
        {
            calfather cal = null;
            switch (input)
            {
                case "1":cal = new calnomal();
                    break;
                case "2":cal = new calrate(0.9);
                    break;
                case "3":cal = new calrate(0.85);
                    break;
                case "4":cal = new calMN(300, 50);
                    break;
                case "5":cal = new calMN(500, 100);
                    break;
            }
            return cal;
        }
        //计算价钱。
        public double getmoney(prodectFather[] pros)
        {
            double  realmoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realmoney += pros[i].Priece;
            }
            return realmoney;
        }
        public void showpor()
        {
            ck.ShowPro();
        }

    }
}
