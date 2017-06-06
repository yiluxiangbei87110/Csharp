using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo52里氏转换实例
{
    class Program
    {
        static void Main(string[] args)
        {
            Person2 [] pers = { new Teacher(), new Student(), new Leader() };
            for (int i= 0;i< pers.Length; i++)
            {
                if(pers[i] is Student)
                {
                    ((Student)pers[i]).SSay();
                }
                if (pers[i] is Teacher)
                {
                    ((Teacher)pers[i]).TSay();
                }
                if (pers[i] is Leader)
                {
                    ((Leader)pers[i]).LSay();
                }
            }
            Console.ReadKey();
        }
    }
    public class Person2
    {
        public void SayHello()
        {
            Console.WriteLine("父类的sayHello方法");
        }
    }
    public class Teacher : Person2
    {
        public void TSay()
        {
            Console.WriteLine("Teacher Sayhello方法");
        }
    }
    public class Student : Person2
    {
        public void SSay()
        {
            Console.WriteLine("student Sayhello方法");
        }
    }
    public class Leader : Person2
    {
        public void LSay()
        {
            Console.WriteLine("Leader Sayhello方法");
        }
    }
}
