using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo91抽象
{
    class Program
    {
        static void Main(string[] args)
        {
            //狗叫 猫也叫  无法实例化抽象或借口类
            //Animal a = new Animal();
            //虽然赋给了父类，但是其子类重写了父类的抽象方法，所以依然是子类的方法
            Animal a = new Dog();
            a.Bark();
        }
    }
    public abstract  class  Animal
    {
        //抽象方法不允许有方法体
        public abstract void Bark();
    }

    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("狗狗汪汪叫");
        }
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("猫猫喵喵叫");
        }
    }


}
