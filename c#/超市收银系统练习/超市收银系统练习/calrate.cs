using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统练习
{
    class calrate : calfather
    {
       public double Rate
        {
            get;
            set;
        }
        public  calrate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetTotalMoney(double realmoney)
        {
            return realmoney * this.Rate;
        }

    }
}
