using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo6集合1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ls = new ArrayList();
            ls.Add("zhangsan");
            ls.Add(true);
            ls.Add(1);
            ls.Add(6666.66m);
            ls.AddRange(new int[] { 1, 2, 3, 45, 6 });
            ls.Add(345);
            Person p = new Person();
            ls.Add(p);
            for(int i = 0; i < ls.Count; i++)
            {
                if(ls[i] is Person)
                {
                    ((Person)ls[i]).Say();
                }else if (ls[i] is int[])
                {
                    for (int j=0;j< ((int[])ls[i]).Length; j++)
                    {
                        Console.WriteLine((int[])ls[i]);
                    }
                }else
                {
                    Console.WriteLine(ls[i]);
                }
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        public void Say()
        {
            Console.WriteLine("hello World");
        }
    }
}
