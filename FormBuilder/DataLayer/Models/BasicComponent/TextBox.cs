using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.BasicComponent
{
    public class TextBox : BaseComponent
    {
        public TextBox() : base()
        {
        }
        public string TextBoxHint { get; set; }
        public string TextBoxHelpText { get; set; }
        public string TextBoxText { get; set; }
        public bool TextBoxIsRequired { get; set; }
        public int TextBoxMaxCharacter { get; set; }
        public Form Form { get; set; }

    }
}
