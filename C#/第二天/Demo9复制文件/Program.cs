using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9复制文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //复制文件，其实就是先读后写
            string source = @"D:\huahai.mp4";
            string target = @"D:\huahai2.mp4";
            CopyFile(source,target);
            Console.WriteLine("复制ok");
            Console.ReadKey();
        }
        public static void CopyFile(string source,string target)
        {
            //创建一个读取的流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                //创建一个写入的流
                using(FileStream fsWrite=new FileStream(target,FileMode.OpenOrCreate,FileAccess.Write))
                {
                    byte[] buffer = new byte[1024*1024*5];

                    //文件比较大，可以通过循环读
                    while(true){
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
