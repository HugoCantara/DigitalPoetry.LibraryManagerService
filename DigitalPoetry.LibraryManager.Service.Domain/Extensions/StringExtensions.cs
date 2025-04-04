namespace DigitalPoetry.LibraryManager.Service.Domain.Extensions
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Exceptions;
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;

    /// <summary>String Extensions</summary>
    public static class StringExtensions
    {
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
                    DescriptionPropertyEnum.AddressDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.AddressDescription, length)),
                    DescriptionPropertyEnum.CityDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.CityDescription, length)),
                    DescriptionPropertyEnum.ContactAuthorDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.ContactAuthorDescription, length)),
                    DescriptionPropertyEnum.ContactClientDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.ContactClientDescription, length)),
                    DescriptionPropertyEnum.ContactTypeDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.ContactTypeDescription, length)),
                    DescriptionPropertyEnum.CountryDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.CountryDescription, length)),
                    DescriptionPropertyEnum.CountyDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.CountyDescription, length)),
                    DescriptionPropertyEnum.DistrictDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.DistrictDescription, length)),
                    DescriptionPropertyEnum.ParishDescription => new EntitiesExceptionValidation(CreateErrorMessage.Description(DescriptionPropertyEnum.ParishDescription, length)),
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
        public static string ValidateProperty(this string value, NamePropertyEnum property, int length)
        {
            if (value.Length > length)
            {
                throw property switch
                {
                    NamePropertyEnum.AuthorFirstName => new EntitiesExceptionValidation(CreateErrorMessage.Name(NamePropertyEnum.AuthorFirstName, length)),
                    NamePropertyEnum.AuthorMiddleName => new EntitiesExceptionValidation(CreateErrorMessage.Name(NamePropertyEnum.AuthorMiddleName, length)),
                    NamePropertyEnum.AuthorLastName => new EntitiesExceptionValidation(CreateErrorMessage.Name(NamePropertyEnum.AuthorLastName, length)),
                    NamePropertyEnum.BookName => new EntitiesExceptionValidation(CreateErrorMessage.Name(NamePropertyEnum.BookName, length)),
                    NamePropertyEnum.ClientFirstName => new EntitiesExceptionValidation(CreateErrorMessage.Name(NamePropertyEnum.ClientFirstName, length)),
                    NamePropertyEnum.ClientMiddleName => new EntitiesExceptionValidation(CreateErrorMessage.Name(NamePropertyEnum.ClientMiddleName, length)),
                    NamePropertyEnum.ClientLastName => new EntitiesExceptionValidation(CreateErrorMessage.Name(NamePropertyEnum.ClientLastName, length)),
                    _ => new EntitiesExceptionValidation($"Error in property {property}.")
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
                    TaxpayerNumberPropertyEnum.TaxpayerNumber => new EntitiesExceptionValidation(CreateErrorMessage.TaxpayerNumber(TaxpayerNumberPropertyEnum.TaxpayerNumber)),
                    _ => new EntitiesExceptionValidation($"Error in property {property}."),
                };
            }
            return value;
        }
    }
}