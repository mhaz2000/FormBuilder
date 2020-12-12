using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.AdvancedComponent
{
    public class Email : BaseComponent
    {
        public Email() : base()
        {

        }

        public Email(string emailHelpText, bool emailIsRequired, string emailText, int emailMaxCharacter, string componentLabel) :base(componentLabel)
        {
            EmailHelpText = emailHelpText;
            EmailIsRequired = emailIsRequired;
            EmailText = emailText;
            EmailMaxCharacter = emailMaxCharacter;
        }
        public string EmailHelpText { get; set; }
        public bool EmailIsRequired { get; set; }
        public string EmailText { get; set; }
        public int EmailMaxCharacter { get; set; }
        public Form Form { get; set; }
    }
}
