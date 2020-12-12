using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.BasicComponent
{
    public class TextArea : BaseComponent
    {
        public TextArea() : base()
        {
        }
        public string TextAreaHelpText { get; set; }
        public string TextAreaText { get; set; }
        public bool TextAreaIsRequired { get; set; }
        public int TextAreaMaxCharacter { get; set; }
        public Form Form { get; set; }


    }
}
