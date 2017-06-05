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
        public double Count
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
        public ProductFather(string id, double count,double price)
        {
            this.ID = id;
            this.Price = price;
            this.Count = count;
        }
    }
}
