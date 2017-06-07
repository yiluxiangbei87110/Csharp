using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8Path静态类
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"C:\Users\LQC\Desktop\mygithub\Demo\extjs\json\这个杀手不太冷.avi";
            //获得文件名
            Console.WriteLine(Path.GetFileName(str));
            //获得没有扩展名的文件名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //获得文件的扩展名
            Console.WriteLine(Path.GetExtension(str));
            //获得文件夹名
            Console.WriteLine(Path.GetDirectoryName(str));
            //获得文件所在的全路径
            Console.WriteLine(Path.GetFullPath(str));
            //连接两个字符串作为文件名
            Console.WriteLine(Path.Combine(@"D\new","aa.txt"));
            Console.ReadKey();
        }
    }
}
