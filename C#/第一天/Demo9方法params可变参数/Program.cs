using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9方法params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //params可变参数，减少了变量。但是注意只能有一个可变参数，并且只能放在最后。
            Test("Felix",89,90,97);
            Console.ReadKey();
        }

        public static void Test(string name,params int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine("{0}的成绩是{1}", name, sum);
        }
    }
}
