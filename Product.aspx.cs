using Department.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Department
{
    public partial class Product : System.Web.UI.Page
    {
        ProductLogic blProduct = new ProductLogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnProduct_Click(object sender, EventArgs e)
        {
            ProductDTO myNewProduct = new ProductDTO();

            myNewProduct.PName = txtPName.Text;
            myNewProduct.PCategory = ddlCat.SelectedItem.ToString();
            myNewProduct.SalePrice = Convert.ToDouble(txtSalePrice.Text);
            myNewProduct.PurchasePrice = Convert.ToDouble(txtPurchasePrice.Text);
            myNewProduct.Discount = Convert.ToInt32(txtDiscount.Text);

            int Status = blProduct.SaveProduct(myNewProduct);

            if (Status == 1)
            {
                lblMessage.Text = "Product Saved...";
            }
            else
                lblMessage.Text = "Error Happend";


        }
    }
}