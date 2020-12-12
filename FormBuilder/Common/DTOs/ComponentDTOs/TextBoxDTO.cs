using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.ComponentDTOs
{
    public class TextBoxDTO : BaseComponentDto
    {
        public string TextBoxValue { get; set; }
        public string TextBoxHint { get; set; }
        public int MaxCharacter { get; set; }
    }
}
