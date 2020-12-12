using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.ComponentDTOs
{
    public class DropDownDTO :BaseComponentDto
    {
        public List<string> DropDwonOptions { get; set; }
        public string SelectedOptions { get; set; }
    }
}
