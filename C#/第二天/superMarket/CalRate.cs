using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    class CalRate : CalFather
    {
        //自动属性和字段存都可以
        public double Rate
        {
            get;
            set;
        }
        public CalRate(double rate)
        {
            this.Rate = rate;
        }
        public override double GetToatalMoney(double realMoney)
        {
            return realMoney * this.Rate;
        }
    }
}
