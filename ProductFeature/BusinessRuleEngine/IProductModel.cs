using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public interface IProductModel
    {

        string Title { get; set; }

        bool HasOrderBeenCompleted { get; }

        string PaymentDetails(string ProductType);

    }
}
