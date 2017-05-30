using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo6Hashtable键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("name", "Felix");
            ht.Add(2, "zhngsan");
            ht.Add(false, "cuode");
            ht.Remove(false);//删掉指定的键
            foreach (var item in ht.Keys)
            {
                Console.WriteLine(ht[item]);
            }
            if (ht.ContainsKey("name"))
            {
                Console.WriteLine("已经包含了做name");
            }
            ht.Clear();//清除全部
            Console.ReadKey();

        }
    }
}
