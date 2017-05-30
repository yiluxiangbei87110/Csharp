using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3静态和非静态
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.M1();
            //p1.M2();不能这样调用
            Person.M2();
            Console.ReadKey();
        }
    }
}
