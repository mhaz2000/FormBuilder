using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.BasicComponent
{
    public class CheckBox : BaseComponent
    {
        public CheckBox() : base()
        {

        }
        public CheckBox(List<string> checkBoxOptions, string checkBoxSelectedOptions,string checkBoxHelpText, bool isRequiredCheckBox, string componentLabel) : base(componentLabel)
        {
            CheckBoxOptions = checkBoxOptions;
            CheckBoxSelectedOptions = checkBoxSelectedOptions;
            CheckBoxHelpText = checkBoxHelpText;
            IsRequiredCheckBox = isRequiredCheckBox;
        }
        public List<string> CheckBoxOptions { get; set; }
        public string CheckBoxSelectedOptions { get; set; }
        public string CheckBoxHelpText { get; set; }
        public bool IsRequiredCheckBox { get; set; }
        public Form Form { get; set; }

    }
}
