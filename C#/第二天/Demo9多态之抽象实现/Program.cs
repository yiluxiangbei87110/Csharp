using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9多态之抽象实现
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal d = new Dog();
            Dog d=new Dog();
            Animal c = new Cat();
            Animal s = new Sheep();
            Animal[] a = { d, s, c };
            foreach(var i in a)
            {
                i.Say();
            }
            Console.ReadKey();
        }
    }
    public abstract  class Animal
    {   //抽象方法不允许有方法体
        public abstract void Say();
    }
    public class Dog : Animal
    {
        public  override void Say()
        {
            Console.WriteLine("小狗汪汪叫");
        }
    }
    public class Cat : Animal
    {
        public override void Say()
        {
            Console.WriteLine("猫咪喵喵叫");
        }
    }
    public class Sheep : Animal
    {
        public override void Say()
        {
            Console.WriteLine("羊羔咩咩叫");
        }
    }
}
