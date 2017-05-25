using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二天
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p._name = "Felix";
            p._age = 23;
            p._gender = 'M';
            p.Say();
            Console.ReadKey();

        }
    }
}
