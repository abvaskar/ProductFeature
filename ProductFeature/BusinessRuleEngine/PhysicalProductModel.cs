using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class PhysicalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; }

        public string PaymentDetails(string Customer)
        {

            return "Packing slip generated" + " " + PayAgent(Customer);

        }


        public string PayAgent(string Customer)
        {

            return "Commission is generated to the agent";

        }

    }
}
