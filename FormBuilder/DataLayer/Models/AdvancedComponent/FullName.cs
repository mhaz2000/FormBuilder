using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.AdvancedComponent
{
    public class FullName : BaseComponent
    {
        public FullName() : base()
        {

        }
        public FullName(string fullNameHelpText, string fullNameFirstNamePart, string fullNameMiddleNamePart, bool fullNameIsRequired, string fullNameLastNamePart, string componentLabel) : base(componentLabel)
        {
            FullNameHelpText = fullNameHelpText;
            FullNameFirstNamePart = fullNameFirstNamePart;
            FullNameMiddleNamePart = fullNameMiddleNamePart;
            FullNameIsRequired = fullNameIsRequired;
            FullNameLastNamePart = fullNameLastNamePart;
        }
        public string FullNameHelpText { get; set; }
        public string FullNameFirstNamePart { get; set; }
        public string FullNameMiddleNamePart { get; set; }
        public bool FullNameIsRequired { get; set; }
        public string FullNameLastNamePart { get; set; }
        public Form Form { get; set; }
    }
}
