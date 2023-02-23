using Department.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Department.Logic
{
    public class ProductLogic
    {
        DataAccess dalObject = new DataAccess();

        public int SaveProduct(ProductDTO product)
        {
            string Query = @"INSERT INTO [dbo].[Ajay_Product]
                               ([PName]
                               ,[PCategory]
                               ,[SalePrice]
                               ,[PurchasePrice]
                               ,[Discount]
                               ,[Active])
                         VALUES
                               (@PName
                               ,@PCategory
                               ,@SalePrice
                               ,@PurchasePrice
                               ,@Discount
                               ,@Active)";



            KeyValuePairList kvplObject = new KeyValuePairList();

            kvplObject.Add(new KeyValuePair("@PName", product.PName));
            kvplObject.Add(new KeyValuePair("@PCategory", product.PCategory));
            kvplObject.Add(new KeyValuePair("@SalePrice", product.SalePrice));
            kvplObject.Add(new KeyValuePair("@PurchasePrice", product.PurchasePrice));
            kvplObject.Add(new KeyValuePair("@Discount", product.Discount));
            kvplObject.Add(new KeyValuePair("@Active", true));

            int RowsAffected = dalObject.InsertUpdateOrDelete(Query, kvplObject);

            return RowsAffected;



        }
    }

    public class ProductDTO
    {
        public int pid { get; set; }
        public string PName { get; set; }
        public string PCategory { get; set; }
        public double SalePrice { get; set; }
        public double PurchasePrice { get; set; }
        public int Discount { get; set; }
        public bool Active { get; set; }

    }
}
