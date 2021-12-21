using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo2.Models
{
    public class Item
    {
        public static List<Item> Items = new List<Item>();

        public int id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id {id} Name {Name} Price {Price}";
        }
    }
}
