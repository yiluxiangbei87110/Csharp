using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4占位符
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 24;
            decimal salary = 6000m;
            string gender = "male";
            Console.WriteLine("姓名是{0}，年龄是{1}，性别是{2}", salary, age, gender);
            Console.ReadKey();
            int n1 = 10;
            int n2 = 20;
            int n3 = 30;
            Console.WriteLine("{1},{0},{2}", n1, n2, n3);
            Console.ReadKey();
            Console.WriteLine("你喜欢吃什么水果？");
            string ans = Console.ReadLine();
            Console.WriteLine("好巧，张三也喜欢吃{0}",ans);
            Console.ReadKey();

        }
    }
}
