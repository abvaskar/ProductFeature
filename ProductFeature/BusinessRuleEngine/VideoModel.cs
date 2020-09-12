using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRuleEngine
{
    public class VideoModel : IProductModel
    {

        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; }

        public string PaymentDetails(string Customer)
        {

            return "Packing Slip Generated with Free First Aid Video";

        }

    }
}
