using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class ShoppingCart
    {
        [DataMember]
        public int IDShoppingCart { get; set; }
        [DataMember]
        public List<OrderLinePart> Olp { get; set; }
        [DataMember]
        public List<OrderLineBike> Olb { get; set; }
        [DataMember]
        public Customer c { get; set; }
        [DataMember]
        public string Date { get; set; }

        public ShoppingCart(int IDShoppingCart, string Date, Customer c)
        {
            this.IDShoppingCart = IDShoppingCart;
            Olp = new List<OrderLinePart>();
            Olb = new List<OrderLineBike>();
            this.Date = Date;
            this.c = c;
        }
        public ShoppingCart()
        { }

    }
}