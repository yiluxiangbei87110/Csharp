using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1通过构造函数去调用另一个构造函数this
{
    class Person
    {
        private string _name;
        private int _age;
        private char _gender;
        private string _hobby;
        private double _salary;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                _age = value;
            }
        }

        public char Gender
        {
            get
            {
                return _gender;
            }

            set
            {
                _gender = value;
            }
        }

        public string Hobby
        {
            get
            {
                return _hobby;
            }

            set
            {
                _hobby = value;
            }
        }

        public double Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                _salary = value;
            }
        }
       //this的作用，一是代表当前对象，二是继承构造函数。

        public Person(string name,int age,char gender,string hobby)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Hobby = hobby;
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的爱好是{3}", this.Name, this.Age, this.Gender, this.Hobby);
        }
        //使用上面的没有就给默认值
        public Person(string name,int age,char gender,double salary) : this(name, age, gender,"dance")
        {
            this.Salary = salary;
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生，我的工资是{3}元",this.Name,this.Age,this.Gender,this.Salary);
        }

    }

}
