using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();
            ls.Add(1);
            ls.Add(2);
            ls.AddRange(new int[] {1,23,4,5,6,7,8});
            //泛型可以转化为数组
            int[] intArr=ls.ToArray();
            //List<string> str = new List<string>();
            //string [] strArr=str.ToArray();
            //数组转集合
            char[] ch = new char[] { '1', '3', '4', 'w' };
            List<char> clist=ch.ToList();
            //for(int i = 0; i < ls.Count; i++)
            //{
            //    Console.WriteLine(ls[i]);
            //}
            //通过数组的访问方式也可以
            foreach (var i in ls)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
