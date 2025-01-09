using System;
using System.Collections.Generic;

namespace 超市收银系统练习
{
    class cangku
    {
        //1存放货物。添加货架
        List<List<productFather>> list = new List<List<productFather>>();


        public cangku()
        {
            list.Add(new List<productFather>());
            list.Add(new List<productFather>());
            list.Add(new List<productFather>());
            list.Add(new List<productFather>());
        }
        //进货
        public void GetProdect(string type, double num)
        {
            for (int i = 0; i < num; i++)
            {
                switch (type)
                {
                    case "banana":
                        list[0].Add(new banana(Guid.NewGuid().ToString(), "香蕉", 5));
                        break;
                    case "coco":
                        list[1].Add(new coco(Guid.NewGuid().ToString(), "可乐", 3));
                        break;
                    case "baihuo":
                        list[2].Add(new baihuo(Guid.NewGuid().ToString(), "百货", 26));
                        break;
                    case "notebook":
                        list[3].Add(new notebook(Guid.NewGuid().ToString(), "笔记本", 6500));
                        break;
                }
            }
        }
        //取货.
        public productFather[] OutProdect(string type, int num)
        {
            productFather[] pros = new productFather[num];
            for (int i = 0; i < num; i++)
            {
                switch (type)
                {
                    case "banana":
                        pros[i] = list[0][0];
                        list[0].RemoveAt(0);
                        break;
                    case "coco":
                        pros[i] = list[1][0];
                        list[1].RemoveAt(0);
                        break;
                    case "baihuo":
                        pros[i] = list[2][0];
                        list[2].RemoveAt(0);
                        break;
                    case "notebook":
                        pros[i] = list[3][0];
                        list[3].RemoveAt(0);
                        break;
                }
            }
            return pros;
        }
    }
}
