using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19_1
{
    internal class PCModel
    {
        public int code { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double frequency { get; set; }
        public int memory_volume { get; set; }
        public int hdd_volume { get; set; }
        public int graphics_volume { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public PCModel(int code, string name, string type, double frequency, int memory, int hdd, int graphics, double price, int quantity)
        {
            this.code = code;
            this.name = name;
            this.type = type;
            this.frequency = frequency;
            this.memory_volume = memory;
            this.hdd_volume = hdd;
            this.graphics_volume = graphics;
            this.price = price;
            this.quantity = quantity;
        }
    }
}
