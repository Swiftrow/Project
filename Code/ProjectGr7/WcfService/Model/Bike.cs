using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class Bike
    {
        [DataMember]
        public int IDBike { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string Colour { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public int WheelSize { get; set; }
        [DataMember]
        public float BWeight { get; set; }
        [DataMember]
        public int Size { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string Material { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Features { get; set; }

        //public Bike(int IDBike, string Name, string Category, string Brand, int Price, float BWeight, int Size, string Gender, string Material, string Colour, int WheelSize, string Features)
        //{
        //    this.IDBike = IDBike;
        //    this.Name = Name;
        //    this.Category = Category;
        //    this.Brand = Brand;
        //    this.Price = Price;
        //    this.BWeight = BWeight;
        //    this.Size = Size;
        //    this.Gender = Gender;
        //    this.Material = Material;
        //    this.Colour = Colour;
        //    this.WheelSize = WheelSize;
        //    this.Features = Features;
        //}

        //public Bike() { }
    }
}