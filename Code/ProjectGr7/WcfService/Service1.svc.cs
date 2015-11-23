using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Model;
using WcfService.BLL;
using System.IO;
using System.Xml;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        BikeCtr bikeCtr = new BikeCtr();

        public void InsertBike(Bike b)
        {
            bikeCtr.InsertBike(b.IDBike, b.Name, b.Category, b.Brand, b.Price, b.BWeight, b.Size, b.Gender, b.Material, b.Colour, b.WheelSize, b.Features);
        }


        public Bike FindBikeById(int IDBike)
        {
            return bikeCtr.FindBikeById(IDBike);
            
        }

        public List<Bike> GetBikesByCategory(string Category)
        {
            return bikeCtr.GetBikesByCategory(Category);
        }

        public List<Bike> SortBikesByPrice(List<Bike> bikes)
        {
            return bikeCtr.SortByPrice(bikes);
        }

        public void SerializeToXml(Object obj)
        {

            DataContractSerializer dcs = new DataContractSerializer(obj.GetType());
            try
            {
                using (Stream stream = new FileStream(@"C:\Users\Stan\Desktop\XmlFile.xml", FileMode.Create, FileAccess.Write))
                {
                    XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateTextWriter(stream);
                    xdw.WriteStartDocument();
                    dcs.WriteObject(xdw, obj.GetType());
                    xdw.Close();
                    stream.Flush();
                    stream.Close();
                }
            }
            catch (Exception e)
            {
            }
        }

        //public Object DeserializeFromXml(Object obj, string xml)
        //{

        //    DataContractSerializer dcs = new DataContractSerializer(obj.GetType());
        //    return dcs.Desia
        //}

    }
}
