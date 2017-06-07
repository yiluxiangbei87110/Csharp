using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo8文件的操作3
{
    class Program
    {
        static void Main(string[] args)
        {
            //读 ReadAllText
            string s = File.ReadAllText(@"C:\Users\LQC\Desktop\test.txt", Encoding.UTF8);
            Console.WriteLine(s);

            //写 WriteALLText
            string contents = "在苍茫的大海上狂风卷积着乌云，在乌，在乌云和大海之间。在苍茫的大海上狂风卷积着乌云，在乌云和大海之间";
            byte[] buffer = Encoding.GetEncoding("gbk").GetBytes(contents);
            File.WriteAllBytes(@"C:\Users\LQC\Desktop\test.txt",buffer);
            File.AppendAllText(@"C:\Users\LQC\Desktop\test.txt","我是追加的内容，不会覆盖哦！");
        }
    }
}
