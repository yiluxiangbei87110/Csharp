using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superMarket
{
    class ProductFather
    {
        public double Price
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public ProductFather(string id, double price,string  name)
        {
            this.ID = id;
            this.Price = price;
            this.Name = name;
            Console.WriteLine("我是父类的方法");
        }
    }
}
//注意子类会调用父类默认的无参构造方法，如果父类没有的话子类会报错，此时可以这样给父类添加一个无参构造函数，或者子类：base父类的构造函数。