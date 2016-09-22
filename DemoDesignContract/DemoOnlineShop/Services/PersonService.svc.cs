using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoOnlineShop.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PersonService.svc or PersonService.svc.cs at the Solution Explorer and start debugging.
    public class PersonService : IPersonService
    {
        public void DoWork()
        {
        }

        public IEnumerable<Person> GetPersons()
        {
            return new List<Person>()
            {
                new Person
                {
                    FirstName = "John",
                    LastName = "Doe",
                },
                new Person
                {
                    FirstName = "Peter",
                    LastName = "Parker",
                },
                new SalesPerson
                {
                    FirstName = "Tom",
                    LastName = "Hanks",
                    Commission = 500,
                },
            };
        }

        public IEnumerable<SalesPerson> GetSalesPerson()
        {
            throw new NotImplementedException();
        }
    }
}
