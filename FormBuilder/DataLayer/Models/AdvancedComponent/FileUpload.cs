using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models.AdvancedComponent
{
    public class FileUpload :BaseComponent
    {
        public FileUpload():base()
        {

        }
        public string FileUploadHelpText { get; set; }
        public bool FileUploadIsRequired { get; set; }
        public List<string> ValidExtensions { get; set; }
        public int MinFileSize { get; set; }
        public int MaxFileSize { get; set; }
        public string FileLocation { get; set; }
        public Form Form { get; set; }
    }
}
