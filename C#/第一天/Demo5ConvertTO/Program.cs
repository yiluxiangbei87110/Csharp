using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5ConvertTO
{
    class Program
    {
        static void Main(string[] args)
        {
            double scoreRe = 0.0;
            bool flag = true;
            Console.WriteLine("请输入你的成绩");
            try
            {
                scoreRe = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("您输入的内容不能转化为数字");
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("你的成绩是{0}", scoreRe);
            }else
            {
                Console.WriteLine("not  ok ");
            }
            Console.WriteLine('1');
            Console.WriteLine('2');
            Console.WriteLine('3');
            Console.WriteLine('4');
            Console.WriteLine('5');
            Console.WriteLine('6');
            Console.WriteLine('7');
            Console.WriteLine('8');
            Console.ReadKey();
        }
    }
}
