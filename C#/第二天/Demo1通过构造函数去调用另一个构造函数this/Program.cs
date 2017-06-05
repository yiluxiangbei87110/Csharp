using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1通过构造函数去调用另一个构造函数this
{
    class Program
    {
        static void Main(string[] args)
        {
            //也会调用上面的方法
            Person p = new Person("zhansan", 12, 'M', 6666.66);
            Console.ReadKey();
        }
    }
}
