using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;

namespace Common.DTOs.ComponentDTOs
{
    public class AddressDTO : BaseComponentDto
    {
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string ProvinceOrState { get; set; }
        public string ZipCode { get; set; }
        public Countries Countries { get; set; }
    }
}
