using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.BasicComponent
{
    public class Heading :BaseComponent
    {
        public Heading():base()
        {
            
        }

        public string HeadingText { get; set; }
        public Form Form { get; set; }

    }
}
