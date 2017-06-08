using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Md5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "你好";
            str = GetMd5(str);
            Console.WriteLine(str);
            Console.ReadKey();
        }
        public static string GetMd5(string str)
        {
            //创建md5
            MD5 md5 = MD5.Create();

            byte[] buffer = Encoding.Default.GetBytes(str);
            byte[] md5buffer = md5.ComputeHash(buffer);
            //这样导致乱码
            //return Encoding.Default.GetString(md5Buffer);
            string strNew = "";
            for (int i = 0; i < md5buffer.Length; i++)
            {
                //x2 每次都返回2个，对齐作用
                strNew += md5buffer[i].ToString("X2");
            }
            return strNew;
        }
    }
}
