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

        public Person(string name,int age,char gender,string hobby)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Hobby = hobby;
        }

        public Person(string name,int age,char gender) : this(name, age, gender)
        {

        }
    }

}
