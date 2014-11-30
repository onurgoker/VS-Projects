using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.Sql;

namespace AdventureWorksService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IServiceAdventureWorks
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string GetAddressDataByID(int id)
        {
            AdventureWorks2014Entities ef = new AdventureWorks2014Entities();

            Address adres = ef.Address.Find(id);

            return string.Format(adres.AddressLine1);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
