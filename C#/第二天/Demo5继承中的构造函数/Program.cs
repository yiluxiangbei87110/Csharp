using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5继承中的构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("xueshengFelix",2,2013);
            Teacher t = new Teacher("laoshi", 2, 6000);
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
        public Person(string name, int gender)
        {
            this.Name = name;
            this.Gender = gender;
        }

    }
    //注意原则上应该每创建一个类就要有一个类库，此时我们不区分。
    public class Student : Person
    {
        public new void Say()
        {
            Console.WriteLine("我是子类的say方法，我覆盖掉了父类的say方法");
        }
        public Student(string name,int gender,int id):base(name,gender)
        {
            this.Id = id;
        }
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
        public Teacher(string name,int gender,int salary):base(name,gender)
        {
            this.Salary = salary;
        }
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


