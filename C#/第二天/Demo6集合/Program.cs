using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Demo6集合
{
    class Program
    {
        static void Main(string[] args)
        {   //创建一个集合，并且放入一些数字，求出之和
            //ArrayList ls = new ArrayList();
            //ls.AddRange(new int[] { 1, 2, 3, 4, 56, 7 });
            //int sum = 0;
            //for(int i = 0; i < ls.Count; i++)
            //{
            //    sum += (int)ls[i];
            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();
            //随机打印出不重复的0-9数字
            ArrayList list = new ArrayList();
            Random rd = new Random();
            //为什么不能用10代替list.count(list.count表示是真实的数量，刚开始是0，不满足）
            for(int i = 0; i < 10; i++)
            {
                int rNumber = rd.Next(0, 10);//0-9
                if (!list.Contains(rNumber))
                {
                    list.Add(rNumber);
                }else
                {
                    //如果有这个数字，不能浪费这次循环，我们再加一次循环
                    i--;
                }
            }
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.ReadKey();
        }
    }
}
