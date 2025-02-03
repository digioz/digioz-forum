using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace digioz.Forum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddForumData6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var profileFields = new[]
            {
                // Location
                new
                {
                    Name = "Forumlocation",
                    Type = "profilefields.type.string",
                    Ident = "Forumlocation",
                    Length = "20",
                    Minlen = "2",
                    Maxlen = "100",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = ".*",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 1,
                    IsContact = false,
                    ContactDesc = "",
                    ContactUrl = ""
                },

                // Website
                new
                {
                    Name = "Forumwebsite",
                    Type = "profilefields.type.url",
                    Ident = "Forumwebsite",
                    Length = "40",
                    Minlen = "12",
                    Maxlen = "255",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 2,
                    IsContact = true,
                    ContactDesc = "VISIT_WEBSITE",
                    ContactUrl = "%s"
                },

                // Interests
                new
                {
                    Name = "Foruminterests",
                    Type = "profilefields.type.text",
                    Ident = "Foruminterests",
                    Length = "3|30",
                    Minlen = "2",
                    Maxlen = "500",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = ".*",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = false,
                    ShowOnVt = false,
                    ShowOnMl = false,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = false,
                    Order = 3,
                    IsContact = false,
                    ContactDesc = "",
                    ContactUrl = ""
                },

                // Occupation
                new
                {
                    Name = "Forumoccupation",
                    Type = "profilefields.type.text",
                    Ident = "Forumoccupation",
                    Length = "3|30",
                    Minlen = "2",
                    Maxlen = "500",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = ".*",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = false,
                    ShowOnVt = false,
                    ShowOnMl = false,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = false,
                    Order = 4,
                    IsContact = false,
                    ContactDesc = "",
                    ContactUrl = ""
                },

                // ICQ
                new
                {
                    Name = "Forumicq",
                    Type = "profilefields.type.string",
                    Ident = "Forumicq",
                    Length = "20",
                    Minlen = "3",
                    Maxlen = "15",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "[0-9]+",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = false,
                    Order = 6,
                    IsContact = true,
                    ContactDesc = "SEND_ICQ_MESSAGE",
                    ContactUrl = "https://www.icq.com/people/%s/"
                },

                // Yahoo
                new
                {
                    Name = "Forumyahoo",
                    Type = "profilefields.type.string",
                    Ident = "Forumyahoo",
                    Length = "40",
                    Minlen = "5",
                    Maxlen = "255",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = ".*",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = false,
                    Order = 8,
                    IsContact = true,
                    ContactDesc = "SEND_YIM_MESSAGE",
                    ContactUrl = "ymsgr:sendim?%s"
                },

                // Facebook
                new
                {
                    Name = "Forumfacebook",
                    Type = "profilefields.type.string",
                    Ident = "Forumfacebook",
                    Length = "20",
                    Minlen = "5",
                    Maxlen = "50",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "[\\w.]+",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 9,
                    IsContact = true,
                    ContactDesc = "VIEW_FACEBOOK_PROFILE",
                    ContactUrl = "https://facebook.com/%s/"
                },

                // Twitter
                new
                {
                    Name = "Forumtwitter",
                    Type = "profilefields.type.string",
                    Ident = "Forumtwitter",
                    Length = "20",
                    Minlen = "1",
                    Maxlen = "15",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "[\\w_]+",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 10,
                    IsContact = true,
                    ContactDesc = "VIEW_TWITTER_PROFILE",
                    ContactUrl = "https://twitter.com/%s"
                },

                // Skype
                new
                {
                    Name = "Forumskype",
                    Type = "profilefields.type.string",
                    Ident = "Forumskype",
                    Length = "20",
                    Minlen = "6",
                    Maxlen = "32",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "[a-zA-Z][\\w\\.,\\-_]+",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 11,
                    IsContact = true,
                    ContactDesc = "VIEW_SKYPE_PROFILE",
                    ContactUrl = "skype:%s?userinfo"
                },

                // YouTube
                new
                {
                    Name = "Forumyoutube",
                    Type = "profilefields.type.string",
                    Ident = "Forumyoutube",
                    Length = "20",
                    Minlen = "3",
                    Maxlen = "60",
                    Novalue = "",
                    DefaultValue = "",
                    Validation = "(@[a-zA-Z0-9_.-]{3,30}|c/[a-zA-Z][\\w\\.,\\-_]+|(channel|user)/[a-zA-Z][\\w\\.,\\-_]+)",
                    Required = false,
                    ShowNovalue = false,
                    ShowOnReg = false,
                    ShowOnPm = true,
                    ShowOnVt = true,
                    ShowOnMl = true,
                    ShowProfile = true,
                    Hide = false,
                    NoView = false,
                    Active = true,
                    Order = 12,
                    IsContact = true,
                    ContactDesc = "VIEW_YOUTUBE_PROFILE",
                    ContactUrl = "https://youtube.com/%s"
                }
            };

            foreach (var field in profileFields)
            {
                migrationBuilder.InsertData(
                    table: "ForumProfileField",
                    columnTypes: new[]
                    {
                        "varchar(255)", // FieldName
                        "varchar(100)", // FieldType
                        "varchar(20)",  // FieldIdent
                        "varchar(20)",  // FieldLength
                        "varchar(255)", // FieldMinlen
                        "varchar(255)", // FieldMaxlen
                        "varchar(255)", // FieldNovalue
                        "varchar(255)", // FieldDefaultValue
                        "varchar(128)", // FieldValidation
                        "tinyint",      // FieldRequired
                        "tinyint",      // FieldShowNovalue
                        "tinyint",      // FieldShowOnReg
                        "tinyint",      // FieldShowOnPm
                        "tinyint",      // FieldShowOnVt
                        "tinyint",      // FieldShowOnMl
                        "tinyint",      // FieldShowProfile
                        "tinyint",      // FieldHide
                        "tinyint",      // FieldNoView
                        "tinyint",      // FieldActive
                        "bigint",       // FieldOrder
                        "tinyint",      // FieldIsContact
                        "varchar(255)", // FieldContactDesc
                        "varchar(255)"  // FieldContactUrl
                    },
                    columns: new[]
                    {
                    "FieldName", "FieldType", "FieldIdent", "FieldLength",
                    "FieldMinlen", "FieldMaxlen", "FieldNovalue", "FieldDefaultValue",
                    "FieldValidation", "FieldRequired", "FieldShowNovalue",
                    "FieldShowOnReg", "FieldShowOnPm", "FieldShowOnVt",
                    "FieldShowOnMl", "FieldShowProfile", "FieldHide",
                    "FieldNoView", "FieldActive", "FieldOrder",
                    "FieldIsContact", "FieldContactDesc", "FieldContactUrl"
                    },
                    values: new object[]
                    {
                        field.Name, field.Type, field.Ident, field.Length,
                        field.Minlen, field.Maxlen, field.Novalue, field.DefaultValue,
                        field.Validation, field.Required ? 1 : 0, field.ShowNovalue ? 1 : 0,
                        field.ShowOnReg ? 1 : 0, field.ShowOnPm ? 1 : 0, field.ShowOnVt ? 1 : 0,
                        field.ShowOnMl ? 1 : 0, field.ShowProfile ? 1 : 0, field.Hide ? 1 : 0,
                        field.NoView ? 1 : 0, field.Active ? 1 : 0, field.Order,
                        field.IsContact ? 1 : 0, field.ContactDesc, field.ContactUrl
                    });
            }
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM ForumProfileField WHERE FieldOrder BETWEEN 1 AND 12");
        }
    }
}
