using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentModulle
{
   public class PayModel
    {
        public string cardToken { get; set; }
        public long amount { get; set; }
        public string reference { get; set; }

    }
}
