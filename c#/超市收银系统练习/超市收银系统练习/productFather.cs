using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统练习
{
    class productFather
    {
        public double Priece
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public productFather(string id,string name,double priece)
        {
            this.Name = name;
            this.ID = id;
            this.Priece = priece;
        }
    }
}
