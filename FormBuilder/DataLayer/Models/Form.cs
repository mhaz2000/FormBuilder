using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer.Models.BasicComponent;
using DataLayer.Models.AdvancedComponent;
namespace DataLayer.Models
{
    public class Form
    {
        public Form()
        {
            FormID = Guid.NewGuid();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid FormID { get; set; }
        public string FormName { get; set; }
        public IEnumerable<CheckBox> CheckBoxes { get; set; }
        public IEnumerable<DropDown> DropDowns { get; set; }
        public IEnumerable<Heading> Headings { get; set; }
        public IEnumerable<RadioButton> RadioButtons { get; set; }
        public IEnumerable<TextArea> TextAreas { get; set; }
        public IEnumerable<TextBox> TextBoxes { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
        public IEnumerable<BirthDayPicker> BirthDayPickers { get; set; }
        public IEnumerable<Email> Emails { get; set; }
        public IEnumerable<FileUpload> FileUploads { get; set; }
        public IEnumerable<FullName> FullNames { get; set; }
        public IEnumerable<Phone> Phones { get; set; }
    }
}
