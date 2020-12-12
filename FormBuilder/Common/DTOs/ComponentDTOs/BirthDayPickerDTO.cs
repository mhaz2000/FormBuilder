using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;

namespace Common.DTOs.ComponentDTOs
{
    public class BirthDayPickerDTO :BaseComponentDto
    {
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public Month Month { get; set; }
        public int Day { get; set; }
        public int Year { get; set; }
    }
}
