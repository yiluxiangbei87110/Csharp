using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //隐式转换和显式转换（double类型放置int类型是可以的，隐式转换，但是反过来，int类型不能直接放置double类型的格式，此时显式转换）
            double a = 3.141592653;
            int b = (int)a;
            Console.WriteLine(b);
            Console.ReadLine();
            //隐式转换
            int c = 123;
            double d = c;//没问题

            //c#中提供了多种的转换方法 
            Console.WriteLine(d.ToString());
            //下面这些转化没有成功？？？？？？
            //Console.WriteLine(d.ToByte())
            //Console.WriteLine(d.ToInt16());
            //Console.WriteLine(d.ToInt32());
            //Console.WriteLine(d.ToDateTime());
            //Console.WriteLine(d.ToDecimal());
            //Console.WriteLine(d.ToChar());
            //Console.WriteLine(d.UInt64());

            string locstr ="7891";
            //如果要将"locstr"转成整型数
            //方法一: 用 Convert 
            int i = Convert.ToInt16(locstr);
            //方法二: 用 Parse
            int ii = int.Parse(locstr);
            Console.WriteLine(i);//123
            Console.WriteLine(ii);//7891

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("您刚刚输入的是数字是{0}", num);

            const double aa = 3.145;
            Console.WriteLine(aa);
            Console.ReadKey();
        }
    }
}
