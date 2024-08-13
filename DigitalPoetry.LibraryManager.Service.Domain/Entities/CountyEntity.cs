namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>County Entity</summary>
    public class CountyEntity
    {
        /// <summary>County Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Country Identifier</summary>
        [Required]
        [Column("CountryId")]
        public int CountryId { get; private set; }

        /// <summary>Country Entity</summary>
        public CountryEntity Country { get; set; }

        /// <summary>District Identifier</summary>
        [Required]
        [Column("DistrictId")]
        public int DistrictId { get; private set; }

        /// <summary>District Entity</summary>
        public DistrictEntity District { get; set; }

        /// <summary>County Name</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.COUNTY_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>County Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>Parish Entity Collection</summary>
        public ICollection<ParishEntity> ParishEntityCollection { get; set; }

        /// <summary>City Entity Collection</summary>
        public ICollection<CityEntity> CityEntityCollection { get; set; }

        /// <summary>County Entity Constructor</summary>
        /// <param name="id">County Identifier</param>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="description">County Description</param>
        /// <param name="status">County Status</param>
        public CountyEntity(int id, int countryId, int districtId, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.CountyId);
            this.CreateAndValidate(countryId, districtId, description, status);
        }

        /// <summary>County Entity Constructor</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="description">County Description</param>
        /// <param name="status">County Status</param>
        public CountyEntity(int countryId, int districtId, string description, bool status)
        {
            this.CreateAndValidate(countryId, districtId, description, status);
        }

        /// <summary>Create and Validate County</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="description">County Description</param>
        /// <param name="status">County Status</param>
        public void CreateAndValidate(int countryId, int districtId, string description, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.DistrictId = districtId.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.CountyDescription, 50);
            this.Status = status;
        }

        /// <summary>Update County</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="description">County Description</param>
        /// <param name="status">County Status</param>
        public void Update(int countryId, int districtId, string description, bool status)
        {
            this.CreateAndValidate(countryId, districtId, description, status);
        }  
    }
}