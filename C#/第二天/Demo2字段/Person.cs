using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2字段
{
     class Person
    {
        private string _name;
        public string Name {
            set { _name = value; }
            get { return _name; }
        }
        private int _age;
        public int Age
        {
            set
            {
                if(value>100 || value < 0)
                {
                    value = 10;
                }
                _age = value;
            }
            get { return _age; }
        }
        public void Say()
        {
            Console.Write("我是{0}，我今年{1}岁了",this.Name,this.Age);
        }
    }
}
