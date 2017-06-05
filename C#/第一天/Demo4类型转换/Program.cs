using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3;
            int n2 = 10;
            double tmp = 3.0;
            double n3 = n2 / n1;
            double n4 = n2 * 1.0 / n1;
            double n5 = n2 / tmp;
            Console.WriteLine(n3);//3
            Console.WriteLine(n4);//3.33333333333333;
            Console.WriteLine(n5);//3.33333333333333;
            //通过占位符控制小数个数
            Console.WriteLine("{0:0.00}", n5);//3.33
            //Next(MaxValue)随机产生小于最大数的整数
            Random random = new Random();
            Console.WriteLine("产生的随机数是{0}",random.Next(1, 9));
            Console.ReadKey();
        }
    }
}
