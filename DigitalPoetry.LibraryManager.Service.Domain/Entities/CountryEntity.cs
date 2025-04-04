namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>Country Entity</summary>
    public class CountryEntity
    {
        /// <summary>Primary Key Country Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Description Property</summary>
        public string Description { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>Address Entity Collection</summary>
        public ICollection<AddressEntity> AddressCollection { get; set; }

        /// <summary>District Entity Collection</summary>
        public ICollection<DistrictEntity> DistrictCollection { get; set; }

        /// <summary>County Entity Collection</summary>
        public ICollection<CountyEntity> CountyCollection { get; set; }

        /// <summary>Parish Entity Collection</summary>
        public ICollection<ParishEntity> ParishCollection { get; set; }

        /// <summary>City Entity Collection</summary>
        public ICollection<CityEntity> CityCollection { get; set; }

        /// <summary>Country Entity Constructor</summary>
        /// <param name="id">Primary Key Country Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public CountryEntity(Guid id, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.CreateAndValidate(description, status);
        }

        /// <summary>Country Entity Constructor</summary>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public CountryEntity(string description, bool status)
        {
            this.CreateAndValidate(description, status);
        }

        /// <summary>Create and Validate Country</summary>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(string description, bool status)
        {
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.CountryDescription, 50);
            this.Status = status;
        }

        /// <summary>Update Country</summary>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(string description, bool status)
        {
            this.CreateAndValidate(description, status);
        }   
    }
}