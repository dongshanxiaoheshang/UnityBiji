using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统练习
{
    class calnomal : calfather
    {
        public override double GetTotalMoney(double realmoney)
        {
            return realmoney;
        }
    }
}
