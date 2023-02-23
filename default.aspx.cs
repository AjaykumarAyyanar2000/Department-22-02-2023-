using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Department
{
    public partial class _default : System.Web.UI.Page
    {
        //Creating an object of business logic layer so that we could access the functionalities in the logic layer
        Logic.Student StudentLogic = new Logic.Student();
        //Creating a Data Transfer object so that we can process the objects in the form present in the db
        Logic.StudentDTO student = new Logic.StudentDTO();
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (!IsPostBack)
            {
                //we fill the dropdown list at first

                FillDropDownList();
                BindGrid();
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            int RowsAffected;
            student.Name = txtName.Text;
            student.PhoneNo = txtPhone.Text;
            student.Email = txtEmail.Text;
            student.DeptName = txtDept.Text;
            student.Password = txtpwd.Text;
            student.IsActive = true;

            if (Convert.ToInt32(hfStudentID.Value) == 0)
            {
                student.Id = 0;

            }
            else
            {
                student.Id = Convert.ToInt32(hfStudentID.Value);

            }

            //Accessing the method in logic layer by using the object of logic layer
            RowsAffected = StudentLogic.SaveOrUpdateEmployee(student);





            //As we are using stored procedure
            if (RowsAffected == -1)
            {
                //Filling the new number saved into the dropdownlist
                FillDropDownList();
                Lbl.Text = "Employee Saved";
            }
            else
                Lbl.Text = "Something went Wrong";

        }

        private void PopulateData()
        {
            //select query to select all columns of the selected phone number in the dropdown
            //here see the selected index changed
            //enable autopostback


            DataTable dtAllData = StudentLogic.ReturnSpecificEmployee(ddlPhoneNumbers.SelectedItem.ToString());

            hfStudentID.Value = dtAllData.Rows[0].ItemArray[0].ToString();

            //Here i am populating the textboxes in web app from the columns of the selected row from the select query (number selected in the dropdown list
            txtName.Text = dtAllData.Rows[0].ItemArray[1].ToString();
            txtPhone.Text = dtAllData.Rows[0].ItemArray[3].ToString();
            txtEmail.Text = dtAllData.Rows[0].ItemArray[4].ToString();
            txtDept.Text = dtAllData.Rows[0].ItemArray[2].ToString();

            //see the dropdown selected index changed

        }

        private void FillDropDownList()
        {
            //This fn is to fill the dropdown list with the numbers in the db
            //here the query is wriiten


            DataTable dtPhoneNumbers = StudentLogic.ReturnAllEmployeePhones();


            //we are clearing the ddlphonenumbers because when we add a new employee and we call the dropdownlist fn again 
            //so it will repopulate the ddl once again so to avoid we clear all the items in the ddl everytime we call the dropdownlist fn
            ddlPhoneNumbers.Items.Clear();
            //ddl default option
            ddlPhoneNumbers.Items.Add("--Select--");
            //iterate through each row of the data table dt
            foreach (DataRow item in dtPhoneNumbers.Rows)
            {
                //populate or fill the dropdown list 
                ddlPhoneNumbers.Items.Add(item.ItemArray[0].ToString());
            }

            //This method must be called once before the loading of page
            //see pageload function
            //Also see the RowsAffected =1 in the button1_click event
        }


        private void BindGrid()
        {


            DataTable dtAllData = StudentLogic.ReturnAllEmployee();
            if (dtAllData.Rows.Count > 0)
            {
                grdStudent.DataSource = dtAllData;
                grdStudent.DataBind();
            }

        }

        protected void ddlPhoneNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Once we select a particular number in dropdown (we need to populate the other fields in application)
           
            PopulateData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {;
            Response.Redirect("login.aspx");
        }
    }
}