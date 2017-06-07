using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9字节流StreamReader和StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader 读
            //using(StreamReader sr=new StreamReader(@"F:\文件流操作.txt", Encoding.Default))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        Console.WriteLine(sr.ReadLine());
            //    }
            //}
            //StreamWriter写
            using(StreamWriter sw=new StreamWriter(@"F:\文件流操作.txt"))
            {
                sw.Write("qqqqqqqqqq我要把你全部擦除wwwwwwwwwww",false);
            }
            Console.ReadKey();
        }
    }
}
