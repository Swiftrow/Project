using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService.DAL
{
    class DBPart
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




        public void InsertPart(int IDPart, string Name, string Brand, string Category, float PWeight, string Colour, string Material, int Price)
        {
            string sql = string.Format("Insert Into Part" +
              "(IDPart, Name, Brand, Category, PWeight, Colour, Material,  Price) Values" +
              "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", IDPart, Name, Brand, Category, PWeight, Colour, Material, Price);
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }

    }
}

