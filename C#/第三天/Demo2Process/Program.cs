using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2Process
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] pg = Process.GetProcesses();
            foreach (var item in pg)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            //通过进程打开一些程序(下面打开计算器)
            Process.Start("calc");
            Process.Start("mspaint");
            Process.Start("notepad");
            Process.Start("iexplore", "http://www.baidu.com");

            //process打开一个文件
            ProcessStartInfo psi = new ProcessStartInfo(@"C:\Users\Administrator\Desktop\新建文本文档.txt");
            Process ps = new Process();
            ps.StartInfo = psi;
            ps.Start();
        }
    }
}
