using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.ComponentDTOs
{
    public class EmailDTO :BaseComponentDto
    {
        public string EmailValue { get; set; }
        public int EmailMaxCharacter { get; set; }
    }
}
