namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>County Entity</summary>
    public class CountyEntity
    {
        /// <summary>Primary Key County Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Key Country Identifier Property</summary>
        public Guid CountryId { get; private set; }

        /// <summary>Country Entity</summary>
        public CountryEntity Country { get; set; }

        /// <summary>Foreign Key District Identifier Property</summary>
        public Guid DistrictId { get; private set; }

        /// <summary>District Entity</summary>
        public DistrictEntity District { get; set; }

        /// <summary>Description Property</summary>
        public string Description { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>Address Entity Collection</summary>
        public ICollection<AddressEntity> AddressCollection { get; set; }

        /// <summary>Parish Entity Collection</summary>
        public ICollection<ParishEntity> ParishCollection { get; set; }

        /// <summary>City Entity Collection</summary>
        public ICollection<CityEntity> CityCollection { get; set; }

        /// <summary>County Entity Constructor</summary>
        /// <param name="id">Primary Key County Identifier Parameter</param>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public CountyEntity(Guid id, Guid countryId, Guid districtId, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.CountyId);
            this.CreateAndValidate(countryId, districtId, description, status);
        }

        /// <summary>County Entity Constructor</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public CountyEntity(Guid countryId, Guid districtId, string description, bool status)
        {
            this.CreateAndValidate(countryId, districtId, description, status);
        }

        /// <summary>Create and Validate County</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid countryId, Guid districtId, string description, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.DistrictId = districtId.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.CountyDescription, 50);
            this.Status = status;
        }

        /// <summary>Update County</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="districtId">Foreign Key District Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid countryId, Guid districtId, string description, bool status)
        {
            this.CreateAndValidate(countryId, districtId, description, status);
        }  
    }
}