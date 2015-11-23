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
    
    class DBShoppingCart
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




        public void InsertShoppingCart(ShoppingCart sc)
        {


            
            string sql = string.Format("Insert Into ShoppingCart" +
              "(IDShoppingCart,Date,IDCust) Values" +
              "('{0}', '{1}', '{2}')", sc.IDShoppingCart, sc.Date, sc.c.IDCust);
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();

                DBOrderLinePart dbOlp = new DBOrderLinePart();
                foreach (OrderLinePart olp in sc.Olp)
                {
                    dbOlp.InsertOrderLinePart(olp, sc.IDShoppingCart);
                }

                DBOrderLineBike dbOlb = new DBOrderLineBike();
                foreach(OrderLineBike olb in sc.Olb)
                {
                    dbOlb.InsertOrderLineBike(olb, sc.IDShoppingCart);
                }
            }
        }
   
    }
    
}
