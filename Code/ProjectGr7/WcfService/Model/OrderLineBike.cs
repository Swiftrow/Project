using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class OrderLineBike
    {
        [DataMember]
        public int IDLB { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public Bike Bike;


        public OrderLineBike()
        {

        }

        public OrderLineBike(Bike Bike, int Amount)
        {
            this.Bike = Bike;
            this.Amount = Amount;
        }
    }
}