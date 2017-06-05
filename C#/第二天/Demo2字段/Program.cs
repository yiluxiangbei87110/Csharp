using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2字段
{
    class Program
    {
        static void Main(string[] args)
        {
            // 创建Person类的对象
            Person P = new Person();
            P.Name = "Felix";
            P.Age = 300;
            P.Say();
            Console.ReadKey();
        }
    }
}
