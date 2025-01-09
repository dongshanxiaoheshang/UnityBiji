using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统练习
{
    class calMN:calfather
    {
        public double M
        {
            get;
            set;
        }
        public double N
        {
            get;
            set;
        }
       public calMN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }
        public override double GetTotalMoney(double realmoney)
        {
            if (realmoney >= this.M)
            {
                return realmoney - (realmoney/this.M)*this.N;
            }
            else
            {
                return realmoney;
            }
        }
    }
}
