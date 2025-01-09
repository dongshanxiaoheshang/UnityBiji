using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统
{
    class prodectFather
    {
        public double Priece
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public string  Name
        {
            get;
            set;
        }
        public prodectFather(string id, string name, double priece)
        {
            this.ID = id;
            this.Name= name;
            this.Priece = priece;
        }
    }
}
