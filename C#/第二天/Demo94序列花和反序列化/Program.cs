using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Demo94序列花和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            //person p = new person();
            //p.age = 12;
            //p.name = "felix";
            //using (filestream fswrite = new filestream(@"c:\users\administrator\desktop\111.txt",filemode.openorcreate,fileaccess.write))
            //{
            //    binaryformatter bf = new binaryformatter();
            //    bf.serialize(fswrite, p);
            //    console.writeline("ok");

            //}
            Person p;
            using(FileStream fsRead=new FileStream(@"c:\users\administrator\desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                p=(Person)bf.Deserialize(fsRead);//强转为person类型的
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
                Console.ReadKey();
            }
        }
    }
    [Serializable]//指示一个类被序列化，此类不能被继承
    public class Person
    {
        private int _age;
        private string _name;

        public int Age
        {
            get{return _age;}
            set{_age = value;}
        }
        public string Name
        {
            get{ return _name;}
            set{ _name = value;}
        }
    }
}
