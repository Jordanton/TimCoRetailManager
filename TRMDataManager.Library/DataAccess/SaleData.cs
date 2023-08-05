using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public class SaleData
    {
        //public List<ProductModel> GetProducts()
        //{
        //    SqlDataAccess sql = new SqlDataAccess();

        //    var output = sql.LoadData<ProductModel, dynamic>("dbo.spProduct_GetAll", new { }, "TRMData");

        //    return output;
        //}

        public void SaveSale(SaleModel sale)
        {
            // TODO: Make this SOLID/DRY/Better

            // Start filling in the sale detail models we will save to the database

            // Fill in the available information

            // Create the sale model

            // Save the sale model

            // Get the ID from the sale model

            // Finish filling in the sale detail models

            // Save the sale detail models

            SqlDataAccess sql = new SqlDataAccess();
        }
    }
}
