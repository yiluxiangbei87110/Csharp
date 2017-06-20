using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    class SuperMarket
    {   
        /// <summary>
        /// 创建超市对象到时候，给仓库的货架导入货物
        /// </summary>
        CangKu ck = new CangKu();
        public SuperMarket()
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
            string strType = Console.ReadLine();
            if(strType!="Acer" && strType != "SumSung" && strType != "JiangYou" && strType != "Banana")
            {
                Console.WriteLine("我们商店没有这种商品！");
            }else
            {
                Console.WriteLine("需要多少");
                int count = Convert.ToInt32(Console.ReadLine());
                //取货物
                ProductFather[] pros = ck.QuPros(strType, count);
                //下面该就算价钱了
                double realMoney = GetMoney(pros);
                Console.WriteLine("您总共应该付款{0}元", realMoney);
                Console.WriteLine("请选择您的打折方式1--不打折，2--打9折，3-85折,4--满300减50，满500减100");
                string input = Console.ReadLine();
                //根据用户输入，获得一个打折对象。
                CalFather cal = GetCal(input);
                double totalMoney = cal.GetToatalMoney(realMoney);
                Console.WriteLine("打完折，您应该付款{0}元", totalMoney);
            }
        }
        //结算
        public double GetMoney(ProductFather[] pros)
        {
            double realMonery = 0;
            for(int i = 0; i < pros.Length; i++)
            {
                realMonery += pros[i].Price;
            }
            return realMonery;
        }
        //打折方式 。根据用户输入，获得一个打折对象。选择打折对象，返回父类对象，但是里面装的是子类对象（屏蔽差异性）
        public CalFather GetCal(string input)
        {
            CalFather cal = null;
            switch (input)
            {
                case "1":
                    cal = new CalNormal();
                    break;
                case "2":
                    cal = new CalRate(0.9);
                    break;
                case "3":
                    cal = new CalRate(0.85);
                    break;
                case "4":
                    cal = new CalMN(300,50);
                    break;
                case "5":
                    cal = new CalMN(500,100);
                    break;
            }
            return cal;
        }
        
        //展示货物
        public void ShowPros()
        {
            ck.Showpros();
        }

    }
}
