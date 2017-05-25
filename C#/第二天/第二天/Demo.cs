using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第二天
{
    public class Person
    {
       public string _name;
       public  int _age;
       public char _gender;
       public void Say()
        {
            Console.WriteLine("我的名字是{0}，我的年龄是{1}，我的性别是{2}",this._name,this._age,this._gender);
        }
    }
}
