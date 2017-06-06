using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6集合2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(true);
            list.Add("hello world");//可以重复包含
            list.Add("hello world");
            list.Add("Felix");
            list.Add(6666.68m);
            list.Add(123);
            list.AddRange(new int[] { 1,23,4,5,67,78});
            list.Insert(0,"first");//从下标插入后面的后移
            list.InsertRange(0, new string[] { "fdjf", "jdkfdk"});
            bool flag = list.Contains(true);//是否包含
            Console.WriteLine("集合是否包含true:"+flag);
            //list.Remove("Felix");//通过元素直接删除
            //list.RemoveAt(0);//通过下标删除
            //list.RemoveRange(0,2);//通过下标移除一定范围的元素(index,.count)
            //for(var i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}
            //Console.WriteLine("对集合进行sort操作");
            ////list.Sort();
            //list.Reverse();
            for (var i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
