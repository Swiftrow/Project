using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WcfService.Model;

namespace WcfService.DAL
{
    public class DBBike
    {
        private SqlConnection sqlCn = null;
        string cnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stan\Desktop\SkySales1_files\ProjectGr7\Database\Database.mdf;Integrated Security=True";

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




        public void InsertBike(int IDBike,string Name, string Category, string Brand, int Price, float BWeight, int Size, string Gender, string Material, string Colour, int WheelSize, string Features)
        {
            string sql = string.Format("Insert Into Bike" +
              "(IDBike,Name,Category,Brand,Price,BWeight,Size,Gender,Material,Colour,WheelSize, Features) Values" +
              "('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", IDBike, Name, Category, Brand, Price, BWeight, Size, Gender, Material, Colour, WheelSize, Features);
            using (SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteBike(int IDBike)
        {
            string sql =string.Format( "delete  from Bike  where IDBike='"+IDBike+"'" );
            
            using(SqlCommand cmd = new SqlCommand(sql, this.sqlCn))
            {

                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateBike(int IDBike, string Name, string Category, string Brand, int Price, float BWeight, int Size, string Gender, string Material, string Colour, int WheelSize, string Features)
        {
            string sql = string.Format("Update Bike Set Name='"+Name+"',"+"Category='"+Category+"',"+"Brand='"+Brand+"',"+"Price='"+Price+"',"+"BWeight='"+BWeight+"',"+"Size='"+Size+"',"+"Gender='"+Gender+"',"+"Material='"+Material+"',"+"Colour='"+Colour+"',"+"WheelSize='"+WheelSize+"',"+ "Features='"+Features+"'"+" Where IDBike=@IDBike" );
            using (SqlCommand cmd = new SqlCommand(sql, sqlCn))
            {
                cmd.Parameters.AddWithValue("@IDBike", IDBike);
                cmd.ExecuteNonQuery();
            }
        }

        public Bike FindBikeById(int IDBike)
        {
            Bike b = new Bike();
            using (SqlConnection myConnection = new SqlConnection(cnStr))
            {
                string q = " Select * From Bike where IDBike=@IDBike";
                SqlCommand myCommand = new SqlCommand(q, myConnection);
                myCommand.Parameters.AddWithValue("@IDBike", IDBike);
                myConnection.Open();
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    if (myDataReader != null)
                    {
                        while (myDataReader.Read())
                        {
                            string strId = myDataReader["IDBike"].ToString();
                            b.IDBike = Int32.Parse(strId);
                            b.Name = myDataReader["Name"].ToString();
                            b.Category = myDataReader["Category"].ToString();
                            b.Brand = myDataReader["Brand"].ToString();
                            string strPrice = myDataReader["Price"].ToString();
                            b.Price = Int32.Parse(strPrice);
                            string bWeight = myDataReader["BWeight"].ToString();
                            b.BWeight = float.Parse(bWeight);
                            string strSize = myDataReader["Size"].ToString();
                            b.Size = Int32.Parse(strSize);
                            b.Gender = myDataReader["Gender"].ToString();
                            b.Material = myDataReader["Material"].ToString();
                            b.Colour = myDataReader["Colour"].ToString();
                            string strWsize = myDataReader["WheelSize"].ToString();
                            b.WheelSize = Int32.Parse(strSize);
                            b.Features = myDataReader["Features"].ToString();
                        }
                    }
                    myConnection.Close();
                }
            }
            return b;
        }

        public List<Bike> GetBikes()
        {
            List<Bike> bikes  = new List<Bike>();
            using (SqlConnection myConnection = new SqlConnection(cnStr))
            {
                string q = " Select * From Bike ";
                SqlCommand myCommand = new SqlCommand(q, myConnection);
                myConnection.Open();
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    if (myDataReader != null)
                    {
                        while (myDataReader.Read())
                        {
                            Bike b = new Bike();
                            string strId = myDataReader["IDBike"].ToString();
                            b.IDBike = Int32.Parse(strId);
                            b.Name = myDataReader["Name"].ToString();
                            b.Category = myDataReader["Category"].ToString();
                            b.Brand = myDataReader["Brand"].ToString();
                            string strPrice = myDataReader["Price"].ToString();
                            b.Price = Int32.Parse(strPrice);
                            string bWeight = myDataReader["BWeight"].ToString();
                            b.BWeight = float.Parse(bWeight);
                            string strSize = myDataReader["Size"].ToString();
                            b.Size = Int32.Parse(strSize);
                            b.Gender = myDataReader["Gender"].ToString();
                            b.Material = myDataReader["Material"].ToString();
                            b.Colour = myDataReader["Colour"].ToString();
                            string strWsize = myDataReader["WheelSize"].ToString();
                            b.WheelSize = Int32.Parse(strSize);
                            b.Features = myDataReader["Features"].ToString();

                            bikes.Add(b);
                        }
                    }
                    myConnection.Close();
                }
            }
            return bikes;
        }

        public List<Bike> GetBikesByCategory(string Category)
        {
            List<Bike> bikes = new List<Bike>();
            using (SqlConnection myConnection = new SqlConnection(cnStr))
            {
                string q = " Select * From Bike where Category=@Category";
                SqlCommand myCommand = new SqlCommand(q, myConnection);
                myCommand.Parameters.AddWithValue("@Category", Category);
                myConnection.Open();
                using (SqlDataReader myDataReader = myCommand.ExecuteReader())
                {
                    if (myDataReader != null)
                    {
                        while (myDataReader.Read())
                        {
                            Bike b = new Bike();
                            string strId = myDataReader["IDBike"].ToString();
                            b.IDBike = Int32.Parse(strId);
                            b.Name = myDataReader["Name"].ToString();
                            b.Category = myDataReader["Category"].ToString();
                            b.Brand = myDataReader["Brand"].ToString();
                            string strPrice = myDataReader["Price"].ToString();
                            b.Price = Int32.Parse(strPrice);
                            string bWeight = myDataReader["BWeight"].ToString();
                            b.BWeight = float.Parse(bWeight);
                            string strSize = myDataReader["Size"].ToString();
                            b.Size = Int32.Parse(strSize);
                            b.Gender = myDataReader["Gender"].ToString();
                            b.Material = myDataReader["Material"].ToString();
                            b.Colour = myDataReader["Colour"].ToString();
                            string strWsize = myDataReader["WheelSize"].ToString();
                            b.WheelSize = Int32.Parse(strSize);
                            b.Features = myDataReader["Features"].ToString();

                            bikes.Add(b);
                        }
                    }
                    myConnection.Close();
                }
            }
            return bikes;
        }


    }
}