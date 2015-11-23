using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.DAL;

namespace WcfService.BLL
{
    public class PartCtr
    {
       
        public void InsertPart(int IDPart, string Name, string Brand, string Category, float PWeight, string Colour, string Material,int Price)
        {
            DBPart dbp = new DBPart();

            dbp.OpenConnection();
            dbp.InsertPart(IDPart, Name, Brand, Category, PWeight, Colour, Material,Price);
            dbp.CloseConnection();

        }
    }
}