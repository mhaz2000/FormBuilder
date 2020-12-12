using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.ComponentDTOs
{
    public class RadioButtonDTO :BaseComponentDto
    {
        public bool TextBoxIsRequired { get; set; }
        public List<string> RadioButtonOptions { get; set; }
        public string RadioButtonSelectedOptions { get; set; }
    }
}
