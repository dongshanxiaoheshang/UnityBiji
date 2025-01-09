using System;
using System.Collections.Generic;
using System.Text;

namespace 超市收银系统
{

    //不打折，
    class calnomal:calfather
    {
        public override double GetTotallMoner(double realmoney)
        {

            return realmoney;
        }

    }
}
