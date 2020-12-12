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
        public Address(string componentLabel,bool isRequired,string helpText,string street1, string street2,string city,string proviceOrState,string zipCode,Countries countries) : base(componentLabel)
        {
            IsRequired = isRequired;
            HelpText = helpText;
            StreetAddress1 = street1;
            StreetAddress2 = street2;
            City = city;
            ProviceOrState = proviceOrState;
            ZipCode = zipCode;
            AddressCountryDropDown = countries;
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
