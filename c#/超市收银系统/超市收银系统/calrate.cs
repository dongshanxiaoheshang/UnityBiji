using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统
{
    class calrate:calfather
    {
        //private double rate;
        public double Rate
        {
            get;
            set;
        }
        public calrate (double rate)
        {
            this.Rate = rate; 
        }

        public override double GetTotallMoner(double realmoney)
        {
            return realmoney * this.Rate;
        }
    }
}
