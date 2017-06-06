using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo96字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            //字符串的操作(可以将字符串当做char类型的只读数组)
            string str = "abRRHkdjsdkjkfj";
            Console.WriteLine(str[0]);//a
            //str[0] = 'f'; error:它是只读的，不可写
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            //将其转换未char类型的数组,就可以进行修改了
            char[] ch = str.ToCharArray();
            ch[0] = 'F';
            Console.WriteLine(ch[0]);
            //将char类型的数组转换成string类型
            str = new string(ch);
            //str[0] = 'g'; error:它是只读的。
            //ToUpper toLower 转化为大小写
            str = str.ToLower();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
