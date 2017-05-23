using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            num[0] = 100;
            num[1] = 200;
            num[2] = 300;
            Array.Sort(num);
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine(num);
            Array.Reverse(num);
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine(num);
            double[] price = { 1.3, 2.4, 23.5 };
            double[] price2 = new double[3] { 1.3, 2.4, 23.5 };
            foreach (int k in price2)
            {   //在js中k是索引，但是在c#中，这里就是元素
                Console.WriteLine(k);
            }
            Console.ReadKey();
        }

    }
}