using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    class CangKu
    {
        //存储货物
        //List<SumSung> listS = new List<SumSung>();
        //List<JiangYou> listJ = new List<JiangYou>();
        //List<Banana> listB = new List<Banana>();
        //List<Acer> listA = new List<Acer>();
        //上面太繁琐 下面这种，如果取三星等值，这种不好取值
        //List<ProductFather> list = new List<ProductFather>();
        //可以多一个集合，当做货架 屏蔽子类差异性
        List<List <ProductFather>> list=new List<List<ProductFather>>();
        //在创建仓库对象的时候添加像仓库中添加货架
        public CangKu()
        {
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
            list.Add(new List<ProductFather>());
        }
        public void showpros()
        {
            foreach(var item in list)
            {
                Console.WriteLine("我们超市有：" + item[0].Name + "," + "\t" + "有" + item.Count + "个," + "\t" + "每个" + item[0].Price + "元");
            }
        }
        /// <summary>
        ///  仓库进货
        /// </summary>
        /// <param name="strType">类型</param>
        /// <param name="count">数量</param>
        public void JinPros(string strType,int count)
        {
            for(int i = 0; i < count; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        list[0].Add(new Acer(Guid.NewGuid().ToString(), 1000, "弘基笔记本"));
                        break;
                    case "SumSung":
                        list[1].Add(new SumSung(Guid.NewGuid().ToString(), 1800, "假三星"));
                        break;
                    case "Banana":
                        list[2].Add(new Banana(Guid.NewGuid().ToString(), 45, "香蕉"));
                        break;
                    case "JiangYou":
                        list[3].Add(new JiangYou(Guid.NewGuid().ToString(), 7, "酱油"));
                        break;
                }
            }
        }

        public ProductFather[] QuPros(string strType,int count)
        {
            //也可以用集合，但是数组已经够用了。
            ProductFather[] pros = new ProductFather[count];
            for(int i = 0; i < pros.Length; i++)
            {
                switch (strType)
                {
                    case "Acer":
                        if (list[0].Count != 0)
                        {
                            pros[i] = list[0][0];
                            list[0].RemoveAt(0);
                        }else
                        {
                            Console.WriteLine("已经没有货物了");
                        }
                        break;
                    case "SunSung":
                        if (list[0].Count != 0)
                        {
                            pros[i] = list[1][0];
                            list[0].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("已经没有货物了");
                        }
                        break;
                    case "Banana":
                        if (list[0].Count != 0)
                        {
                            pros[i] = list[2][0];
                            list[0].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("已经没有货物了");
                        }
                        break;
                    case "JiangYou":
                        if (list[0].Count != 0)
                        {
                            pros[i] = list[3][0];
                            list[0].RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("已经没有货物了");
                        }
                        break;
                }
            }
            return null;
        }
    }
}
