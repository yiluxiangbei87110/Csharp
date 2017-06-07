using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9文件流FileStream复制文件
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"D:\Phonegap-PhysicalButton-test-master.zip";
            string target = @"D:\Phonegap-PhysicalButton-test-masterCopy.zip";
            CopyFile(source, target);
            Console.WriteLine("读取成功了！");
            Console.ReadKey();
        }
        public static void CopyFile(string s, string t)
        {
            //创建一个读取的流
            using (FileStream fsRead = new FileStream(s, FileMode.Open, FileAccess.Read))
            {
                //创建一个写入的流
                using (FileStream fsWrite = new FileStream(t, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];

                    //文件比较大，可以通过循环读
                    while (true)
                    {
                        //返回本次实际读到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //当返回的是0的时候，我们知道已经读取完了
                        if (r == 0)
                        {
                            break;
                        }
                        //注意后面的r（最后一次可能不是整数）
                        fsWrite.Write(buffer, 0, r);
                    }

                }
            }

        }
    }
}
