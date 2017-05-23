using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo9方法中的out参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //求一个数组的操作
            int[] arr = { 1, 3, 4, 5, 33, 8 };
            int max, min, sum, avg;
            bool flag;
            OutFun(arr, out max, out min, out sum, out avg,out flag);
            Console.WriteLine("最大值是：{0}，最小值是：{1}，总和是：{2}，平均值是：{3},布尔值是：{4}", max, min, sum, avg,flag);
            Console.ReadKey();
        }
          
        public static void OutFun(int[] nums,out int max1,out int min1,out int sum1,out int avg1,out bool flag1)
        {
            max1 = nums[0];
            min1 = nums[1];
            sum1 = 0;
            flag1 = false;
            for(int i = 0; i < nums.Length; i++)
            {
                if (max1 < nums[i])
                {
                    max1 = nums[i];
                }
                if (min1 > nums[i])
                {
                    min1 = nums[i];
                }
                sum1 += nums[i];
            }
            avg1 = sum1 / nums.Length;
        }
       
    }
}

