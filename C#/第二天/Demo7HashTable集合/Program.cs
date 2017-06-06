using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo7HashTable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1,"zhangsan");
            //ht.Add(1, "zhangsan"); 不能重复
            ht.Add(2, "lisi");
            ht.Add("name", "Felix");
            ht.Add(true, 20);
            ht.Remove("name");//删除指定的键
            bool flag = ht.Contains(1);
            bool flag2 = ht.ContainsKey(2);
            ht[true] = 30;//通过下标可以覆盖
            Console.WriteLine("键名含有字为1的{0}，为2的{1}",flag,flag2);//True ,True
            //问题？ Hashtabel是通过键名来进行访问的，所以下面只会打印出部分。
            //for(int i = 0; i < ht.Count; i++)
            //{
            //    Console.WriteLine(ht[i]);// zhagnsan lisi
            //}
            //此时，我们需要使用foreach来解决这个问题(Keys首字母要大写)
            foreach (var item in ht.Keys)
            {
                Console.WriteLine("键名为{0}的值是{1}",item,ht[item]);
            }
            ht.Clear();
            Console.ReadKey();
        }
    }
}
