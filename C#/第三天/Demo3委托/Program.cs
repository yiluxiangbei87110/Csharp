using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3委托
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "fjkASJKdd", "hfdjfhaoeui", "FFF" };
            AddSYH(names);
            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadKey();
           
        }
        //操作的是引用类型，不需要返回值。
        //三个方法类似，我们可以使用委托。
        public static void ToUpperCase(string[] name)
        {
            for(int i = 0; i < name.Length; i++)
            {
                name[i] = name[i].ToUpper();
            }
        }
        public static void ToLowerCase(string[] name)
        {
            for(var i = 0; i < name.Length; i++)
            {
                name[i] = name[i].ToLower();
            }
        }
        public static void AddSYH(string[] name)
        {
            for(int i = 0; i < name.Length; i++)
            {
                name[i] = "\"" + name[i] + "\"";
            }
        }
    }
}
   
