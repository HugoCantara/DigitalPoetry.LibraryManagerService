namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>Address Entity</summary>
    public class AddressEntity
    {
        /// <summary>Primary Key Address Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Key Country Identifier Property</summary>
        public Guid CountryId { get; private set; }

        /// <summary>Country Entity</summary>
        public CountryEntity Country { get; set; }

        /// <summary>Foreign Key District Identifier Property</summary>
        public Guid DistrictId { get; private set; }

        /// <summary>District Entity</summary>
        public DistrictEntity District { get; set; }

        /// <summary>Foreign Key County Identifier Property</summary>
        public Guid CountyId { get; private set; }

        /// <summary>County Entity</summary>
        public CountyEntity County { get; set; }

        /// <summary>Foreign Key Parish Identifier Property</summary>
        public Guid ParishId { get; private set; }

        /// <summary>Parish Entity</summary>
        public ParishEntity Parish { get; set; }

        /// <summary>Foreign Key City Identifier Property</summary>
        public Guid CityId { get; private set; }

        /// <summary>City Entity</summary>
        public CityEntity City { get; set; }

        /// <summary>Description Property</summary>
        public string Description { get; private set; }

        /// <summary>IsPrincipalAddress Property</summary>
        public bool IsPrincipalAddress { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>Client Entity Collection</summary>
        public ICollection<ClientEntity> ClientCollection { get; set; }

        /// <summary>Author Entity Collection</summary>
        public ICollection<AuthorEntity> AuthorCollection { get; set; }

        /// <summary>Address Entity Constructor</summary>
        /// <param name="id">Primary Key Address Identifier Parameter</param>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="countyId">Foreign Key County Identifier Parameter</param>
        /// <param name="parishId">Foreign Key Parish Identifier Parameter</param>
        /// <param name="cityId">Foreign Key City Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="isPrincipalAddress">IsPrincipalAddress Parameter</param>
        /// <param name="status">Status Parameter</param>
        public AddressEntity(Guid id, Guid countryId, Guid districtId, Guid countyId, Guid parishId, Guid cityId, string description, bool isPrincipalAddress, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.AddressId);
            this.CreateAndValidate(countryId, districtId, countyId, parishId, cityId, description, isPrincipalAddress, status);
        }

        /// <summary>Address Entity Constructor</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="countyId">Foreign Key County Identifier Parameter</param>
        /// <param name="parishId">Foreign Key Parish Identifier Parameter</param>
        /// <param name="cityId">Foreign Key City Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="isPrincipalAddress">IsPrincipalAddress Parameter</param>
        /// <param name="status">Status Parameter</param>
        public AddressEntity(Guid countryId, Guid districtId, Guid countyId, Guid parishId, Guid cityId, string description, bool isPrincipalAddress, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, parishId, cityId, description, isPrincipalAddress, status);
        }

        /// <summary>Create and Validate Address</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="countyId">Foreign Key County Identifier Parameter</param>
        /// <param name="parishId">Foreign Key Parish Identifier Parameter</param>
        /// <param name="cityId">Foreign Key City Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="isPrincipalAddress">IsPrincipalAddress Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid countryId, Guid districtId, Guid countyId, Guid parishId, Guid cityId, string description, bool isPrincipalAddress, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.DistrictId = districtId.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.CountyId = countyId.ValidateProperty(IdentifierPropertyEnum.CountyId);
            this.ParishId = parishId.ValidateProperty(IdentifierPropertyEnum.ParishId);
            this.CityId = cityId.ValidateProperty(IdentifierPropertyEnum.CityId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.AddressDescription, 200);
            this.IsPrincipalAddress = isPrincipalAddress;
            this.Status = status;
        }

        /// <summary>Update Address</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="countyId">Foreign Key County Identifier Parameter</param>
        /// <param name="parishId">Foreign Key Parish Identifier Parameter</param>
        /// <param name="cityId">Foreign Key City Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="isPrincipalAddress">IsPrincipalAddress Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid countryId, Guid districtId, Guid countyId, Guid parishId, Guid cityId, string description, bool isPrincipalAddress, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, parishId, cityId, description, isPrincipalAddress, status);
        }  
    }
}