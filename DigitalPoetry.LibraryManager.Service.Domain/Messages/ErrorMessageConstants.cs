namespace DigitalPoetry.LibraryManager.Service.Domain.Messages
{
    /// <summary>Error Messages Constants</summary>
    public abstract class ErrorMessageConstants
    {
        // Description Property
        public const string ADDRESS_DESCRIPTION_LENGTH = "Address description cannot be longer than 200 characters.";
        public const string CITY_DESCRIPTION_LENGTH = "City description cannot be longer than 50 characters.";
        public const string CONTACT_AUTHOR_DESCRIPTION_LENGTH = "Contact Author description cannot be longer than 50 characters.";
        public const string CONTACT_CLIENT_DESCRIPTION_LENGTH = "Contact Client description cannot be longer than 50 characters.";
        public const string CONTACT_TYPE_DESCRIPTION_LENGTH = "Contact type description cannot be longer than 50 characters.";
        public const string COUNTRY_DESCRIPTION_LENGTH = "Country description cannot be longer than 50 characters.";
        public const string COUNTY_DESCRIPTION_LENGTH = "County description cannot be longer than 50 characters.";
        public const string DISTRICT_DESCRIPTION_LENGTH = "District description cannot be longer than 50 characters.";
        public const string PARISH_DESCRIPTION_LENGTH = "Parish description cannot be longer than 50 characters.";

        // Name Property
        public const string AUTHOR_FIRST_NAME_LENGTH = "Author first name cannot be longer than 50 characters.";
        public const string AUTHOR_MIDDLE_NAME_LENGTH = "Author middle name cannot be longer than 200 characters.";
        public const string AUTHOR_LAST_NAME_LENGTH = "Author last name cannot be longer than 50 characters.";
        public const string BOOK_NAME_LENGTH = "Book name cannot be longer than 100 characters.";
        public const string CLIENT_FIRST_NAME_LENGTH = "Client first name cannot be longer than 50 characters.";
        public const string CLIENT_MIDDLE_NAME_LENGTH = "Client middle name cannot be longer than 200 characters.";
        public const string CLIENT_LAST_NAME_LENGTH = "Client last name cannot be longer than 50 characters.";

        // Taxpayer Number Property
        public const string CLIENT_TAXPAYER_NUMBER_LENGTH = "Client taxpayer number cannot be longer than 9 characters.";
    }
}