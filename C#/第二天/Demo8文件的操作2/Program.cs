using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8文件的操作2
{
    class Program
    {
        static void Main(string[] args)
        {
            //读 ReadAllLines 以行的形式读取
            //string [] contents=File.ReadAllLines(@"C:\Users\LQC\Desktop\test.txt", Encoding.Default);
            //foreach(var item in contents)
            //{
            //    Console.WriteLine(item);
            //}
            //写 WriteAllLines-----直接覆盖
            File.WriteAllLines(@"C:\Users\LQC\Desktop\test.txt",new string[] {"zahgnsnan", "的积分记得给"});
            Console.ReadKey();
        }
    }
}
