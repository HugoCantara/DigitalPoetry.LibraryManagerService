namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>City Entity</summary>
    public class CityEntity
    {
        /// <summary>Primary Key City Identifier Property</summary>
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

        /// <summary>Description Property</summary>
        public string Description { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>Address Entity Collection</summary>
        public ICollection<AddressEntity> AddressEntityCollection { get; set; }

        /// <summary>City Entity Constructor</summary>
        /// <param name="id">Primary Key City Identifier Parameter</param>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="countyId">Foreign Key County Identifier Parameter</param>
        /// <param name="parishId">Foreign Key Parish Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public CityEntity(Guid id, Guid countryId, Guid districtId, Guid countyId, Guid parishId, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.CityId);
            this.CreateAndValidate(countryId, districtId, countyId, parishId, description, status);
        }

        /// <summary>City Entity Constructor</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="countyId">Foreign Key County Identifier Parameter</param>
        /// <param name="parishId">Foreign Key Parish Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public CityEntity(Guid countryId, Guid districtId, Guid countyId, Guid parishId, string description, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, parishId, description, status);
        }

        /// <summary>Create and Validate City</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="countyId">Foreign Key County Identifier Parameter</param>
        /// <param name="parishId">Foreign Key Parish Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid countryId, Guid districtId, Guid countyId, Guid parishId, string description, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.DistrictId = districtId.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.CountyId = countyId.ValidateProperty(IdentifierPropertyEnum.CountyId);
            this.ParishId = parishId.ValidateProperty(IdentifierPropertyEnum.ParishId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.CityDescription, 50);
            this.Status = status;
        }

        /// <summary>Update City</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="countyId">Foreign Key County Identifier Parameter</param>
        /// <param name="parishId">Foreign Key Parish Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid countryId, Guid districtId, Guid countyId, Guid parishId, string description, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, parishId, description, status);
        }  
    }
}