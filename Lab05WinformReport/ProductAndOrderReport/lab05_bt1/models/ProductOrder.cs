using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05_bt1.models
{
    class ProductOrder
    {
        public DateTime DeliveryDate { get; set; }

        public string InvoiceNo { get; set; }

        public decimal Price { get; set; }
    }
}
