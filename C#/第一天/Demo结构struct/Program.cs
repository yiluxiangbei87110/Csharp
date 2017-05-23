using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo结构struct
{
    public struct Person {
        public string name;
        public  int age;
        public Gender gender;
    }
    public enum Gender {
        male,
        female
    }
  
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Felix";
            p.age = 24;
            p.gender = Gender.male;
            Console.WriteLine(p.gender);
            Console.ReadKey();

        }
    }
}
