using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //以字节为单位的存储对象或类型的存储尺寸
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(sizeof(int));//4
            Console.WriteLine(sizeof(double));//8
            Console.WriteLine(sizeof(char));//2
            Console.WriteLine(sizeof(byte));//1
            Console.WriteLine(sizeof(decimal));//16
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string str = "hello world";
            String str2 = "hello world2";
            String str3 = @"123333333";
            Console.WriteLine("str是{0}，str2是：{1},str3是：{2}",str,str2,str3);

            //@（逐字字符串）的作用，字符串是什么就怎么显示，如将转义字符\直接当做字符串对待，换行缩进空格都计算在空格之中。
            string path = "C:\\Users\\LQC\\Desktop\\yiluxiangbei\\Demo";//C:\Users\LQC\Desktop\yiluxiangbei\Demo
            string path2 = @"C:\Users\LQC\Desktop\yiluxiangbei\Demo";//C:\Users\LQC\Desktop\yiluxiangbei\Demo
            string str4 = @"<script type=""text/javascript"">
            <!--
            -->
            </script>";
            Console.WriteLine("不使用@符号，如果想要表达路径，必须双斜杠{0},但是也可以直接使用@符号来操作{1}",path,path2);
            Console.WriteLine(str4);
            Console.ReadLine();
        }
    }
}
