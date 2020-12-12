using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs.ComponentDTOs
{
    public class FileUploadDTO :BaseComponentDto
    {
        public List<string> ValidExtensions { get; set; }
        public int MaxFileSize { get; set; }
        public int MinFileSize { get; set; }
        public string FileLocation { get; set; }
    }
}
