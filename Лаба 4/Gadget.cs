using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4
{
    public abstract class Gadget
    {
        public double Price { get; set; }

        public Gadget(double price)
        {
            Price = price;
        }

    }
}
