using Common.DTOs;
using DataLayer.Context;
using DataLayer.Models;
using DataLayer.Models.BasicComponent;
using DataLayer.Models.AdvancedComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.FormCreating
{
    class FormCreatingRepository : Repository<Form>, IFormCreatingRepository
    {
        public FormCreatingRepository(FormDataBase dataBase) : base(dataBase)
        {
        }

        public void AddNewForm(FormDTO form)
        {
            Form newForm = new Form();

            //Sets address info
            List<Address> addresses = new List<Address>();
            var addressDTOs = form.AddressDTOs.ToList();
            foreach (var address in addressDTOs)
            {
                addresses.Add(new Address(address.ComponentLabel, address.ComponentIsRequired, address.ComponentHelpText, address.StreetAddress1,
                    address.StreetAddress2, address.City, address.ProvinceOrState, address.ZipCode, address.Countries));
            }
            newForm.Addresses = addresses;

            //Sets birth day info
            List<BirthDayPicker> birthDayPickers = new List<BirthDayPicker>();
            var birthDays = form.BirthDayPickerDTOs.ToList();
            foreach (var birthDay in birthDays)
            {
                birthDayPickers.Add(new BirthDayPicker(birthDay.ComponentHelpText, birthDay.ComponentIsRequired, birthDay.MinAge, birthDay.MaxAge,
                    birthDay.Month, birthDay.Year, birthDay.Day, birthDay.ComponentLabel));
            }
            newForm.BirthDayPickers = birthDayPickers;

            //Sets check box info.
            List<CheckBox> checkBoxes = new List<CheckBox>();
            var checkBoxDTOs = form.CheckBoxDTOs.ToList();
            foreach (var checkBox in checkBoxDTOs)
            {
                checkBoxes.Add(new CheckBox(checkBox.CheckBoxOptions, checkBox.CheckBoxSelectedOptions, checkBox.ComponentHelpText
                    , checkBox.ComponentIsRequired, checkBox.ComponentLabel));
            }
            newForm.CheckBoxes = checkBoxes;

            //Sets drop down info.
            List<DropDown> dropDowns = new List<DropDown>();
            var dropDownDTOs = form.DropDownDTOs.ToList();
            foreach (var dropDown in dropDownDTOs)
            {
                dropDowns.Add(new DropDown(dropDown.DropDownOptions, dropDown.SelectedOptions, dropDown.ComponentHelpText,
                    dropDown.ComponentIsRequired, dropDown.ComponentLabel));
            }
            newForm.DropDowns = dropDowns;

            //Sets Email info.
            List<Email> emails = new List<Email>();
            var emailDTOs = form.EmailDTOs.ToList();
            foreach (var email in emailDTOs)
            {
                emails.Add(new Email(email.ComponentHelpText, email.ComponentIsRequired, email.EmailValue, email.EmailMaxCharacter, email.ComponentLabel));
            }
            newForm.Emails = emails;

            //Sets File Upload info.
            List<FileUpload> fileUploads = new List<FileUpload>();
            var fileUploadDTOs = form.FileUploadDTOs.ToList();
            foreach (var file in fileUploadDTOs)
            {
                fileUploads.Add(new FileUpload(file.ComponentHelpText, file.ComponentIsRequired, file.ValidExtensions,
                    file.MinFileSize, file.MaxFileSize, file.FileLocation, file.ComponentLabel));
            }
            newForm.FileUploads = fileUploads;

            //Sets Full Name info.
            List<FullName> fullNames = new List<FullName>();
            var fullNameDTOs = form.FullNameDTOs.ToList();
            foreach (var fullName in fullNameDTOs)
            {
                fullNames.Add(new FullName(fullName.ComponentHelpText, fullName.FirstName, fullName.MiddleName, fullName.ComponentIsRequired,
                    fullName.LastName, fullName.ComponentLabel));
            }
            newForm.FullNames = fullNames;

            //Sets Heading info.
            List<Heading> headings = new List<Heading>();
            var headingDTOs = form.HeadingDTOs.ToList();
            foreach (var heading in headingDTOs)
            {
                headings.Add(new Heading(heading.HeadingText));
            }
            newForm.Headings = headings;

            //Sets Heading info.
            List<Phone> phones = new List<Phone>();
            var phoneDTOs = form.PhoneDTOs.ToList();
            foreach (var phone in phoneDTOs)
            {
                phones.Add(new Phone(phone.ComponentHelpText, phone.ComponentIsRequired, phone.PhoneAreaCdoe, phone.PhoneNumber, phone.ComponentLabel));
            }
            newForm.Phones = phones;

            //Sets radio button info.
            List<RadioButton> radioButtons = new List<RadioButton>();
            var radioButtonDTOs = form.RadioButtonDTOs.ToList();
            foreach (var radio in radioButtonDTOs)
            {
                radioButtons.Add(new RadioButton(radio.RadioButtonOptions, radio.RadioButtonSelectedOptions, radio.ComponentHelpText
                    , radio.ComponentIsRequired, radio.ComponentLabel));
            }
            newForm.RadioButtons = radioButtons;

            //Sets Text Area info.
            List<TextArea> textAreas = new List<TextArea>();
            var textAreaDTOs = form.TextAreaDTOs.ToList();
            foreach(var textArea in textAreaDTOs)
            {
                textAreas.Add(new TextArea(textArea.ComponentHelpText,textArea.TextAreaValue,textArea.ComponentIsRequired
                    ,textArea.MaxCharacter,textArea.ComponentLabel));
            }
            newForm.TextAreas = textAreas;

            //Sets Text Box info.
            List<TextBox> textBoxes = new List<TextBox>();
            var textBoxDTOs = form.TextBoxDTOs.ToList();
            foreach(var textBox in textBoxDTOs)
            {
                textBoxes.Add(new TextBox(textBox.TextBoxHint,textBox.ComponentHelpText,textBox.TextBoxValue,
                    textBox.ComponentIsRequired,textBox.MaxCharacter,textBox.ComponentLabel));
            }
            newForm.TextBoxes = textBoxes;

            //Insert new form into data base.
            Insert(newForm);
        }
    }
}
