using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticCompany
{
    public class Logistics
    {
        //this method returns a type of product based on the transport type (Air, Sea, Road) based on the product class ProductTransport.cs
        public ProductTransport ManageTransport(string transportType)
        {
            ProductTransport transport = null;

            //you can also writen an if-condition
            switch (transportType)
            {
                case "Air":
                    transport = new ConcreteFlightTransport();
                    break;
                case "Sea":
                    transport = new ConcreteSeaTransport();
                    break;                
                case "Road":
                    transport = new ConcreteRoadTransport();
                    break;
                default:
                    throw new ArgumentException("Transport type not supported");
            }

            transport.CollectProductFromCustomer();
            transport.TransportProducts();
            return transport;
        }
    }
}
