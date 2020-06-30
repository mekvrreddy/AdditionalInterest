using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMVCApp.Models
{
    public class Quote
    {
        public int QuoteId { get; set; }

        public string QuoteNumber { get; set; }

        public string PersonFullName { get; set; }

        public string Product { get; set; }

        public string State { get; set; }

        public string EffectiveDate { get; set; }

        public string ExpirationDate { get; set; }

        public bool   AdditionalInterestQuestion { get; set; }
    }
}
