using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo10方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //out参数
            int[] arr = { 1, 3, 4, 5, 33, 8 };
            int[] reRes=ArrFunc(arr);
            Console.WriteLine("最大值是：{0}，最小值是：{1}，总和是：{2}，平均值是：{3}", reRes[0], reRes[1], reRes[2], reRes[3]);
            Console.ReadKey();
        }
       
        public static int[] ArrFunc(int[] nums)
        {
            int[] res = new int[4];
            res[0] = nums[0];//最大值
            res[1] = nums[0];//最小值
            res[2] = 0;//总和
            res[3] = 0;//平均值
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > res[0])
                {
                    res[0] = nums[i];
                }
                if (nums[i] < res[1])
                {
                    res[1] = nums[i];
                }
                res[2] += nums[i];
            }
            res[3] = res[2] / nums.Length;
            return res;
        }

       
    }

}
