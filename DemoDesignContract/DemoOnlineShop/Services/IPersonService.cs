using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoOnlineShop.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPersonService" in both code and config file together.
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        IEnumerable<Person> GetPersons();
        [OperationContract]
        IEnumerable<SalesPerson> GetSalesPerson();
    }

    [DataContract]
    [KnownType(typeof(SalesPerson))]
    public class Person
    {
        [DataMember]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class SalesPerson : Person
    {
        public double Commission { get; set; }
    }
}
