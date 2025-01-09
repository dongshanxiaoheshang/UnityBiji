using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统
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
        public calMN(double M,double N)
        {
            this.M = M;
            this.N = N;

        }
        public override double GetTotallMoner(double realmoney)
        {
            if (realmoney >= this.M)
            {
                return  realmoney - (int)(realmoney / this.M) * this.N;
            }
            else
            {
                return realmoney;
            }
        }
    }
}
