using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PayTemplate
    {
        public string cardToken  { get; set; }
        public long amount  { get; set; }
        public string reference  { get; set; }
        
    }
}