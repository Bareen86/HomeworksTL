using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopConsole.Classes
{
    public abstract class GoodInfo
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string GoodType { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }

    }
}
