using Department.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Department
{
    public partial class login : System.Web.UI.Page
    {
        Logic.Student StudentLogic = new Logic.Student();
        //Creating a Data Transfer object so that we can process the objects in the form present in the db
        Logic.StudentDTO student = new Logic.StudentDTO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
            

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Phone = txtUser.Text;
            string password = txtPass.Text;
            bool status = StudentLogic.ValidateEmployee(Phone, password);

            if(status == true)
            {
                Label1.Text = "Login Successful";
            }
            else
            {
                Label1.Text = "Credentials are not correct";
            }
        }
    }
}