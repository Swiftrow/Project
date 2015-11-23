using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class OrderLinePart
    {
        [DataMember]
        public int IDLP { get; set; }
        [DataMember]
        public int Amount { get; set; }
        [DataMember]
        public Part Part;

        public OrderLinePart()
        {
        }

        public OrderLinePart(Part Part, int Amount)
        {
            this.Amount = Amount;
            this.Part = Part;

        }

            
    }
}