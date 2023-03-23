using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Order
    {
        public int Ordernr { get; set; }
        public string Student { get; set; }
        public string Drankje { get; set; }
        public decimal Prijs { get; set; }
        public DateTime datum { get; set; }

    }
}