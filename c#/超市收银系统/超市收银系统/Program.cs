using System;

namespace 超市收银系统
{
    class Program
    {
        static void Main(string[] args)
        {
            //假设超市有四种商品   笔记本，   酱油  香蕉  三星手机。每个商品必须含有价格，数量，编码。
            //当货架上的商品不够了，需要向仓库拿货，然后就需要一个仓库，仓库功能：进货，存货，提货。
            //所以要有一个父类包含价格，数量，编码。

            //创建超市对象
            SuperMaker sm = new SuperMaker();
            //展示货物
            sm.showpor();
         
            //与客户交流
            sm.AskBuying();



        }
    }
}
