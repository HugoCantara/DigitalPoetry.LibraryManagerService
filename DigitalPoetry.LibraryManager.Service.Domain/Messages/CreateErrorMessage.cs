namespace DigitalPoetry.LibraryManager.Service.Domain.Messages
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;

    /// <summary>Create Error Messages</summary>
    public static class CreateErrorMessage
    {
        /// <summary>Identifier Property Message Error</summary>
        /// <param name="property">Property</param>
        /// <returns>Message Error</returns>
        public static string Identifier(IdentifierPropertyEnum property)
        {
            string entity;

            entity = property switch
            {
                IdentifierPropertyEnum.AddressId => nameof(IdentifierPropertyEnum.AddressId),
                IdentifierPropertyEnum.AuthorId => nameof(IdentifierPropertyEnum.AuthorId),
                IdentifierPropertyEnum.BookId => nameof(IdentifierPropertyEnum.BookId),
                IdentifierPropertyEnum.CityId => nameof(IdentifierPropertyEnum.CityId),
                IdentifierPropertyEnum.ClientId => nameof(IdentifierPropertyEnum.ClientId),
                IdentifierPropertyEnum.ContactAuthorContactTypeId => nameof(IdentifierPropertyEnum.ContactAuthorContactTypeId),
                IdentifierPropertyEnum.ContactAuthorId => nameof(IdentifierPropertyEnum.ContactAuthorId),
                IdentifierPropertyEnum.ContactClientContactTypeId => nameof(IdentifierPropertyEnum.ContactClientContactTypeId),
                IdentifierPropertyEnum.ContactClientId => nameof(IdentifierPropertyEnum.ContactClientId),
                IdentifierPropertyEnum.ContactTypeId => nameof(IdentifierPropertyEnum.ContactTypeId),
                IdentifierPropertyEnum.CountryId => nameof(IdentifierPropertyEnum.CountryId),
                IdentifierPropertyEnum.CountyId => nameof(IdentifierPropertyEnum.CountyId),
                IdentifierPropertyEnum.DistrictId => nameof(IdentifierPropertyEnum.DistrictId),
                IdentifierPropertyEnum.LoanId => nameof(IdentifierPropertyEnum.LoanId),
                IdentifierPropertyEnum.ParishId => nameof(IdentifierPropertyEnum.ParishId),
                _ => "Entity identifier",
            };
            return $"{entity} cannot be null.";
        }

        /// <summary>Description Property Message Error</summary>
        /// <param name="property">Property</param>
        /// <param name="length">Length</param>
        /// <returns>Message Error</returns>
        public static string Description(DescriptionPropertyEnum property, int length)
        {
            string entity;

            entity = property switch
            {
                DescriptionPropertyEnum.AddressDescription => "Address",
                DescriptionPropertyEnum.CityDescription => "City",
                DescriptionPropertyEnum.ContactAuthorDescription => "Contact Author",
                DescriptionPropertyEnum.ContactClientDescription => "Contact Client",
                DescriptionPropertyEnum.ContactTypeDescription => "Contact Type",
                DescriptionPropertyEnum.CountryDescription => "Country",
                DescriptionPropertyEnum.CountyDescription => "County",
                DescriptionPropertyEnum.DistrictDescription => "District",
                DescriptionPropertyEnum.ParishDescription => "Parish",
                _ => "Entity"
            };
            return $"{entity} description cannot be longer than {length} characters.";
        }

        /// <summary>Name Property Message Error</summary>
        /// <param name="property">Property</param>
        /// <param name="length">Length</param>
        /// <returns>Message Error</returns>
        public static string Name(NamePropertyEnum property, int length)
        {
            string entity;

            entity = property switch
            {
                NamePropertyEnum.AuthorFirstName => "Author first",
                NamePropertyEnum.AuthorMiddleName => "Author middle",
                NamePropertyEnum.AuthorLastName => "Author last",
                NamePropertyEnum.BookName => "Book",
                NamePropertyEnum.ClientFirstName => "Client first",
                NamePropertyEnum.ClientMiddleName => "Client middle",
                NamePropertyEnum.ClientLastName => "Author last",
                _ => "Entity"
            };
            return $"{entity} name cannot be longer than {length} characters.";
        }

        /// <summary>Taxpayer Number Property Message Error</summary>
        /// <param name="property">Property</param>
        /// <param name="length">Length</param>
        /// <returns>Message Error</returns>
        public static string TaxpayerNumber(TaxpayerNumberPropertyEnum property)
        {
            string entity;

            entity = property switch
            {
                TaxpayerNumberPropertyEnum.TaxpayerNumber => "Client taxpayer number",
                _ => "Entity"
            };
            return $"{entity} cannot be longer than 9 characters.";
        }
    }
}