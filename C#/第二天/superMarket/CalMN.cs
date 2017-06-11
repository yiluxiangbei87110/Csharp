using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 买多少送多少
/// </summary>
namespace superMarket
{
    class CalMN:CalFather
    {
        public double M
        {
            set;
            get;
        }
        public double N
        {
            set;
            get;
        }
        public CalMN(double m,double n)
        {
            this.M = m;
            this.N = n;
        }

        public override double GetToatalMoney(double realMoney)
        {
            if (realMoney > this.M)
            {
                return realMoney - (int)(realMoney / this.M) * this.N;
            }else
            {
                return realMoney;
            }
        }
    }
}
