using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.AdvancedComponent
{
    public class Phone :BaseComponent
    {
        public Phone():base()
        {

        }
        public Phone(string phoneHelpText, bool phoneIsRequired, string phoneAreaCode, string phoneNumber, string componentLabel) :base(componentLabel)
        {
            PhoneHelpText = phoneHelpText;
            PhoneIsRequired = phoneIsRequired;
            PhoneAreaCode = phoneAreaCode;
            PhoneNumber = phoneNumber;
        }
        public string PhoneHelpText { get; set; }
        public bool PhoneIsRequired { get; set; }
        public string PhoneAreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public Form Form { get; set; }
    }
}
