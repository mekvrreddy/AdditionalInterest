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

        private static List<State> states = new List<State>()
        {
            new State() {Code="AL",Name="Alabama"},
new State() {Code="AK",Name="Alaska"},
new State() {Code="AZ",Name="Arizona"},
new State() {Code="AR",Name="Arkansas"},
new State() {Code="CA",Name="California"},
new State() {Code="CO",Name="Colorado"},
new State() {Code="CT",Name="Connecticut"},
new State() {Code="DE",Name="Delaware"},
new State() {Code="FL",Name="Florida"},
new State() {Code="GA",Name="Georgia"},
new State() {Code="HI",Name="Hawaii"},
new State() {Code="ID",Name="Idaho"},
new State() {Code="IL",Name="Illinois"},
new State() {Code="IN",Name="Indiana"},
new State() {Code="IA",Name="Iowa"},
new State() {Code="KS",Name="Kansas"},
new State() {Code="KY",Name="Kentucky"},
new State() {Code="LA",Name="Louisiana"},
new State() {Code="ME",Name="Maine"},
new State() {Code="MD",Name="Maryland"},
new State() {Code="MA",Name="Massachusetts"},
new State() {Code="MI",Name="Michigan"},
new State() {Code="MN",Name="Minnesota"},
new State() {Code="MS",Name="Mississippi"},
new State() {Code="MO",Name="Missouri"},
new State() {Code="MT",Name="Montana"},
new State() {Code="NE",Name="Nebraska"},
new State() {Code="NV",Name="Nevada"},
new State() {Code="NH",Name="New Hampshire"},
new State() {Code="NJ",Name="New Jersey"},
new State() {Code="NM",Name="New Mexico"},
new State() {Code="NY",Name="New York"},
new State() {Code="NC",Name="North Carolina"},
new State() {Code="ND",Name="North Dakota"},
new State() {Code="OH",Name="Ohio"},
new State() {Code="OK",Name="Oklahoma"},
new State() {Code="OR",Name="Oregon"},
new State() {Code="PA",Name="Pennsylvania"},
new State() {Code="RI",Name="Rhode Island"},
new State() {Code="SC",Name="South Carolina"},
new State() {Code="SD",Name="South Dakota"},
new State() {Code="TN",Name="Tennessee"},
new State() {Code="TX",Name="Texas"},
new State() {Code="UT",Name="Utah"},
new State() {Code="VT",Name="Vermont"},
new State() {Code="VA",Name="Virginia"},
new State() {Code="WA",Name="Washington"},
new State() {Code="WV",Name="West Virginia"},
new State() {Code="WI",Name="Wisconsin"},
new State() {Code="WY",Name="Wyoming"}
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
            return results.Where(s=>s.Name.Trim().ToLower().Contains(name.Trim().ToLower()));
        }

        [HttpPost]
        public void SaveContact(AdditionalInterestContact contact)
        {
            results.Add(contact);
        }

        [HttpGet]
        public IEnumerable<State> GetStates()
        {
            return states;
        }
    }
}
