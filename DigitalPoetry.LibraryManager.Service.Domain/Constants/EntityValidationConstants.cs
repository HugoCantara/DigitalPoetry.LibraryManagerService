namespace DigitalPoetry.LibraryManager.Service.Domain.Constants
{
    public abstract class EntityValidationConstants
    {
        // Default Messages
        public const string IDENTIFIER_POSITIVE = "Identifier must be positive.";

        // Client Entity
        public const string CLIENT_IDENTIFIER_POSITIVE = "Client identifier must be positive.";
        public const string CLIENT_TAXPAYER_NUMBER_LENGTH = "Client taxpayer number cannot be longer than 9 characters.";
        public const string CLIENT_FIRST_NAME_LENGTH = "Client first name cannot be longer than 50 characters.";
        public const string CLIENT_MIDDLE_NAME_LENGTH = "Client middle name cannot be longer than 200 characters.";
        public const string CLIENT_LAST_NAME_LENGTH = "Client last name cannot be longer than 50 characters.";

        // Author Entity
        public const string AUTHOR_IDENTIFIER_POSITIVE = "Author identifier must be positive.";
        public const string AUTHOR_FIRST_NAME_LENGTH = "Author first name cannot be longer than 50 characters.";
        public const string AUTHOR_MIDDLE_NAME_LENGTH = "Author middle name cannot be longer than 200 characters.";
        public const string AUTHOR_LAST_NAME_LENGTH = "Author last name cannot be longer than 50 characters.";

        // Book Entity
        public const string BOOK_IDENTIFIER_POSITIVE = "Book identifier must be positive.";
        public const string BOOK_NAME_LENGTH = "Book name cannot be longer than 100 characters.";

        // Loan Entity
        public const string LOAN_IDENTIFIER_POSITIVE = "Loan identifier must be positive.";

        // Address Entity
        public const string ADDRESS_IDENTIFIER_POSITIVE = "Address identifier must be positive.";
        public const string ADDRESS_DESCRIPTION_LENGTH = "Address cannot be longer than 200 characters.";

        // Contact Client Entity
        public const string CONTACT_CLIENT_IDENTIFIER_POSITIVE = "Contact client identifier must be positive.";
        public const string CONTACT_CLIENT_DESCRIPTION_LENGTH = "Contact client cannot be longer than 100 characters.";

        // Contact Author Entity
        public const string CONTACT_AUTHOR_IDENTIFIER_POSITIVE = "Contact author identifier must be positive.";
        public const string CONTACT_AUTHOR_DESCRIPTION_LENGTH = "Contact author cannot be longer than 100 characters.";

        // Contact Client Contact Type Entity
        public const string CONTACT_CLIENT_CONTACT_TYPE_IDENTIFIER_POSITIVE = "Contact client contact type identifier must be positive.";

        // Contact Author Contact Type Entity
        public const string CONTACT_AUTHOR_CONTACT_TYPE_IDENTIFIER_POSITIVE = "Contact author contact type identifier must be positive.";

        // Contact Type Entity
        public const string CONTACT_TYPE_IDENTIFIER_POSITIVE = "Contact type identifier must be positive.";
        public const string CONTACT_TYPE_DESCRIPTION_LENGTH = "Contact type cannot be longer than 50 characters.";

        // Country Entity
        public const string COUNTRY_IDENTIFIER_POSITIVE = "Country identifier must be positive.";
        public const string COUNTRY_DESCRIPTION_LENGTH = "Country cannot be longer than 50 characters.";

        // District Entity
        public const string DISTRICT_IDENTIFIER_POSITIVE = "District identifier must be positive.";
        public const string DISTRICT_DESCRIPTION_LENGTH = "District cannot be longer than 50 characters.";

        // County Entity
        public const string COUNTY_IDENTIFIER_POSITIVE = "County identifier must be positive.";
        public const string COUNTY_DESCRIPTION_LENGTH = "County cannot be longer than 50 characters.";

        // Parish Entity
        public const string PARISH_IDENTIFIER_POSITIVE = "Parish identifier must be positive.";
        public const string PARISH_DESCRIPTION_LENGTH = "Parish cannot be longer than 50 characters.";

        // City Entity
        public const string CITY_IDENTIFIER_POSITIVE = "City identifier must be positive.";
        public const string CITY_DESCRIPTION_LENGTH = "City cannot be longer than 50 characters.";  
    }
}