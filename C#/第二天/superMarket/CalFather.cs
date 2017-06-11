using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// 打折后抽象父类
/// </summary>
namespace superMarket
{
   abstract class CalFather
    {
        public abstract double GetToatalMoney(double realMoney);
    }
}
