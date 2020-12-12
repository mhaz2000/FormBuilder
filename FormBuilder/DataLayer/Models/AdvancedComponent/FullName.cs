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
        public string FullNameHelpText { get; set; }
        public string FullNameFirstNamePart { get; set; }
        public string FullNameMiddleNamePart { get; set; }
        public bool FullNameIsRequired { get; set; }
        public string FullNameLastNamePart { get; set; }
        public Form Form { get; set; }
    }
}
