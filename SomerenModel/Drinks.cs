using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drinks
    { // moet altijd overeen komen met de database.
        public int Dranknr { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
        public int Voorraad { get; set; }
        public int Aantal_Verkocht { get; set; }

        public string DisplayMember { get { return $"{Dranknr}. {Naam} - Prijs: {Prijs} - Voorraad: {Voorraad}"; } }

    }
}