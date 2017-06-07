using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8拆装箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //拆装箱要看是否存在继承关系 装箱：值类型转换未应用类型 拆箱，引用类型转换为值类型
            //只有装过箱的数据才能拆箱
            int n = 10;
            Object o = n;//装箱 （整形转换为引用类型）
            int nn = (int)o;//拆箱

            //这个地方不存在任何的拆装箱（不存在继承关系）
            string str = "1234";
            int strIn = Convert.ToInt16(str);
        }
    }
}
