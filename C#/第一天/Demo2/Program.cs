using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字");
            string str = Console.ReadLine();
            int num = Convert.ToInt16(str);
            Console.WriteLine("你输入的是{0}", num);
            Console.WriteLine("你输入的是"+str);
            Console.WriteLine("你输入的是{0}", str);
            Console.ReadKey();
        }
    }
}
