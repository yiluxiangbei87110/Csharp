using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7Dictionary集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("salary", 12345);
            dic.Add("ID", 20130453);
            //通过下标来访问,没有会自动添加，有的话会覆盖掉
            dic["salary"] = 123;
            dic["group"] = 888;
            //foreach (var item in dic.Keys)
            //{
            //    Console.WriteLine("dictionary的键名是{0}，键值是{1}",item,dic[item]);
            //}
            //多出 一种键值对遍历的方法
            foreach(KeyValuePair<string,int> kv in dic)
            {
                Console.WriteLine("dictionary的键名是{0}，键值是{1}",kv.Key,kv.Value );
            }
            Console.ReadKey();
        }
    }
}
