using SomerenDAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;


namespace SomerenService
{
    public class VatOrderService
    {
        private VatOrderDao vatOrderDB;

        public VatOrderService()
        {
            vatOrderDB = new VatOrderDao();
        }

        public List<VatOrder> GetAllVatOrders()
        {
            return vatOrderDB.GetAllVatOrders();
        } 
    }
}