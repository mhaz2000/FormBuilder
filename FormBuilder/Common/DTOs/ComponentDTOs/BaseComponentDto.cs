using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.ComponentDTOs
{
    public class BaseComponentDto
    {
        public Guid BaseComponentID { get; set; }
        public string ComponentLabel { get; set; }
        public string ComponentHelpText { get; set; }
        public bool ComponentIsRequired { get; set; }
    }
}
