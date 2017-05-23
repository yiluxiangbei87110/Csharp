using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10重载
{
    class Program
    {
        static void Main(string[] args)
        {
            L(10,23);

            double a = 12.3456;
            Console.WriteLine(a);//12.3456
            string ac = a.ToString("0.00");
            a = Convert.ToDouble(ac);
            Console.WriteLine(a);//12.35
            Console.ReadKey();


        }
        public static int L(int a,int b) {
            return a + b;
        }
        //和返回值没有关系，下面这句如果加上去的话就会报错。
        //public static void L(int c, int d)
        //{
        //    int result = c + d;
        //}


        public static double L(double d1, double d2)
        {
            return d1 + d2;
        }
        public static void L(int n1, int n2, int n3)
        {
            int result = n1 + n2 + n3;
        }
        public static string L(string s1, string s2)
        {
            return s1 + s2;
        }
    }
}
