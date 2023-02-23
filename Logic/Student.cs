using Department.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Department.Logic
{
    public class Student
    {
        //Creating the object of dataaccess object
        DataAccess dalObject = new DataAccess();
        StudentDTO student = new StudentDTO();

        public int SaveOrUpdateEmployee(StudentDTO student)
        {
            /*string InsertQuery = string.Empty;

            if (student.Id == 0)
            {

                InsertQuery = @"INSERT INTO [dbo].[Ajay_StudentDept]
           (
            [Name]
           ,[DeptName]
           ,[Email]
           ,[PhoneNo]
           ,[Password]
           ,[IsActive])
     VALUES
           (@Name
           ,@DeptName
           ,@Email
           ,@PhoneNo
           ,@Password
           ,@IsActive)";
            }

            else
            {
                InsertQuery = @"Update [dbo].[Ajay_StudentDept]
           Set [Name] = @Name
           ,[Email] = @Email
           ,[DeptName] = @DeptName
           ,[PhoneNo] =@PhoneNo
             WHERE id=@Id";
            }
            */
            string InsertQuery = "Ajay_ManageEmployees";

            KeyValuePairList kvpObject = new DAL.KeyValuePairList();

            kvpObject.Add(new KeyValuePair("ID", student.Id));
            kvpObject.Add(new KeyValuePair("@Name", student.Name));
            kvpObject.Add(new KeyValuePair("@PhoneNo", student.PhoneNo));
            kvpObject.Add(new KeyValuePair("@Email", student.Email));
            kvpObject.Add(new KeyValuePair("@DeptName", student.DeptName));
            kvpObject.Add(new KeyValuePair("@Password", student.Password));
            kvpObject.Add(new KeyValuePair("@IsActive", student.IsActive));
            if (student.Id == 0)
                kvpObject.Add(new KeyValuePair("@QueryParam", "Insert"));
            else
                kvpObject.Add(new KeyValuePair("@QueryParam", "Update"));


            int RowsAffected = dalObject.InsertUpdateOrDelete(InsertQuery, kvpObject, CommandType.StoredProcedure);

            return RowsAffected;

        }
        public DataTable ReturnSpecificEmployee(string Phone)
        {
            string SelectQuery = "select * from [dbo].[Ajay_StudentDept] Where IsActive=1 AND [PhoneNo]='" + Phone + "'";

            DataTable dt = dalObject.FillAndReturnDataTable(SelectQuery);
            return dt;
        }
        public DataTable ReturnPhonePass(string Phone,string Password)
        {
            string SelectQuery = "select * from [dbo].[Ajay_StudentDept] Where IsActive=1 AND [PhoneNo]='" + Phone + "' AND [Password]='"+Password+"'";

            DataTable dt = dalObject.FillAndReturnDataTable(SelectQuery);
            return dt;
        }
        public DataTable ReturnAllEmployeePhones()
        {
            string SelectQuery = "sp_AllPhoneNumbers";//here i have replaced the query with a stored procedure

            DataTable dt = dalObject.FillAndReturnDataTable(SelectQuery);
            return dt;
        }
        public DataTable ReturnAllEmployee()
        {
            string SelectQuery = "Select *  from [dbo].[Ajay_StudentDept]";
            DataTable dt = dalObject.FillAndReturnDataTable(SelectQuery);
            return dt;
        }
        public bool ValidateEmployee(string Phone, string Password)
        {
            string Query = "Select * from [dbo].[Ajay_StudentDept] where PhoneNo='" + Phone + "' AND Password='" + Password + "'";

            DataTable dt = dalObject.FillAndReturnDataTable(Query);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

    }
        public class StudentDTO
        {


            public int Id { get; set; }
            public string Name { get; set; }

            public string DeptName { get; set; }
            public string PhoneNo { get; set; }
            public string Email { get; set; }

            public string Password { get; set; }
            public bool IsActive { get; set; }

        }
    }

