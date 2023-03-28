using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class VatOrder
    {
        public bool IsAlcohol { get; set; } // true = has alcohol | False = no alcohol
        public decimal Price { get; set; } // e.g. $5.30
        public DateTime Date { get; set; } // 2065 (year we were all born in!)

    }
}
