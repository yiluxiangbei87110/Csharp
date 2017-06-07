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
        //成员不能含有修饰符默认就是public 并且没有方法体
        void Fly();
        //string _name; error:接口不能含有字段
        String Name
        {
            //属性中不可以有方法体 自动属性
            set;
            get;
        }

    }
    public class Person : Flyable
    {   
        public void Fly()
        {
            Console.WriteLine("人类可以fly");
        }
        public String Name
        {
            set { Name = value; }
            get { return Name; }
        }
    }
    public class Bird : Flyable
    {
        public String Name
        {
            set { Name = value; }
            get { return Name; }
        }
        public void Fly()
        {
            Console.WriteLine("鸟类也可以fly");
        }
    }
}
