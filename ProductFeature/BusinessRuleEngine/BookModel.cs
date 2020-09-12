using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class BookModel : IProductModel
    {

        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; }

        public string PaymentDetails(string productType)
        {

            return "Duplicate Payslip Generated For Royalty Department and Commision is generated to the Agent";

        }
    }
}
