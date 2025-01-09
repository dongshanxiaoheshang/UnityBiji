using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统练习
{
    class SuperMarket
    {
        //货架上货
        cangku ck = new cangku();
        public SuperMarket()
        {
            ck.GetProdect("banana", 2000);
            ck.GetProdect("coco", 5000);
            ck.GetProdect("notebook",600);
            ck.GetProdect("baihuo",5000);     
        }
        //与顾客交流，询问买什么。
        public void AskSayong()
        {
            Console.WriteLine("欢迎光临，请问需要点什么。");
            string  input= Console.ReadLine();
            Console.WriteLine("需要多少？");
            int count=Convert.ToInt32(Console.ReadLine());
            //取货
            productFather[] pros= ck.OutProdect(input,count);
            //算钱
            double totalmoney=getMoney(pros);
            Console.WriteLine("好的，你一共需要支付{0}元，请问你需要打折吗？1--不打折，2--打九折，3--打八五折，4--满三百减五十，5--满五百减一百",totalmoney);
            string shuru=Console.ReadLine();
            calfather cal=getcal(shuru);
            double realmoney=cal.GetTotalMoney(totalmoney);
            Console.WriteLine("打完折后，您应付{0}元", realmoney);

        }
        //计算打折
        public calfather getcal(string input)
        {
            calfather  cal = null;
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

        //计算价钱；
        public double getMoney(productFather[] pros)
        {
           double realmoney = 0;
            for (int i = 0; i < pros.Length; i++)
            {
                realmoney = realmoney + pros[i].Priece;
            }
            return realmoney ;
        }
    }
}
