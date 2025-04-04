namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>District Entity</summary>
    public class DistrictEntity
    {
        /// <summary>Primary Key District Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Key Country Identifier Property</summary>
        public Guid CountryId { get; private set; }

        /// <summary>Country Entity</summary>
        public CountryEntity Country { get; set; }

        /// <summary>Description Property</summary>
        public string Description { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>Address Entity Collection</summary>
        public ICollection<AddressEntity> AddressCollection { get; set; }

        /// <summary>County Entity Collection</summary>
        public ICollection<CountyEntity> CountyCollection { get; set; }

        /// <summary>Parish Entity Collection</summary>
        public ICollection<ParishEntity> ParishCollection { get; set; }

        /// <summary>City Entity Collection</summary>
        public ICollection<CityEntity> CityCollection { get; set; }

        /// <summary>District Entity Constructor</summary>
        /// <param name="id">Primary Key District Identifier Parameter</param>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public DistrictEntity(Guid id, Guid countryId, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.CreateAndValidate(countryId, description, status);
        }

        /// <summary>District Entity Constructor</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public DistrictEntity(Guid countryId, string description, bool status)
        {
            this.CreateAndValidate(countryId, description, status);
        }

        /// <summary>Create and Validate District</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid countryId, string description, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.DistrictDescription, 50);
            this.Status = status;
        }

        /// <summary>Update District</summary>
        /// <param name="countryId">Foreign Key Country Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid countryId, string description, bool status)
        {
            this.CreateAndValidate(countryId, description, status);
        }
    }
}