using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticCompany
{
    public class ConcreteSeaTransport: ProductTransport
    {
        public override void TransportProducts()
        {
            Console.WriteLine("Die Waren werden über den Seeweg transportiert");
        }
    }
}
