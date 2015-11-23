using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService.BLL;
using WcfService.DAL;
using WcfService.Model;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //CustomerCtr c = new CustomerCtr();
            //c.InsertCustomer(1, "Stan", "yahoo", "1234");

            //PartCtr p = new PartCtr();
            //p.InsertPart(3, "part", "bmw", "tren", 33, "black","abanos", 999);

            BikeCtr b = new BikeCtr();
         //   b.InsertBike(1, "sc32ott", "mtb", "bmb2", 10, 333, 45,"femin2in", "met2al","voma marii", 26, "mupontaie");
           // b.InsertBike(2, "sc32ott", "mtb", "bmb2", 40, 333, 45, "femin2in", "met2al", "voma marii", 26, "mupontaie");
           // b.InsertBike(3, "sc32ott", "mtb", "bmb2", 30, 333, 45, "femin2in", "met2al", "voma marii", 26, "mupontaie");
           // b.InsertBike(4, "sc32ott", "mtb", "bmb2", 5, 333, 45, "femin2in", "met2al", "voma marii", 26, "mupontaie");

            // b.DeleteBike(3);

            //b.UpdateBike(2, "salam", "manele", "guta", 2, 22.2f, 3, "salamesc", "valoare", "tiganeasca", 22, "nu are");

        //    b.FindBikeById(2);
            

            ////Bike bi= b.GetBikeById(1);
            List<Bike> bikes = b.GetBikesByCategory("mtb");
            bikes = b.SortByPrice(bikes);
            foreach (Bike bi in bikes)
            {
                Console.WriteLine("price {0}, id {1} ", bi.Price, bi.IDBike);
                Console.ReadLine();
            }




            //OrderLinePart olp= new OrderLinePart();
            //olp.Part=

            //ShoppingCartCtr sc = new ShoppingCartCtr();
            //sc.InsertShoppingCart()

        }
    }
}
