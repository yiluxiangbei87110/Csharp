using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo95接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Flyable f = new Bird();//new Person();
            f.Fly();
            Console.ReadKey();
        }
    }
    
    public interface Flyable
    {
        //成员不能含有修饰符 并且没有方法体
        void Fly();

    }
    public class Person : Flyable
    {
        public void Fly()
        {
            Console.WriteLine("人类可以fly");
        }
    }
    public class Bird : Flyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟类也可以fly");
        }
    }
}
