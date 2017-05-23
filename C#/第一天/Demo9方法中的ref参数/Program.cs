using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9方法中的ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000.12;
            //1虽然调用，但是并不影响这个代码块里salary的值
            Salary(salary);
            Console.WriteLine(salary);//5000.12 调用了，但是此方法没有返回值
            Console.ReadKey();

            //2又返回值，正常使用
            double s2 = Salary2(salary);
            Console.WriteLine(s2);
            Console.ReadKey();

            //3使用ref参数，解决第一种情况下的问题
            Salary3(ref salary);
            Console.WriteLine(salary);
            Console.ReadKey();
            int n1 = 100;int n2 = 10;
            ChangValue(ref n1, ref n2);
            Console.WriteLine("现在n1是：{0}，现在n2是：{1}", n1, n2);//10 100
            Console.ReadKey();
        }
        public static void Salary(double s)
        {
            s += 500;
        }
        public static double Salary2(double s)
        {
           return  s += 500;
        }
        public static void Salary3(ref double s)
        {
            s += 5000;
        }
        //ref 参数小的例子 完成交换
        public static void ChangValue(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

    }
}


