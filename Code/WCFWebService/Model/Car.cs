using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFWebService.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string Color { get; set; }
        public int TopSpeed { get; set; }
    }
}