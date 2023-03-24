using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticCompany
{
    public abstract class ProductTransport
    {
        #region Properties
        public string Customer { get; set; }
        public string Destination { get; set; }
        #endregion

        #region Methods
        public void CollectProductFromCustomer()
        {
            Console.WriteLine("Die Waren werden abgeholt");
        }

        public abstract void TransportProducts();
        #endregion
    }
}
