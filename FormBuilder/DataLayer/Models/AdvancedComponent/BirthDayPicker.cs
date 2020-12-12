using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;

namespace DataLayer.Models.AdvancedComponent
{
    public class BirthDayPicker : BaseComponent
    {
        public BirthDayPicker() : base()
        {

        }
        public BirthDayPicker(string birthDayPickerHelpText, bool birthDayPickerIsRequired, int minimumAge, int maximumAge, Month month, int year, int day, string componentLabel) : base(componentLabel)
        {
            BirthDayPickerHelpText = birthDayPickerHelpText;
            BirthDayPickerIsRequired = birthDayPickerIsRequired;
            MinimumAge = minimumAge;
            MaximumAge = maximumAge;
            this.Month = month;
            Year = year;
            Day = day;
        }
        public string BirthDayPickerHelpText { get; set; }
        public bool BirthDayPickerIsRequired { get; set; }
        public int MinimumAge { get; set; }
        public int MaximumAge { get; set; }
        public Month Month { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
        public Form Form { get; set; }
    }
}
