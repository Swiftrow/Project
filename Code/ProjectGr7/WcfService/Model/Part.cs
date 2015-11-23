using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class Part
    {
        [DataMember]
        public int IDPart { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public float Weight { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Color { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Material { get; set; }

    }
}