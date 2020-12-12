using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.ComponentDTOs
{
    public class CheckBoxDTO :BaseComponentDto
    {
        public List<string> CheckBoxOptions { get; set; }
        public string CheckBoxSelectedOptions { get; set; }
    }
}
