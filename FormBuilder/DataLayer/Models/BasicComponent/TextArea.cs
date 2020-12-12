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
        public TextArea(string textAreaHelpText, string textAreaText, bool textAreaIsRequired, int textAreaMaxCharacter, string componentLabel) : base(componentLabel)
        {
            TextAreaHelpText = textAreaHelpText;
            TextAreaText = textAreaText;
            TextAreaIsRequired = textAreaIsRequired;
            TextAreaMaxCharacter = textAreaMaxCharacter;
        }
        public string TextAreaHelpText { get; set; }
        public string TextAreaText { get; set; }
        public bool TextAreaIsRequired { get; set; }
        public int TextAreaMaxCharacter { get; set; }
        public Form Form { get; set; }


    }
}
