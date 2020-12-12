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

        public string EmailHelpText { get; set; }
        public bool EmailIsRequired { get; set; }
        public string EmailText { get; set; }
        public int EmailMaxCharacter { get; set; }
        public Form Form { get; set; }
    }
}
