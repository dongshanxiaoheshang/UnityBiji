using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统
{
    class cangku
    {
     

        //在仓库里添加货架，往货架添加商品
        List<List<prodectFather>> list = new List<List<prodectFather>>();
        //list<0> 笔记本
        //list<1> 三星手机
        //list<2> 酱油
        //list<3> 香蕉

        //展示货物。
        public void ShowPro()
        {
            foreach (var item in list)//item是list里面的货架。
            {
                Console.WriteLine( "我们超市有"+item[0].Name +","+"\t"+"有"+item.Count+"个"+"每个"+item[0].Priece );
            }
        }

        //在创建仓库对象的时候，向里面添加货架，
        public cangku()
        {
            list.Add(new List<prodectFather>());
            list.Add(new List<prodectFather>());
            list.Add(new List<prodectFather>());
            list.Add(new List<prodectFather>());
        }


        //添加到货架上要有类型和数量(进货)
        public void GetPros(string type, int count)
        {
            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "notebook":
                        list[0].Add(new notebook(Guid.NewGuid().ToString(), "笔记本", 5000));
                        break;
                    case "SamSung":
                        list[1].Add(new SamSung(Guid.NewGuid().ToString(), "三星", 2500));
                        break;
                    case "jiangyou":
                        list[2].Add(new jiangyou(Guid.NewGuid().ToString(), "酱油", 13000));
                        break;
                    case "banana":
                        list[3].Add(new banana(Guid.NewGuid().ToString(), "香蕉", 3000));
                        break;
                }
            }

        }
        //取货，必须知道货物的数量和类型；
        public prodectFather[] OutPros(string type, int count)
        {
            prodectFather[] pro = new prodectFather[count];//创建父类数组，来把商品拿走；
            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "notebook":pro[i] = list[0][0];           //list[0][0]代表的是list【0】(下标为0的元素)货架上最外面的商品
                        list[0].RemoveAt(0);                       //拿完之后，商品数量减一；
                        break;
                    case "SamSung":pro[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "jiangyou":pro[i] = list[2][0]; 
                        list[2].RemoveAt(0);
                        break;
                    case "banana":pro[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }   
            }
            return pro;
        }
        
    }
}
        
    

