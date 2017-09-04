using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory 创建一个a文件夹
            Directory.CreateDirectory(@"C:\a");
            Console.WriteLine("创建成功");
            Console.ReadKey();

            //删除的文件夹下不能有文件
            Directory.Delete(@"C:\a");
            //如果全部删掉需要一个布尔值true
            //Directory.Delete(@"C:\a",true);
            Console.WriteLine("删除了");
            Console.ReadKey();

            //剪切操作，包括文件夹下的所有文件都被剪切到了桌面位置
            Directory.Move(@"C:\b", @"C:\Users\Administrator\Desktop\new");
            Console.WriteLine("剪切成功");
            Console.ReadKey();
        }
    }
}
