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
                //由于接收的是字符串，所以需转换，下面是两种方式。
                //scoreRe = Convert.ToDouble(Console.ReadLine());
                scoreRe = double.Parse(Console.ReadLine());
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
                Console.WriteLine("fail!");
            }
            Console.ReadKey();
        }
    }
}
