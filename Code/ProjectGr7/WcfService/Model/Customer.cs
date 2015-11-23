using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Model
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int IDCust { get; set; }

        [DataMember]
        public string Name{ get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Password { get; set; } //HASH ?

        public Customer()
        {

        }
        public Customer(int IDCust, string Name, string Email, string Password)
        {
            this.Email = Email;
            this.Name = Name;
            this.IDCust = IDCust;
            this.Password = Password;
        }

    }
}