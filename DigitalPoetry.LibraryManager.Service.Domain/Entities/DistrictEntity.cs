namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>District Entity</summary>
    public class DistrictEntity
    {
        /// <summary>District Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Country Identifier</summary>
        [Required]
        [Column("CountryId")]
        public int CountryId { get; private set; }

        /// <summary>Country Entity</summary>
        public CountryEntity Country { get; set; }

        /// <summary>District Name</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.DISTRICT_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>District Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>County Entity Collection</summary>
        public ICollection<CountyEntity> CountyEntityCollection { get; set; }

        /// <summary>Parish Entity Collection</summary>
        public ICollection<ParishEntity> ParishEntityCollection { get; set; }

        /// <summary>City Entity Collection</summary>
        public ICollection<CityEntity> CityEntityCollection { get; set; }

        /// <summary>District Entity Constructor</summary>
        /// <param name="id">District Identifier</param>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="description">District Description</param>
        /// <param name="status">District Status</param>
        public DistrictEntity(int id, int countryId, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.CreateAndValidate(countryId, description, status);
        }

        /// <summary>District Entity Constructor</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="description">District Description</param>
        /// <param name="status">District Status</param>
        public DistrictEntity(int countryId, string description, bool status)
        {
            this.CreateAndValidate(countryId, description, status);
        }

        /// <summary>Create and Validate District</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="description">District Description</param>
        /// <param name="status">District Status</param>
        public void CreateAndValidate(int countryId, string description, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.DistrictDescription, 50);
            this.Status = status;
        }

        /// <summary>Update District</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="description">District Description</param>
        /// <param name="status">District Status</param>
        public void Update(int countryId, string description, bool status)
        {
            this.CreateAndValidate(countryId, description, status);
        }
    }
}