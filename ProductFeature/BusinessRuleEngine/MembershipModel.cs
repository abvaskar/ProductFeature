using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class MembershipModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; }

        public string PaymentDetails(string ProductType)
        {

            if (ProductType == "Register Membership")
            {
                string emailSent = Email("abhishek");
                return "Member Registered" + " " + emailSent;
            }
            else
                return UpgradeMembership("Abhishek");

        }

        public string Email(string Customer)
        {

            return "Email Sent to  " + Customer + " with membership details";

        }

        public string UpgradeMembership(string Customer)
        {
            string emailSent = Email(Customer);
            return "Member Upgraded" + " " + emailSent;

        }
    }
}
