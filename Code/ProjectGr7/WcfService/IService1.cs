using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Model;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void InsertBike(Bike b);

        [OperationContract]
        Bike FindBikeById(int IDBike);

        [OperationContract]
        List<Bike> GetBikesByCategory(string Category);

        [OperationContract]
        List<Bike> SortBikesByPrice(List<Bike> bikes);

        [OperationContract]
        void SerializeToXml(Object obj);



    }
}
