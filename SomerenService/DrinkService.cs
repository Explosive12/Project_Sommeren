using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinkdb;

        public DrinkService()
        {
            drinkdb = new DrinkDao();
        }

        public List<Drinks> GetDrinks()
        {
            List<Drinks> drinks = drinkdb.GetAllDrinkSupplies();
            return drinks;
        }

        public void Update(int dranknr, string naam, int voorraad)
        {
            drinkdb.Update(dranknr, naam, voorraad);
        }
    }
}