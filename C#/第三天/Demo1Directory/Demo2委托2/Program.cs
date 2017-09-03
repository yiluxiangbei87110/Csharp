using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2委托2
{   //委托声明注意是卸载命名空间下，而且形式和下面的函数一致。
    public delegate void DELSayHi(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个委托对象
            //DELSayHi del = new DELSayHi(ChiSayHello);
            //del("zhangsan");
            //可以简单点，直接调用
            Test("zhagnsan", ChiSayHello);

            //更简单点
            DELSayHi del = delegate (string name)
              {
                  Console.Write("你好，" + name);
              };

            //最简单
            //DELSayHi del =(string name)=>{
            //    Console.Write("你好，" + name);
            //};
            Console.ReadKey();

        }

        public static void Test(string name,DELSayHi del)
        {
            //调用
            del(name);

        }
        public static void ChiSayHello(string name)
        {
            Console.WriteLine("吃了吗,"+name);
        }
        public static void EngSayHello(string name) 
        {
            Console.WriteLine("HI,"+name);
        }
    }
}
