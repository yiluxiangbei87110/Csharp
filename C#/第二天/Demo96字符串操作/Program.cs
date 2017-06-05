using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo96字符串操作
{
    class Program
    {
        static void Main(string[] args)
        {

            //string str = null;
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(var i = 0; i < 100000; i++)
            {
                //str += i;
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
