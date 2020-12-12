using Common.DTOs;
using DataLayer.Context;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Common.DTOs.ComponentDTOs;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repositories.FormGettingValue
{
    class GettingValueRepository : Repository<Form>, IGettingValueRepository
    {
        public GettingValueRepository(FromDataBase dataBase):base(dataBase)
        {

        }
        public FormDTOCollection GetFormsInfo()
        {
            FormDTOCollection dtoCollection = new FormDTOCollection();
            var Res = Get().ToList();
            foreach(var value in Res)
            {
                FormDTO dto = new FormDTO();

                //retrieving data from Address Component.
                List<AddressDTO> addressDTOs = new List<AddressDTO>();
                var addresses = value.Addresses.ToList();
                foreach(var address in addresses)
                {
                    addressDTOs.Add(new AddressDTO()
                    {
                        BaseComponentID=address.ComponentID,
                        ComponentHelpText=address.HelpText,
                        ComponentIsRequired=address.IsRequired,
                        ComponentLabel=address.ComponentLabel,
                        City = address.City,
                        Countries = address.AddressCountryDropDown,
                        ProvinceOrState = address.ProviceOrState,
                        StreetAddress1 = address.StreetAddress1,
                        StreetAddress2 = address.StreetAddress2,
                        ZipCode = address.ZipCode
                    });
                }
                dto.AddressDTOs = addressDTOs;

                //retrieving data from Birth Day Picker Component.
                List<BirthDayPickerDTO> birthDayPickerDTOs = new List<BirthDayPickerDTO>();
                var birthdays = value.BirthDayPickers.ToList();
                foreach(var birthday in birthdays)
                {
                    birthDayPickerDTOs.Add(new BirthDayPickerDTO()
                    {
                        BaseComponentID=birthday.ComponentID,
                        ComponentLabel=birthday.ComponentLabel,
                        ComponentIsRequired=birthday.BirthDayPickerIsRequired,
                        ComponentHelpText=birthday.BirthDayPickerHelpText,
                        Day=birthday.Day,
                        MaxAge=birthday.MaximumAge,
                        MinAge=birthday.MinimumAge,
                        Month=birthday.Month,
                        Year=birthday.Year
                    });
                }
                dto.BirthDayPickerDTOs = birthDayPickerDTOs;

                //retrieving data from Check Box Component.
                List<CheckBoxDTO> checkBoxDTOs = new List<CheckBoxDTO>();
                var checkBoxes = value.CheckBoxes.ToList();
                foreach(var checkbox in checkBoxes)
                {
                    checkBoxDTOs.Add(new CheckBoxDTO()
                    {
                        BaseComponentID = checkbox.ComponentID,
                        CheckBoxOptions = checkbox.CheckBoxOptions,
                        CheckBoxSelectedOptions = checkbox.CheckBoxSelectedOptions,
                        ComponentHelpText = checkbox.CheckBoxHelpText,
                        ComponentIsRequired = checkbox.IsRequiredCheckBox,
                        ComponentLabel = checkbox.ComponentLabel
                    });
                }
                dto.CheckBoxDTOs = checkBoxDTOs;

                //retrieving data from Drop Down component.
                List<DropDownDTO> dropDownDTOs = new List<DropDownDTO>();
                var dropDowns = value.DropDowns.ToList();
                foreach(var dropDown in dropDowns)
                {
                    dropDownDTOs.Add(new DropDownDTO()
                    {
                        BaseComponentID=dropDown.ComponentID,
                        ComponentHelpText=dropDown.DropDownHelpText,
                        ComponentIsRequired=dropDown.IsRequiredDropDown,
                        ComponentLabel=dropDown.ComponentLabel,
                        DropDwonOptions=dropDown.DropDownOptions,
                        SelectedOptions=dropDown.DropDownSelectedOptions
                    });
                }
                dto.DropDownDTOs = dropDownDTOs;

                //retrieving data from Full Name Component.
                List<FullNameDTO> fullNameDTOs = new List<FullNameDTO>();
                var fullNames = value.FullNames.ToList();
                foreach(var fullName in fullNames)
                {
                    fullNameDTOs.Add(new FullNameDTO()
                    {
                        BaseComponentID = fullName.ComponentID,
                        ComponentHelpText = fullName.FullNameHelpText,
                        ComponentIsRequired = fullName.FullNameIsRequired,
                        ComponentLabel=fullName.ComponentLabel,
                        FirstName=fullName.FullNameFirstNamePart,
                        LastName=fullName.FullNameLastNamePart,
                        MiddleName=fullName.FullNameMiddleNamePart
                    });
                }
                dto.FullNameDTOs = fullNameDTOs;

                //retrieving data from Phone Component
                List<PhoneDTO> phoneDTOs = new List<PhoneDTO>();
                var phones = value.Phones.ToList();
                foreach(var phone in phones)
                {
                    phoneDTOs.Add(new PhoneDTO()
                    {
                        BaseComponentID = phone.ComponentID,
                        ComponentHelpText = phone.PhoneHelpText,
                        ComponentIsRequired = phone.PhoneIsRequired,
                        ComponentLabel = phone.ComponentLabel,
                        PhoneAreaCdoe = phone.PhoneAreaCode,
                        PhoneNumber = phone.PhoneNumber
                    });
                }
                dto.PhoneDTOs = phoneDTOs;

                //retrieving data from Email Component.
                List<EmailDTO> emailDTOs = new List<EmailDTO>();
                var emails = value.Emails.ToList();
                foreach(var email in emails)
                {
                    emailDTOs.Add(new EmailDTO()
                    {
                        BaseComponentID = email.ComponentID,
                        ComponentHelpText = email.EmailHelpText,
                        ComponentIsRequired = email.EmailIsRequired,
                        ComponentLabel = email.ComponentLabel,
                        EmailMaxCharacter = email.EmailMaxCharacter,
                        EmailValue = email.EmailText
                    });
                }
                dto.EmailDTOs = emailDTOs;

                //retrieving data from File Uplaod Component.
                List<FileUploadDTO> fileUploadDTOs = new List<FileUploadDTO>();
                var fileUploads = value.FileUploads.ToList();
                foreach(var fileUpload in fileUploads)
                {
                    fileUploadDTOs.Add(new FileUploadDTO()
                    {
                        BaseComponentID = fileUpload.ComponentID,
                        ComponentHelpText = fileUpload.FileUploadHelpText,
                        ComponentIsRequired = fileUpload.FileUploadIsRequired,
                        ComponentLabel = fileUpload.ComponentLabel,
                        FileLocation = fileUpload.FileLocation,
                        MaxFileSize = fileUpload.MaxFileSize,
                        MinFileSize = fileUpload.MinFileSize,
                        ValidExtensions = fileUpload.ValidExtensions
                    });
                }
                dto.FileUploadDTOs = fileUploadDTOs;

                //retrieving data from Heading Component
                List<HeadingDTO> headingDTOs = new List<HeadingDTO>();
                var headings = value.Headings.ToList();
                foreach(var heading in headings)
                {
                    headingDTOs.Add(new HeadingDTO()
                    {
                        HeadingID = heading.ComponentID,
                        HeadingText = heading.HeadingText
                    });
                }
                dto.HeadingDTOs = headingDTOs;

                //retrieving data from radio button component.
                List<RadioButtonDTO> radioButtonDTOs = new List<RadioButtonDTO>();
                var radioButtons = value.RadioButtons.ToList();
                foreach(var radioButton in radioButtonDTOs)
                {
                    radioButtonDTOs.Add(new RadioButtonDTO()
                    {
                        BaseComponentID = radioButton.BaseComponentID,
                        ComponentHelpText = radioButton.ComponentHelpText,
                        ComponentIsRequired = radioButton.ComponentIsRequired,
                        ComponentLabel = radioButton.ComponentLabel,
                        RadioButtonOptions = radioButton.RadioButtonOptions,
                        RadioButtonSelectedOptions = radioButton.RadioButtonSelectedOptions,
                        TextBoxIsRequired = radioButton.TextBoxIsRequired
                    });
                }
                dto.RadioButtonDTOs = radioButtonDTOs;

                //retrieving data from Text Area Component.
                List<TextAreaDTO> textAreaDTOs = new List<TextAreaDTO>();
                var textAreas = value.TextAreas.ToList();
                foreach(var textArea in textAreas)
                {
                    textAreaDTOs.Add(new TextAreaDTO()
                    {
                        BaseComponentID=textArea.ComponentID,
                        ComponentHelpText=textArea.TextAreaHelpText,
                        ComponentIsRequired=textArea.TextAreaIsRequired,
                        ComponentLabel=textArea.ComponentLabel,
                        MaxCharacter=textArea.TextAreaMaxCharacter,
                        TextAreaValue=textArea.TextAreaText
                    });
                }
                dto.TextAreaDTOs = textAreaDTOs;

                //retrieving data from Text Box Component. 
                List<TextBoxDTO> textBoxDTOs = new List<TextBoxDTO>();
                var textBoxes = value.TextBoxes.ToList();
                foreach(var textBox in textBoxes)
                {
                    textBoxDTOs.Add(new TextBoxDTO()
                    {
                        BaseComponentID = textBox.ComponentID,
                        ComponentHelpText = textBox.TextBoxHelpText,
                        ComponentIsRequired = textBox.TextBoxIsRequired,
                        ComponentLabel = textBox.ComponentLabel,
                        MaxCharacter = textBox.TextBoxMaxCharacter,
                        TextBoxHint = textBox.TextBoxHint,
                        TextBoxValue = textBox.TextBoxText
                    });
                }
                dto.TextBoxDTOs = textBoxDTOs;


                dtoCollection.FormCollectionDTOs.Add(dto);
            }
            return dtoCollection;
        }
    }
}
