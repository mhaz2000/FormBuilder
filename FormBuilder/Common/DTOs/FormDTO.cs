using Common.DTOs.ComponentDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DTOs
{
    public class FormDTO
    {
        public Guid FormID { get; set; }
        public string FormName { get; set; }
        public List<AddressDTO> AddressDTOs { get; set; }
        public List<CheckBoxDTO> CheckBoxDTOs { get; set; }
        public List<BirthDayPickerDTO> BirthDayPickerDTOs { get; set; }
        public List<DropDownDTO> DropDownDTOs { get; set; }
        public List<EmailDTO> EmailDTOs { get; set; }
        public List<FileUploadDTO> FileUploadDTOs { get; set; }
        public List<FullNameDTO> FullNameDTOs { get; set; }
        public List<HeadingDTO> HeadingDTOs { get; set; }
        public List<PhoneDTO> PhoneDTOs { get; set; }
        public List<RadioButtonDTO> RadioButtonDTOs { get; set; }
        public List<TextAreaDTO> TextAreaDTOs { get; set; }
        public List<TextBoxDTO> TextBoxDTOs { get; set; }
    }
}
