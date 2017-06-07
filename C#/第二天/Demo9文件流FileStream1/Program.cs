using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9文件流FileStream1
{
    class Program
    {
        static void Main(string[] args)
        {
            //读出
            //FileStream fsRead = new FileStream(@"C:\Users\LQC\Desktop\test.txt", FileMode.Open, FileAccess.Read);
            //byte[] buffer = new byte[1024 * 1024 * 2];
            ////返回读到的有效字节数
            //int r = fsRead.Read(buffer, 0, buffer.Length);
            ////将字节数组中的每一个元素按照指定的编码解码成字符串
            //string s = Encoding.GetEncoding("gbk").GetString(buffer, 0, r);
            ////关闭流并且释放资源
            //fsRead.Close();
            //fsRead.Dispose();
            //Console.WriteLine(s);
            //Console.ReadKey();
            using (FileStream fsWrite =new FileStream(@"C:\Users\LQC\Desktop\test.txt",FileMode.OpenOrCreate,FileAccess.Write))
            {
                string str = "我要把你覆盖掉了，哈哈哈！";
                byte[] buffer = Encoding.GetEncoding("gbk").GetBytes(str);
                fsWrite.Write(buffer,0,buffer.Length);
            }
            Console.WriteLine("写入成功！");
            Console.ReadKey();
        }
    }
}
