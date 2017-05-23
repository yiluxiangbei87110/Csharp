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
            OutFun(arr, out max, out min, out sum, out avg);
            Console.WriteLine("最大值是：{0}，最小值是：{1}，总和是：{2}，平均值是：{3}", max, min, sum, avg);
            Console.ReadKey();
        }
          
        public static void OutFun(int[] nums,out int max,out int min,out int sum,out int avg)
        {
            max = nums[0];
            min = nums[1];
            sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (max < nums[i])
                {
                    max = nums[i];
                }
                if (min > nums[i])
                {
                    min = nums[i];
                }
                sum += nums[i];
            }
            avg = sum / nums.Length;
        }
       
    }
}


