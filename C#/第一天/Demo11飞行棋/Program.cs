using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo11飞行棋
{
    class Program
    {
        static void Main(string[] args)
        {
            GameShow();
        }
        //游戏头部
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("****Felix的飞行棋*****");
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("****************");
            Console.ReadKey();
        }
    }
}
