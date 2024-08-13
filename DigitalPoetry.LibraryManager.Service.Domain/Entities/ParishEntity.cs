namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Parish Entity Class</summary>
    public class ParishEntity
    {
        /// <summary>Parish Identifier</summary>
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

        /// <summary>County Identifier</summary>
        [Required]
        [Column("CountyId")]
        public int CountyId { get; private set; }

        /// <summary>County Entity</summary>
        public CountyEntity County { get; set; }

        /// <summary>Parish Name</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.PARISH_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>Parish Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>City Entity Collection</summary>
        public ICollection<CityEntity> CityEntityCollection { get; set; }

        /// <summary>Parish Entity Constructor</summary>
        /// <param name="id">Parish Identifier</param>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="description">Parish Description</param>
        /// <param name="status">Parish Status</param>
        public ParishEntity(int id, int countryId, int districtId, int countyId, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ParishId);
            this.CreateAndValidate(countryId, districtId, countyId, description, status);
        }

        /// <summary>Parish Entity Constructor</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="description">Parish Description</param>
        /// <param name="status">Parish Status</param>
        public ParishEntity(int countryId, int districtId, int countyId, string description, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, description, status);
        }

        /// <summary>Create and Validate Parish</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="description">Parish Description</param>
        /// <param name="status">Parish Status</param>
        public void CreateAndValidate(int countryId, int districtId, int countyId, string description, bool status)
        {
            this.CountryId = countryId.ValidateProperty(IdentifierPropertyEnum.CountryId);
            this.DistrictId = districtId.ValidateProperty(IdentifierPropertyEnum.DistrictId);
            this.CountyId = countyId.ValidateProperty(IdentifierPropertyEnum.CountyId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.ParishDescription, 50);
            this.Status = status;
        }

        /// <summary>Update Parish</summary>
        /// <param name="countryId">Country Identifier</param>
        /// <param name="districtId">District Identifier</param>
        /// <param name="countyId">County Identifier</param>
        /// <param name="description">Parish Description</param>
        /// <param name="status">Parish Status</param>
        public void Update(int countryId, int districtId, int countyId, string description, bool status)
        {
            this.CreateAndValidate(countryId, districtId, countyId, description, status);
        }  
    }
}