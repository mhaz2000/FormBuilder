using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;

namespace DataLayer.Models.AdvancedComponent
{
    public class Address :BaseComponent
    {
        public Address():base()
        {

        }
        public bool IsRequired { get; set; }
        public string HelpText { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string ProviceOrState { get; set; }
        public string ZipCode { get; set; }
        public Countries AddressCountryDropDown { get; set; }
        public Form Form { get; set; }

    }
}
