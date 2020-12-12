using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.BasicComponent
{
    public class DropDown : BaseComponent
    {
        public DropDown():base()
        {
        }
        public String DropDownLabel { get; set; }
        public List<string> DropDownOptions { get; set; }
        public string DropDownSelectedOptions { get; set; }
        public string DropDownHelpText { get; set; }
        public bool IsRequiredDropDown { get; set; }
        public Form Form { get; set; }


    }
}
