using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9方法
{
    class Program
    {
        public static int _n = 1000;//全局都可以使用
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 20;
            //int max = Program.GetMax(n1, n2); 两种调用方式都是可以的
            int max = GetMax(n1,n2);
            Console.WriteLine(max);
            Console.ReadKey();
        }
        /// <summary>
        /// 返回两个int型数据的最大值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static int GetMax(int a,int b)
        {
            return a > b ? a : b;
        }
    }
}
