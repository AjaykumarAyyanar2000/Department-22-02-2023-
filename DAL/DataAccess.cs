using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Department.DAL
{

    public class DataAccess
    {
        //Creating a connection object in the data access layer as this is for data
        //connecting with the database layer
        SqlConnection connectionObject = new SqlConnection("Data Source=176.0.52.194;Initial Catalog=AdventureWorks2012;User ID=806757;Password=Poojaashree@$2011");


        //Insert,update or delete function
        //This is a generic function so we need to pass the query string and the values of the fields as per the table
        public int InsertUpdateOrDelete(string Query, KeyValuePairList keyValuePairs, CommandType commandType = CommandType.Text)
        {
            SqlCommand cmdGenericObject = new SqlCommand(Query, GetConnection());

            if (commandType == CommandType.StoredProcedure)
            {
                cmdGenericObject.CommandType = CommandType.StoredProcedure;
            }

            //This loop makes sure that how many ever fields are there in the table 

            foreach (KeyValuePair keyValuePair in keyValuePairs)
            {
                cmdGenericObject.Parameters.AddWithValue(keyValuePair.ParamName, keyValuePair.ParamValue);

            }
            //This line
            int RowsAffected = cmdGenericObject.ExecuteNonQuery();
            CloseConnection();
            return RowsAffected;

        }
        public SqlConnection GetConnection()
        {
            connectionObject.Open();
            return connectionObject;
        }

        public void CloseConnection()
        {
            connectionObject.Close();
        }
        public DataTable FillAndReturnDataTable(string SelectQuery)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(SelectQuery, GetConnection());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CloseConnection();
            return dt;

        }

    }

    public class KeyValuePair
    {
        //Parameterized Constructor
        public KeyValuePair(string Param, object PValue)
        {
            ParamName = Param;
            ParamValue = PValue;
        }
        public string ParamName { get; set; }
        public object ParamValue { get; set; }
    }

    public class KeyValuePairList : List<KeyValuePair>
    {

    }
}