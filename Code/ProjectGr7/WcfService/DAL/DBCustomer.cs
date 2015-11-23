using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class DBCustomer
    {

        private SqlConnection sqlCn = null;
        string cnStr = ConfigurationManager.ConnectionStrings["AutoConnect"].ConnectionString;

        public void OpenConnection()
        {
            sqlCn = new SqlConnection();
            sqlCn.ConnectionString = cnStr;
            sqlCn.Open();
        }

        public void CloseConnection()
        {
            sqlCn.Close();
        }
        public void InsertCustomer(int IDCust, string Name, string Email, string Password)
        {

            
            string sql = string.Format("Insert into Customer" + "(IDCust,Name,Email,Pass) Values" + "('{0}','{1}','{2}','{3}')", IDCust, Name, Email, Password);

            using (SqlCommand cmd = new SqlCommand(sql,sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteCustomer(int IDCust)
        {
            string sql = string.Format("delete  from Customer  where IDCust='" + IDCust + "'");

            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateCustomer(int IDCust, string Name, string Email, string Password)
        {
            string sql = string.Format("Update Customer Set Name='" + Name + "'," + "Email='" + Email + "'," + "Password='" + Password + " Where IDCust=@IDCust");
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.Parameters.AddWithValue("@IDBike", IDCust);
                cmd.ExecuteNonQuery();
            }
        }

        public Customer FindCustomerById(int IDCust)
        {
            Customer c = new Customer();
            using (SqlConnection myConnection = new SqlConnection(cnStr))
            {
                string q = " Select * From Customer where IDCust=@IDCust";
                SqlCommand myCommand = new SqlCommand(q, myConnection);
                myCommand.Parameters.AddWithValue("@IDCust", IDCust);
                myConnection.Open();
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    if (myDataReader != null)
                    {
                        while (myDataReader.Read())
                        {
                            string strId = myDataReader["IDCust"].ToString();
                            c.IDCust = Int32.Parse(strId);
                            c.Name = myDataReader["Name"].ToString();                                               
                            c.Email = myDataReader["Email"].ToString();
                            c.Password = myDataReader["Password"].ToString();
                           
                        }
                    }
                    myConnection.Close();
                }
            }
            return c;
        }

        //dal- transcations crud
    }
}