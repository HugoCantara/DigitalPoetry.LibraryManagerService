namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>District Data Transfer Object</summary>
    public class DistrictDTO
    {
        /// <summary>Primary Key District Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Foreign Key Country Identifier</summary>
        [Required]
        public int CountryId { get; set; }

        /// <summary>District Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.DISTRICT_DESCRIPTION_LENGTH)]
        public string Description { get; set; }

        /// <summary>District Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}