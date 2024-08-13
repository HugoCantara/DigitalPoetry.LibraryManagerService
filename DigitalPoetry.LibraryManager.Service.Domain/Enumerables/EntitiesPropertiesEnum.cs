namespace DigitalPoetry.LibraryManager.Service.Domain.Enumerables
{
    /// <summary>Entities that contains Identifier property</summary>
    public enum IdentifierPropertyEnum
    {
        AddressId, 
        AuthorId, 
        BookId, 
        CityId, 
        ClientId, 
        ContactAuthorContactTypeId, 
        ContactAuthorId, 
        ContactClientContactTypeId, 
        ContactClientId, 
        ContactTypeId, 
        CountryId, 
        CountyId, 
        DistrictId, 
        LoanId, 
        ParishId
    }

    /// <summary>Entities that contains Description property</summary>
    public enum DescriptionPropertyEnum
    {
        AddressDescription, 
        CityDescription, 
        ContactAuthorDescription, 
        ContactClientDescription, 
        ContactTypeDescription, 
        CountryDescription, 
        CountyDescription, 
        DistrictDescription, 
        ParishDescription
    }

    /// <summary>Entities that contains Name property</summary>
    public enum NamePropertyEnum
    {
        AuthorFirstName, 
        AuthorMiddleName, 
        AuthorLastName, 
        ClientFirstName, 
        ClientMiddleName, 
        ClientLastName, 
        BookName
    }

    /// <summary>Entities that contains Taxpayer Number property</summary>
    public enum TaxpayerNumberPropertyEnum
    {
        TaxpayerNumber
    }
}
