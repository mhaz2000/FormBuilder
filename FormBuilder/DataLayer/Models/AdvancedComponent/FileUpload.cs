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
        public FileUpload(string fileUploadHelpText, bool fileUploadIsRequired, List<string> validExtensions, int minFileSize, int maxFileSize, string fileLocation, string componentLabel) : base(componentLabel)
        {
            FileUploadHelpText = fileUploadHelpText;
            FileUploadIsRequired = fileUploadIsRequired;
            ValidExtensions = validExtensions;
            MinFileSize = minFileSize;
            MaxFileSize = maxFileSize;
            FileLocation = fileLocation;
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
