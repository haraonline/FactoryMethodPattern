using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticCompany
{
    public class ConcreteRoadTransport: ProductTransport
    {
        public override void TransportProducts()
        {
            Console.WriteLine("Die Waren werden über den Straßenweg transportiert");
        }
    }
}
