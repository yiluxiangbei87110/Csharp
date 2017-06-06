using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo51里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Student();
            //强制装换方法as 和 is
            //as 方法 不会报异常，如果转换失败会返回null
            Student s = p1 as Student;
            s.Say();
            //if(p1 is Student)
            //{
            //    Student s = (Student)p1;
            //    s.Say();
            //}else
            //{
            //    Console.WriteLine("p1不是student");
            //}
            Console.ReadKey();
        }
    }
    public class Person
    {
       
        public  void Say()
        {
            Console.WriteLine("我是父类的方法！");
        }
    }
    public class Student:Person
    {
        public new void Say()
        {
            Console.WriteLine("我是子类student的方法！");
        }
    }
}
