using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class CustomerModel : ICustomerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
    }
}
