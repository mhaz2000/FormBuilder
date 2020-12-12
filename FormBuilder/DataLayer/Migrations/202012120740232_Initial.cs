namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BaseComponents",
                c => new
                    {
                        ComponentID = c.Guid(nullable: false),
                        ComponentLabel = c.String(),
                        IsRequired = c.Boolean(),
                        HelpText = c.String(),
                        StreetAddress1 = c.String(),
                        StreetAddress2 = c.String(),
                        City = c.String(),
                        ProviceOrState = c.String(),
                        ZipCode = c.String(),
                        AddressCountryDropDown = c.Int(),
                        BirthDayPickerHelpText = c.String(),
                        BirthDayPickerIsRequired = c.Boolean(),
                        MinimumAge = c.Int(),
                        MaximumAge = c.Int(),
                        Month = c.Int(),
                        Year = c.Int(),
                        Day = c.Int(),
                        EmailHelpText = c.String(),
                        EmailIsRequired = c.Boolean(),
                        EmailText = c.String(),
                        EmailMaxCharacter = c.Int(),
                        FileUploadHelpText = c.String(),
                        FileUploadIsRequired = c.Boolean(),
                        MinFileSize = c.Int(),
                        MaxFileSize = c.Int(),
                        FileLocation = c.String(),
                        FullNameHelpText = c.String(),
                        FullNameFirstNamePart = c.String(),
                        FullNameMiddleNamePart = c.String(),
                        FullNameIsRequired = c.Boolean(),
                        FullNameLastNamePart = c.String(),
                        PhoneHelpText = c.String(),
                        PhoneIsRequired = c.Boolean(),
                        PhoneAreaCode = c.String(),
                        PhoneNumber = c.String(),
                        CheckBoxSelectedOptions = c.String(),
                        CheckBoxHelpText = c.String(),
                        IsRequiredCheckBox = c.Boolean(),
                        DropDownLabel = c.String(),
                        DropDownSelectedOptions = c.String(),
                        DropDownHelpText = c.String(),
                        IsRequiredDropDown = c.Boolean(),
                        HeadingText = c.String(),
                        RadioBoxSelectedOptions = c.String(),
                        RadioBoxHelpBox = c.String(),
                        RadioBoxIsRequired = c.Boolean(),
                        TextAreaHelpText = c.String(),
                        TextAreaText = c.String(),
                        TextAreaIsRequired = c.Boolean(),
                        TextAreaMaxCharacter = c.Int(),
                        TextBoxHint = c.String(),
                        TextBoxHelpText = c.String(),
                        TextBoxText = c.String(),
                        TextBoxIsRequired = c.Boolean(),
                        TextBoxMaxCharacter = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Form_FormID = c.Guid(),
                        Form_FormID1 = c.Guid(),
                        Form_FormID2 = c.Guid(),
                        Form_FormID3 = c.Guid(),
                        Form_FormID4 = c.Guid(),
                        Form_FormID5 = c.Guid(),
                        Form_FormID6 = c.Guid(),
                        Form_FormID7 = c.Guid(),
                        Form_FormID8 = c.Guid(),
                        Form_FormID9 = c.Guid(),
                        Form_FormID10 = c.Guid(),
                        Form_FormID11 = c.Guid(),
                    })
                .PrimaryKey(t => t.ComponentID)
                .ForeignKey("dbo.Forms", t => t.Form_FormID)
                .ForeignKey("dbo.Forms", t => t.Form_FormID1)
                .ForeignKey("dbo.Forms", t => t.Form_FormID2)
                .ForeignKey("dbo.Forms", t => t.Form_FormID3)
                .ForeignKey("dbo.Forms", t => t.Form_FormID4)
                .ForeignKey("dbo.Forms", t => t.Form_FormID5)
                .ForeignKey("dbo.Forms", t => t.Form_FormID6)
                .ForeignKey("dbo.Forms", t => t.Form_FormID7)
                .ForeignKey("dbo.Forms", t => t.Form_FormID8)
                .ForeignKey("dbo.Forms", t => t.Form_FormID9)
                .ForeignKey("dbo.Forms", t => t.Form_FormID10)
                .ForeignKey("dbo.Forms", t => t.Form_FormID11)
                .Index(t => t.Form_FormID)
                .Index(t => t.Form_FormID1)
                .Index(t => t.Form_FormID2)
                .Index(t => t.Form_FormID3)
                .Index(t => t.Form_FormID4)
                .Index(t => t.Form_FormID5)
                .Index(t => t.Form_FormID6)
                .Index(t => t.Form_FormID7)
                .Index(t => t.Form_FormID8)
                .Index(t => t.Form_FormID9)
                .Index(t => t.Form_FormID10)
                .Index(t => t.Form_FormID11);
            
            CreateTable(
                "dbo.Forms",
                c => new
                    {
                        FormID = c.Guid(nullable: false),
                        FormName = c.String(),
                    })
                .PrimaryKey(t => t.FormID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BaseComponents", "Form_FormID11", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID10", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID9", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID8", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID7", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID6", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID5", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID4", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID3", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID2", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID1", "dbo.Forms");
            DropForeignKey("dbo.BaseComponents", "Form_FormID", "dbo.Forms");
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID11" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID10" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID9" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID8" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID7" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID6" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID5" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID4" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID3" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID2" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID1" });
            DropIndex("dbo.BaseComponents", new[] { "Form_FormID" });
            DropTable("dbo.Forms");
            DropTable("dbo.BaseComponents");
        }
    }
}
