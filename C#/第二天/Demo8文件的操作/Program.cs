using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8文件的操作
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文件，如果本身已经有啦，则会覆盖掉。（包括内容也变成了空白）。
            //File.Create(@"C:\Users\LQC\Desktop\test1.txt");
            //Console.WriteLine("创建成功！");

            //删除一个文件
            //File.Delete(@"C:\Users\LQC\Desktop\test1.txt");
            //Console.WriteLine("删除ok");
            //Console.ReadKey();

            //复制一个文件（源文件，目标文件），包括内容也一起复制过来了
            //File.Copy(@"C:\Users\LQC\Desktop\test.txt", @"C:\Users\LQC\Desktop\Copy.txt");
            //Console.WriteLine("ok");

            //读--以readAllByte的方式来读
            //byte [] buffer=File.ReadAllBytes(@"C:\Users\LQC\Desktop\test.txt");
            //将字符串数组中的每一个元素按照按照指定的编码解码为字符串
            //string s = Encoding.GetEncoding("gbk").GetString(buffer);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //写 ---WriteAllBytes if本身有内容，将会全部被替换。
            string str = "举头望明月，低头思故乡。";
            //byte[] buffer=Encoding.GetEncoding("GBK").GetBytes(str);
            byte[] buffer = Encoding.Default.GetBytes(str);
            File.WriteAllBytes(@"C:\Users\LQC\Desktop\test.txt", buffer);
            Console.ReadKey();

        }
    }
}
