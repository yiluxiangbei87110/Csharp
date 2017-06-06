using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo96字符串操作2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Felix";
            string str2 = "felix";
            string str3 = "r ueqq ew+ -fdsk=,d Felix444 ";
            //不区分大小写 sringComparison
            if(str1.Equals(str2, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("使用字符串的stringComparison的方法忽略忽略大小写");
            }
            //分割字符串split方法????（数组访问，不能直接访问名字）
            char [] needSplit = { ',', '+', '-', '=',' ' };
            string [] str4=str3.Split(needSplit);
            Console.WriteLine("分割后的字符串是:");
            foreach (var i in str4)
            {
                Console.Write(i);
            }
            Console.WriteLine("\n");
            if (str3.Contains("Felix"))
            {
                str3=str3.Replace("Felix","zhagnsan");
            }
            Console.WriteLine(str3);
            string str5 = "在苍茫的大海上";

            int index=str5.IndexOf("苍茫", 0);
            Console.WriteLine("下标是:{0}",index);//下标是:1
            string str6 = "";
            if (String.IsNullOrEmpty(str6))
            {
                Console.WriteLine("String.IsNullOrEmpty检查字符串是空还是null");
            }
            string[] str7 = { "zhangsan", "lisi", "wangwu" };
            string str7Join=string.Join("|",str7);
            Console.WriteLine("string方法后的字符串是{0}",str7Join);//string方法后的字符串是zhangsan|lisi|wangwu
            Console.ReadKey();
        }
    }
}
