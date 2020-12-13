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
        public GettingValueRepository(FormDataBase dataBase) : base(dataBase)
        {

        }

        public FormDTO GetFormInfoById(Guid id)
        {
            var result = GetByID(id);
            FormDTO form = new FormDTO();

            //Transfers data from address entity to address dto
            List<AddressDTO> addressDTOs = new List<AddressDTO>();
            foreach (var index in result.Addresses)
            {
                addressDTOs.Add(new AddressDTO()
                {
                    BaseComponentID = index.ComponentID,
                    City = index.City,
                    ComponentHelpText = index.HelpText,
                    ComponentIsRequired = index.IsRequired,
                    ComponentLabel = index.ComponentLabel,
                    Countries = index.AddressCountryDropDown,
                    ProvinceOrState = index.ProviceOrState,
                    StreetAddress1 = index.StreetAddress1,
                    StreetAddress2 = index.StreetAddress2,
                    ZipCode = index.ZipCode
                });
            }
            form.AddressDTOs = addressDTOs;

            //Transfers data from birth date picker entity to birth date picker dto
            List<BirthDayPickerDTO> birthDayPickerDTOs = new List<BirthDayPickerDTO>();
            foreach (var index in result.BirthDayPickers)
            {
                birthDayPickerDTOs.Add(new BirthDayPickerDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentHelpText=index.BirthDayPickerHelpText,
                    ComponentIsRequired=index.BirthDayPickerIsRequired,
                    ComponentLabel=index.ComponentLabel,
                    Day=index.Day,
                    MaxAge=index.MaximumAge,
                    MinAge=index.MinimumAge,
                    Month=index.Month,
                    Year=index.Year
                });
            }
            form.BirthDayPickerDTOs = birthDayPickerDTOs;

            //Transfers data from check box entity to check box dto
            List<CheckBoxDTO> checkBoxDTOs = new List<CheckBoxDTO>();
            foreach (var index in result.CheckBoxes)
            {
                checkBoxDTOs.Add(new CheckBoxDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentLabel = index.ComponentLabel,
                    CheckBoxOptions=index.CheckBoxOptions,
                    CheckBoxSelectedOptions=index.CheckBoxSelectedOptions,
                    ComponentHelpText=index.CheckBoxHelpText,
                    ComponentIsRequired=index.IsRequiredCheckBox
                });
            }
            form.CheckBoxDTOs = checkBoxDTOs;

            //Transfers data from drop down entity to drop down dto
            List<DropDownDTO> dropDownDTOs = new List<DropDownDTO>();
            foreach (var index in result.DropDowns)
            {
                dropDownDTOs.Add(new DropDownDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentLabel = index.ComponentLabel,
                    ComponentHelpText=index.DropDownHelpText,
                    ComponentIsRequired=index.IsRequiredDropDown,
                    DropDownOptions=index.DropDownOptions,
                    SelectedOptions=index.DropDownSelectedOptions
                });
            }
            form.DropDownDTOs = dropDownDTOs;

            //Transfers data from email entity to email dto
            List<EmailDTO> emailDTOs = new List<EmailDTO>();
            foreach (var index in result.Emails)
            {
                emailDTOs.Add(new EmailDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentLabel = index.ComponentLabel,
                    ComponentHelpText=index.EmailHelpText,
                    ComponentIsRequired=index.EmailIsRequired,
                    EmailMaxCharacter=index.EmailMaxCharacter,
                    EmailValue=index.EmailText
                });
            }
            form.EmailDTOs = emailDTOs;

            //Transfers data from file upload entity to file upload dto
            List<FileUploadDTO> fileUploadDTOs = new List<FileUploadDTO>();
            foreach (var index in result.FileUploads)
            {
                fileUploadDTOs.Add(new FileUploadDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentLabel = index.ComponentLabel,
                    ComponentIsRequired=index.FileUploadIsRequired,
                    ComponentHelpText=index.FileUploadHelpText,
                    FileLocation=index.FileLocation,
                    MaxFileSize=index.MaxFileSize,
                    MinFileSize=index.MinFileSize,
                    ValidExtensions=index.ValidExtensions
                });
            }
            form.FileUploadDTOs= fileUploadDTOs;

            //Transfers data from full name entity to full name dto
            List<FullNameDTO> fullNameDTOs = new List<FullNameDTO>();
            foreach (var index in result.FullNames)
            {
                fullNameDTOs.Add(new FullNameDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentLabel = index.ComponentLabel,
                    ComponentHelpText=index.FullNameHelpText,
                    ComponentIsRequired=index.FullNameIsRequired,
                    FirstName=index.FullNameFirstNamePart,
                    LastName=index.FullNameLastNamePart,
                    MiddleName=index.FullNameMiddleNamePart
                });
            }
            form.FullNameDTOs = fullNameDTOs;

            //Transfers data from heading entity to heading dto
            List<HeadingDTO> headingDTOs = new List<HeadingDTO>();
            foreach (var index in result.Headings)
            {
                headingDTOs.Add(new HeadingDTO()
                {
                    HeadingText=index.HeadingText,
                    HeadingID=index.ComponentID
                });
            }
            form.HeadingDTOs = headingDTOs;

            //Transfers data from phone entity to phone dto
            List<PhoneDTO> phoneDTOs = new List<PhoneDTO>();
            foreach (var index in result.Phones)
            {
                phoneDTOs.Add(new PhoneDTO()
                {
                    BaseComponentID=index.ComponentID,
                    ComponentHelpText=index.PhoneHelpText,
                    ComponentIsRequired=index.PhoneIsRequired,
                    ComponentLabel=index.ComponentLabel,
                    PhoneAreaCdoe=index.PhoneAreaCode,
                    PhoneNumber=index.PhoneNumber
                });
            }
            form.PhoneDTOs = phoneDTOs;

            //Transfers data from radio button entity to radio button dto
            List<RadioButtonDTO> radioButtonDTOs = new List<RadioButtonDTO>();
            foreach (var index in result.RadioButtons)
            {
                radioButtonDTOs.Add(new RadioButtonDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentLabel = index.ComponentLabel,
                    ComponentHelpText=index.RadioBoxHelpBox,
                    ComponentIsRequired=index.RadioBoxIsRequired,
                    RadioButtonOptions=index.RadioBoxOptions,
                    RadioButtonSelectedOptions=index.RadioBoxSelectedOptions,
                });
            }
            form.RadioButtonDTOs = radioButtonDTOs;

            //Transfers data from text area entity to text area dto
            List<TextAreaDTO> textAreaDTOs = new List<TextAreaDTO>();
            foreach (var index in result.TextAreas)
            {
                textAreaDTOs.Add(new TextAreaDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentLabel = index.ComponentLabel,
                    ComponentHelpText=index.TextAreaHelpText,
                    ComponentIsRequired=index.TextAreaIsRequired,
                    MaxCharacter=index.TextAreaMaxCharacter,
                    TextAreaValue=index.TextAreaText
                });
            }
            form.TextAreaDTOs = textAreaDTOs;

            //Transfers data text box entity to text box dto
            List<TextBoxDTO> textBoxDTOs = new List<TextBoxDTO>();
            foreach (var index in result.TextBoxes)
            {
                textBoxDTOs.Add(new TextBoxDTO()
                {
                    BaseComponentID = index.ComponentID,
                    ComponentLabel = index.ComponentLabel,
                    ComponentHelpText=index.TextBoxHelpText,
                    ComponentIsRequired=index.TextBoxIsRequired,
                    MaxCharacter=index.TextBoxMaxCharacter,
                    TextBoxHint=index.TextBoxHint,
                    TextBoxValue=index.TextBoxText
                });
            }
            form.TextBoxDTOs = textBoxDTOs;

            return form;
        }






        public FormDTOCollection GetFormsInfo()
        {
            FormDTOCollection dtoCollection = new FormDTOCollection();
            var Res = Get().ToList();
            foreach (var value in Res)
            {
                FormDTO dto = new FormDTO();

                //retrieving data from Address Component.
                List<AddressDTO> addressDTOs = new List<AddressDTO>();
                var addresses = value.Addresses.ToList();
                foreach (var address in addresses)
                {
                    addressDTOs.Add(new AddressDTO()
                    {
                        BaseComponentID = address.ComponentID,
                        ComponentHelpText = address.HelpText,
                        ComponentIsRequired = address.IsRequired,
                        ComponentLabel = address.ComponentLabel,
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
                foreach (var birthday in birthdays)
                {
                    birthDayPickerDTOs.Add(new BirthDayPickerDTO()
                    {
                        BaseComponentID = birthday.ComponentID,
                        ComponentLabel = birthday.ComponentLabel,
                        ComponentIsRequired = birthday.BirthDayPickerIsRequired,
                        ComponentHelpText = birthday.BirthDayPickerHelpText,
                        Day = birthday.Day,
                        MaxAge = birthday.MaximumAge,
                        MinAge = birthday.MinimumAge,
                        Month = birthday.Month,
                        Year = birthday.Year
                    });
                }
                dto.BirthDayPickerDTOs = birthDayPickerDTOs;

                //retrieving data from Check Box Component.
                List<CheckBoxDTO> checkBoxDTOs = new List<CheckBoxDTO>();
                var checkBoxes = value.CheckBoxes.ToList();
                foreach (var checkbox in checkBoxes)
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
                foreach (var dropDown in dropDowns)
                {
                    dropDownDTOs.Add(new DropDownDTO()
                    {
                        BaseComponentID = dropDown.ComponentID,
                        ComponentHelpText = dropDown.DropDownHelpText,
                        ComponentIsRequired = dropDown.IsRequiredDropDown,
                        ComponentLabel = dropDown.ComponentLabel,
                        DropDownOptions = dropDown.DropDownOptions,
                        SelectedOptions = dropDown.DropDownSelectedOptions
                    });
                }
                dto.DropDownDTOs = dropDownDTOs;

                //retrieving data from Full Name Component.
                List<FullNameDTO> fullNameDTOs = new List<FullNameDTO>();
                var fullNames = value.FullNames.ToList();
                foreach (var fullName in fullNames)
                {
                    fullNameDTOs.Add(new FullNameDTO()
                    {
                        BaseComponentID = fullName.ComponentID,
                        ComponentHelpText = fullName.FullNameHelpText,
                        ComponentIsRequired = fullName.FullNameIsRequired,
                        ComponentLabel = fullName.ComponentLabel,
                        FirstName = fullName.FullNameFirstNamePart,
                        LastName = fullName.FullNameLastNamePart,
                        MiddleName = fullName.FullNameMiddleNamePart
                    });
                }
                dto.FullNameDTOs = fullNameDTOs;

                //retrieving data from Phone Component
                List<PhoneDTO> phoneDTOs = new List<PhoneDTO>();
                var phones = value.Phones.ToList();
                foreach (var phone in phones)
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
                foreach (var email in emails)
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
                foreach (var fileUpload in fileUploads)
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
                foreach (var heading in headings)
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
                foreach (var radioButton in radioButtonDTOs)
                {
                    radioButtonDTOs.Add(new RadioButtonDTO()
                    {
                        BaseComponentID = radioButton.BaseComponentID,
                        ComponentHelpText = radioButton.ComponentHelpText,
                        ComponentIsRequired = radioButton.ComponentIsRequired,
                        ComponentLabel = radioButton.ComponentLabel,
                        RadioButtonOptions = radioButton.RadioButtonOptions,
                        RadioButtonSelectedOptions = radioButton.RadioButtonSelectedOptions,
                    });
                }
                dto.RadioButtonDTOs = radioButtonDTOs;

                //retrieving data from Text Area Component.
                List<TextAreaDTO> textAreaDTOs = new List<TextAreaDTO>();
                var textAreas = value.TextAreas.ToList();
                foreach (var textArea in textAreas)
                {
                    textAreaDTOs.Add(new TextAreaDTO()
                    {
                        BaseComponentID = textArea.ComponentID,
                        ComponentHelpText = textArea.TextAreaHelpText,
                        ComponentIsRequired = textArea.TextAreaIsRequired,
                        ComponentLabel = textArea.ComponentLabel,
                        MaxCharacter = textArea.TextAreaMaxCharacter,
                        TextAreaValue = textArea.TextAreaText
                    });
                }
                dto.TextAreaDTOs = textAreaDTOs;

                //retrieving data from Text Box Component. 
                List<TextBoxDTO> textBoxDTOs = new List<TextBoxDTO>();
                var textBoxes = value.TextBoxes.ToList();
                foreach (var textBox in textBoxes)
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
