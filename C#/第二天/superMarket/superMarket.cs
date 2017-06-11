using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    class superMarket
    {   
        /// <summary>
        /// 创建超市对象到时候，给仓库的货架导入货物
        /// </summary>
        CangKu ck = new CangKu();
        public superMarket()
        {
            ck.JinPros("Acer", 100);
            ck.JinPros("SumSung", 100);
            ck.JinPros("JiangYou", 1000);
            ck.JinPros("Banana", 100);
        }
        //需要买什么东西
        public void AskBuying()
        {
            Console.WriteLine("请问您要什么东西？");
            Console.WriteLine("我们有鸿基电脑，三星手机，香蕉，酱油");
            string strType = Console.ReadLine();
            Console.WriteLine("需要多少");
            int count = Convert.ToInt32(Console.ReadLine());
            //取货物
             ProductFather[] pros= ck.QuPros(strType,count);
            //下面该就算价钱了
            double realMoney = getMoney(pros);
            Console.WriteLine("您总共应该付款{0}元",realMoney);

        }
        //结算
        public double getMoney(ProductFather[] pros)
        {
            double realMonery = 0;
            for(int i = 0; i < pros.Length; i++)
            {
                realMonery += pros[i].Price;
            }
            return realMonery;
        }
    }
}
