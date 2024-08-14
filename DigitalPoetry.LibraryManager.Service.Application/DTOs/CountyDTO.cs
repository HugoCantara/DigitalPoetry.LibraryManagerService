namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>County Data Transfer Object</summary>
    public class CountyDTO
    {
        /// <summary>Primary Key County Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Foreign Key Country Identifier</summary>
        [Required]
        public int CountryId { get; set; }

        /// <summary>Foreign Key District Identifier</summary>
        [Required]
        public int DistrictId { get; set; }

        /// <summary>County Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.COUNTY_DESCRIPTION_LENGTH)]
        public string Description { get; set; }

        /// <summary>County Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}