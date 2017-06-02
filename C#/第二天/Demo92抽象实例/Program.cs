using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo92抽象实例
{
    class Program
    {
        static void Main(string[] args)
        {
            //求圆形和矩形的周长和面积
            Shape s = new Square(6);
            double area=s.GetArea();
            double premireter = s.GetPerimeter();
            Console.WriteLine("图形的面积是{0},周长是{1}", area,premireter);
            Console.ReadKey();
        }
    }

    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
    }
    public class Circle:Shape
    {
        private double _r;
        
        public double R
        {
            set { _r = value; }
            get { return _r; }
        }
        public Circle(double _r)
        {
            this.R = _r;
        }
        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }
        public override double GetPerimeter()
        {
            return Math.PI* 2 * _r;
        }
    }

    public class Square : Shape
    {
        private double _a;
        public double A
        {
            set { _a = value; }
            get { return _a; }
        }
        public Square(double _a)
        {
            this.A = _a;
        }
        public override double GetArea()
        {
            return _a * _a;
        }
        public override double GetPerimeter()
        {
            return 4 * _a;
        }

    }
}
