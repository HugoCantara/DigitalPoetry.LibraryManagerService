namespace DigitalPoetry.LibraryManager.Service.Domain.Extensions
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Exceptions;
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;

    /// <summary>Guid Extensions</summary>
    public static class GuidExtensions
    {
        /// <summary>Validate Property</summary>
        /// <param name="value">Value</param>
        /// <param name="property">Property</param>
        /// <returns>Validated Value</returns>
        public static Guid ValidateProperty(this Guid value, IdentifierPropertyEnum property)
        {
            if (value == null)
            {
                throw property switch
                {
                    IdentifierPropertyEnum.AddressId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.AddressId)),
                    IdentifierPropertyEnum.AuthorId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.AuthorId)),
                    IdentifierPropertyEnum.BookId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.BookId)),
                    IdentifierPropertyEnum.CityId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.CityId)),
                    IdentifierPropertyEnum.ClientId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.ClientId)),
                    IdentifierPropertyEnum.ContactAuthorContactTypeId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.ContactAuthorContactTypeId)),
                    IdentifierPropertyEnum.ContactAuthorId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.ContactAuthorId)),
                    IdentifierPropertyEnum.ContactClientContactTypeId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.ContactClientContactTypeId)),
                    IdentifierPropertyEnum.ContactClientId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.ContactClientId)),
                    IdentifierPropertyEnum.ContactTypeId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.ContactTypeId)),
                    IdentifierPropertyEnum.CountryId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.CountryId)),
                    IdentifierPropertyEnum.CountyId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.CountyId)),
                    IdentifierPropertyEnum.DistrictId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.DistrictId)),
                    IdentifierPropertyEnum.LoanId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.LoanId)),
                    IdentifierPropertyEnum.ParishId => new EntitiesExceptionValidation(CreateErrorMessage.Identifier(IdentifierPropertyEnum.ParishId)),
                    _ => new EntitiesExceptionValidation($"Error in property {property}.")
                };
            }
            return value;
        }
    }
}