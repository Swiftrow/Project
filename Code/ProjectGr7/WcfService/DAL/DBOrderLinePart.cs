using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class DBOrderLinePart
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




        public void InsertOrderLinePart(OrderLinePart olp, int IDShoppingCart)
        {
            string sql = string.Format("Insert Into OrderLinePart" +
              "(IDLP,Amount,IDPart) Values" +
              "('{0}', '{1}', '{2}')", IDShoppingCart, olp.Amount, olp.Part.IDPart);
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }

    }
}
