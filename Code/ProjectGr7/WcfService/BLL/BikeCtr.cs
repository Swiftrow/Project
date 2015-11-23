using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml;
using System.Xml.Serialization;
using WcfService.DAL;
using WcfService.Model;

namespace WcfService.BLL
{
    public class BikeCtr
    {

   


        public void InsertBike(int IDBike, string Name, string Category, string Brand, int Price, float BWeight, int Size, string Gender, string Material, string Colour, int WheelSize, string Features)
        {
            DBBike dbb = new DBBike();

            dbb.OpenConnection();
            dbb.InsertBike(IDBike, Name, Category, Brand, Price, BWeight, Size, Gender, Material, Colour, WheelSize, Features);
            dbb.CloseConnection();

        }




        public void DeleteBike(int IDBike)
        {
            DBBike dbb = new DBBike();

            dbb.OpenConnection();
            dbb.DeleteBike(IDBike);
            dbb.CloseConnection();
        }

        public void UpdateBike(int IDBike, string Name, string Category, string Brand, int Price, float BWeight, int Size, string Gender, string Material, string Colour, int WheelSize, string Features)
        {
            DBBike dbBike = new DBBike();
            dbBike.OpenConnection();
            dbBike.UpdateBike(IDBike, Name, Category, Brand, Price, BWeight, Size, Gender, Material, Colour, WheelSize, Features);
            dbBike.CloseConnection();
        }

        public Bike FindBikeById(int IDBike)
        {
            
            DBBike dbBike = new DBBike();
            Bike bike= dbBike.FindBikeById(IDBike);
          //  SerializeToXml((Object)bike);
            return bike;
        }

        public List<Bike> GetAllBikes()
        {
            DBBike dbBike = new DBBike();
            List<Bike> bikes = new List<Bike>();
            bikes=dbBike.GetBikes();
            return bikes;
        }

        public List<Bike> GetBikesByCategory(string Category)
        {
            DBBike dbBike = new DBBike();
            List<Bike> bikes = new List<Bike>();
            bikes = dbBike.GetBikesByCategory(Category);
            return bikes;
        }

        public List<Bike> SortByPrice(List<Bike> bikes)
        {
            List<Bike> sortedBikes = new List<Bike>();
            Bike aux = new Bike();

            for(int i = 0; i < bikes.Count - 1; i++)
            {
                for(int j = i + 1; j < bikes.Count; j++)
                {
                    if(bikes[i].Price > bikes[j].Price)
                    {
                        aux = bikes[j];
                        bikes[j] = bikes[i];
                        bikes[i] = aux;
                    }
                }
            }
            sortedBikes = bikes;
            


            return sortedBikes;

        }
    }
}