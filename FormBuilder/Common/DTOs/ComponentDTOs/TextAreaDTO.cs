using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.ComponentDTOs
{
    public class TextAreaDTO :BaseComponentDto
    {
        public int MaxCharacter { get; set; }
        public string TextAreaValue  { get; set; }
    }
}
