using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo97多态virtual方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Magpie m = new Magpie();
            Eagle e = new Eagle();
            Penguin p = new Penguin();
            Bird[] bird = { m, e, p };
            foreach(var item in bird)
            {
                item.Say();
            }
            Console.ReadKey();
        }
    }
    public class  Bird
    {
        public virtual void Say()
        {
            Console.WriteLine("我是鸟类，我爱吃虫子！");
        }
    }
    public class Magpie:Bird
    {
        public override void Say()
        {
            Console.WriteLine("我是喜鹊，我也爱吃虫子！");
        }
    }
    public class Eagle : Bird
    {
    public override void Say()
        {
            Console.WriteLine("我是老鹰，我也爱吃虫子！");
        }
    }
    public class Penguin : Bird
    {
    public override void Say()
        {
            Console.WriteLine("我是企鹅，我也爱吃虫子！");
        }
    }
}
