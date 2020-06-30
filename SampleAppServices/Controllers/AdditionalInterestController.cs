using SampleMVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SampleAppServices.Controllers
{
    public class AdditionalInterestController : ApiController
    {
            private static List<AdditionalInterestContact> results = new List<AdditionalInterestContact>()
            {

            new AdditionalInterestContact() { Name = "Bank of America", Address = "1438 Potomac avenue", City = "Pittsburgh", State = "PA", ZipCode = "15220" },

            new AdditionalInterestContact() { Name = "Bank of America", Address = "643 River Hwy", City = "Mooresville", State = "NC", ZipCode = "28117" },

            new AdditionalInterestContact() { Name = "JPMorgan Chase", Address = "643 River Hwy", City = "California", State = "NC", ZipCode = "28117" },

            new AdditionalInterestContact() { Name = "JPMorgan Chase", Address = "643 River Hwy", City = "Kansas", State = "KA", ZipCode = "28891" },

            new AdditionalInterestContact() { Name = "Citigroup", Address = "643 River Hwy", City = "Overland Park", State = "KA", ZipCode = "28117" },

            new AdditionalInterestContact() { Name = "Citigroup", Address = "643 River Hwy", City = "Florida", State = "FL", ZipCode = "28117" },

            new AdditionalInterestContact() { Name = "Wells Fargo", Address = "643 River Hwy", City = "Mooresville", State = "MI", ZipCode = "28117" },

            new AdditionalInterestContact() { Name = "Wells Fargo", Address = "643 River Hwy", City = "Mooresville", State = "PA", ZipCode = "28117" }

            };

        public Quote GetQuote()
        {
            Quote quote = new Quote()
            {
                QuoteId = 1,
                QuoteNumber = "QT -PA100432",
                PersonFullName = "Bob Smith",
                Product = "Personal Vehicla",
                State = "PA",
                EffectiveDate = "09/10/2015",
                ExpirationDate = "09/10/2016",
                AdditionalInterestQuestion = false
            };
            return quote;
        }

        [HttpGet]
        public IEnumerable<AdditionalInterestContact> GetSearchResults(string name)
        {
            return results.Where(s=>s.Name.Contains(name));
        }

        [HttpPost]
        public void SaveContact(AdditionalInterestContact contact)
        {
            results.Add(contact);
        }
    }
}
