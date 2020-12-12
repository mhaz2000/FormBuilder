using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.BasicComponent
{
    public class RadioButton : BaseComponent
    {
        public RadioButton() : base()
        {
        }
        public List<string> RadioBoxOptions { get; set; }
        public string RadioBoxSelectedOptions { get; set; }
        public string RadioBoxHelpBox { get; set; }
        public bool RadioBoxIsRequired { get; set; }
        public Form Form { get; set; }

    }
}
