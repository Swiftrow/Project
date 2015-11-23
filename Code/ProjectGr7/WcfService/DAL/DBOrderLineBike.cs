using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Model;

namespace WcfService.DAL
{
    class DBOrderLineBike
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
            

        


        public void InsertOrderLineBike(OrderLineBike olb, int IDShoppingCart)
        {
            string sql = string.Format("Insert Into OrderLineBike" +
            "(IDLB,Amount,IDBike) Values" +
            "('{0}', '{1}', '{2}')", IDShoppingCart, olb.Amount, olb.Bike.IDBike);
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                    cmd.ExecuteNonQuery();
            }
         }

    }
    
}
    

