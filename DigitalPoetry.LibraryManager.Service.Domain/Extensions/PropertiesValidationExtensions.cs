namespace DigitalPoetry.LibraryManager.Service.Domain.Extensions
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Exceptions;

    /// <summary>Properties Validation Extensions</summary>
    public static class PropertiesValidationExtensions
    {
        /// <summary>Validate Property</summary>
        /// <param name="value">Value</param>
        /// <param name="property">Property</param>
        /// <returns>Validated Value</returns>
        public static int ValidateProperty(this int value, IdentifierPropertyEnum property)
        {
            if (value <= 0)
            {
                throw property switch
                {
                    IdentifierPropertyEnum.AddressId => new EntitiesExceptionValidation(EntityValidationConstants.ADDRESS_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.AuthorId => new EntitiesExceptionValidation(EntityValidationConstants.AUTHOR_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.BookId => new EntitiesExceptionValidation(EntityValidationConstants.BOOK_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.CityId => new EntitiesExceptionValidation(EntityValidationConstants.CITY_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.ClientId => new EntitiesExceptionValidation(EntityValidationConstants.CLIENT_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.ContactAuthorContactTypeId => new EntitiesExceptionValidation(EntityValidationConstants.CONTACT_AUTHOR_CONTACT_TYPE_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.ContactAuthorId => new EntitiesExceptionValidation(EntityValidationConstants.CONTACT_AUTHOR_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.ContactClientContactTypeId => new EntitiesExceptionValidation(EntityValidationConstants.CONTACT_CLIENT_CONTACT_TYPE_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.ContactClientId => new EntitiesExceptionValidation(EntityValidationConstants.CONTACT_CLIENT_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.ContactTypeId => new EntitiesExceptionValidation(EntityValidationConstants.CONTACT_TYPE_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.CountryId => new EntitiesExceptionValidation(EntityValidationConstants.COUNTRY_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.CountyId => new EntitiesExceptionValidation(EntityValidationConstants.COUNTY_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.DistrictId => new EntitiesExceptionValidation(EntityValidationConstants.DISTRICT_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.LoanId => new EntitiesExceptionValidation(EntityValidationConstants.LOAN_IDENTIFIER_POSITIVE),
                    IdentifierPropertyEnum.ParishId => new EntitiesExceptionValidation(EntityValidationConstants.PARISH_IDENTIFIER_POSITIVE),
                    _ => new EntitiesExceptionValidation($"Error in property {property}.")
                };
            }

            return value;
        }

        /// <summary>Validate Property</summary>
        /// <param name="value">Value</param>
        /// <param name="property">Property</param>
        /// <param name="length">Property Length</param>
        /// <returns>Validated Value</returns>
        public static string ValidateProperty(this string value, DescriptionPropertyEnum property, int length)
        {
            if (value.Length > length)
            {
                throw property switch
                {
                    DescriptionPropertyEnum.AddressDescription => new EntitiesExceptionValidation(EntityValidationConstants.ADDRESS_DESCRIPTION_LENGTH),
                    DescriptionPropertyEnum.CityDescription => new EntitiesExceptionValidation(EntityValidationConstants.CITY_DESCRIPTION_LENGTH),
                    DescriptionPropertyEnum.ContactAuthorDescription => new EntitiesExceptionValidation(EntityValidationConstants.CONTACT_AUTHOR_DESCRIPTION_LENGTH),
                    DescriptionPropertyEnum.ContactClientDescription => new EntitiesExceptionValidation(EntityValidationConstants.CONTACT_CLIENT_DESCRIPTION_LENGTH),
                    DescriptionPropertyEnum.ContactTypeDescription => new EntitiesExceptionValidation(EntityValidationConstants.CONTACT_TYPE_DESCRIPTION_LENGTH),
                    DescriptionPropertyEnum.CountryDescription => new EntitiesExceptionValidation(EntityValidationConstants.COUNTRY_DESCRIPTION_LENGTH),
                    DescriptionPropertyEnum.CountyDescription => new EntitiesExceptionValidation(EntityValidationConstants.COUNTY_DESCRIPTION_LENGTH),
                    DescriptionPropertyEnum.DistrictDescription => new EntitiesExceptionValidation(EntityValidationConstants.DISTRICT_DESCRIPTION_LENGTH),
                    DescriptionPropertyEnum.ParishDescription => new EntitiesExceptionValidation(EntityValidationConstants.PARISH_DESCRIPTION_LENGTH),
                    _ => new EntitiesExceptionValidation($"Error in property {property}."),
                };
            }

            return value;
        }

        /// <summary>Validate Property</summary>
        /// <param name="value">Value</param>
        /// <param name="property">Property</param>
        /// <param name="length">Property Length</param>
        /// <returns>Validated Value</returns>
        public static string ValidateProperty(this string value, NamePropertyEnum property, int length)
        {
            if (value.Length > length)
            {
                throw property switch
                {
                    NamePropertyEnum.AuthorFirstName => new EntitiesExceptionValidation(EntityValidationConstants.AUTHOR_FIRST_NAME_LENGTH),
                    NamePropertyEnum.AuthorMiddleName => new EntitiesExceptionValidation(EntityValidationConstants.AUTHOR_MIDDLE_NAME_LENGTH),
                    NamePropertyEnum.AuthorLastName => new EntitiesExceptionValidation(EntityValidationConstants.AUTHOR_LAST_NAME_LENGTH),
                    NamePropertyEnum.BookName => new EntitiesExceptionValidation(EntityValidationConstants.BOOK_NAME_LENGTH),
                    NamePropertyEnum.ClientFirstName => new EntitiesExceptionValidation(EntityValidationConstants.CLIENT_FIRST_NAME_LENGTH),
                    NamePropertyEnum.ClientMiddleName => new EntitiesExceptionValidation(EntityValidationConstants.CLIENT_MIDDLE_NAME_LENGTH),
                    NamePropertyEnum.ClientLastName => new EntitiesExceptionValidation(EntityValidationConstants.CLIENT_LAST_NAME_LENGTH),
                    _ => new EntitiesExceptionValidation($"Error in property {property}."),
                };
            }

            return value;
        }

        /// <summary>Validate Property</summary>
        /// <param name="value">Value</param>
        /// <param name="property">Property</param>
        /// <returns>Validated Value</returns>
        public static string ValidateProperty(this string value, TaxpayerNumberPropertyEnum property)
        {
            if (value.Length > 9)
            {
                throw property switch
                {
                    TaxpayerNumberPropertyEnum.TaxpayerNumber => new EntitiesExceptionValidation(EntityValidationConstants.CLIENT_TAXPAYER_NUMBER_LENGTH),
                    _ => new EntitiesExceptionValidation($"Error in property {property}."),
                };
            }

            return value;
        }
    }
}