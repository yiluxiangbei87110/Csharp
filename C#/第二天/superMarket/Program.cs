using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    class Program
    {
        static void Main(string[] args)
        {   //创建超市对象
            superMarket sm = new superMarket();
            //展示货物
            sm.showPros();
            //用户交互
            sm.AskBuying();
            Console.ReadKey();
        }
    }
}
