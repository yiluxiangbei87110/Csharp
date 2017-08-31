using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo4继承
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Teacher T = new Teacher();
            s.Name = "Felix";
            s.Say();
            Console.ReadKey();
        }
    }
    public class Person
    {
        private string _name;
        public string Name
        {
            set { _name = value; }
            get { return _name; }
        }

        private int _gender;
        public int Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }
        public void Say()
        {
            Console.WriteLine("我是父类的方法，子类都可以访问我哦！");
        }
        public Person()
        {
            Console.WriteLine("我是父类默认的构造方法");
        }

    }
    //注意原则上应该每创建一个类就要有一个类库，此时我们不区分。
    public class Student : Person
    {
        private int _id;
        public int Id
        {
            set { _id = value; }
            get { return _id; }
        }
        public void Study()
        {
            Console.WriteLine("study");
        }
    }

    public class Teacher : Person
    {
        private int _salary;
        public int Salary
        {
            set { _salary = value; }
            get { return _salary; }
        }
        public void Teache()
        {
            Console.WriteLine("Teache");
        }
    }


}
