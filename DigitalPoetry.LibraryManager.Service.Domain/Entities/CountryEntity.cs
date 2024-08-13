namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Country Entity</summary>
    public class CountryEntity
    {
        /// <summary>Country Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Country Name</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.COUNTRY_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>Country Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>District Entity Collection</summary>
        public ICollection<DistrictEntity> DistrictEntityCollection { get; set; }

        /// <summary>County Entity Collection</summary>
        public ICollection<CountyEntity> CountyEntityCollection { get; set; }

        /// <summary>Parish Entity Collection</summary>
        public ICollection<ParishEntity> ParishEntityCollection { get; set; }

        /// <summary>City Entity Collection</summary>
        public ICollection<CityEntity> CityEntityCollection { get; set; }

        /// <summary>Country Entity Constructor</summary>
        /// <param name="id">Country Identifier</param>
        /// <param name="description">Country Description</param>
        /// <param name="status">Country Status</param>
        public CountryEntity(int id, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.CreateAndValidate(description, status);
        }

        /// <summary>Country Entity Constructor</summary>
        /// <param name="description">Country Description</param>
        /// <param name="status">Country Status</param>
        public CountryEntity(string description, bool status)
        {
            this.CreateAndValidate(description, status);
        }

        /// <summary>Create and Validate Country</summary>
        /// <param name="description">Country Description</param>
        /// <param name="status">Country Status</param>
        public void CreateAndValidate(string description, bool status)
        {
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.CountryDescription, 50);
            this.Status = status;
        }

        /// <summary>Update Country</summary>
        /// <param name="description">Country Description</param>
        /// <param name="countryStatus">Country Status</param>
        public void Update(string description, bool status)
        {
            this.CreateAndValidate(description, status);
        }   
    }
}