using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3静态和非静态
{
    class Person
    {
        private int age;
        private static string name;
        public void M1()
        {
            Console.WriteLine("我是非静态方法！");

        }

        public static void M2()
        {
            Console.WriteLine("我是静态方法！");
          
        }
    }

}
