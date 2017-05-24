using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test基本语法
{
    class Program
    {
        double length;
        double width;
        public void Init()
        {
            length = 20.2;
            width = 23.4;
        }

        public double GetArea()
        {
            return width * length;
        }
        public void Display()
        {
            Console.WriteLine("length是：{0}", length);
            Console.WriteLine("width是:{0}", width);
            Console.WriteLine("矩形的面积是{0}", GetArea());
        }
    }

    class Execute {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Init();
            p.Display();
            Console.ReadKey();

        }
    }
}