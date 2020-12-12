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
        public string PhoneHelpText { get; set; }
        public bool PhoneIsRequired { get; set; }
        public string PhoneAreaCode { get; set; }
        public string PhoneNumber { get; set; }
        public Form Form { get; set; }
    }
}
