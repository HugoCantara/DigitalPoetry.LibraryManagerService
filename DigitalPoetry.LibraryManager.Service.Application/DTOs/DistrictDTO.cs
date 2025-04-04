namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>District Data Transfer Object</summary>
    public class DistrictDTO
    {
        /// <summary>Primary Key District Identifier</summary>
        [IgnoreDataMember]
        public Guid Id { get; set; }

        /// <summary>Foreign Key Country Identifier</summary>
        [Required]
        public Guid CountryId { get; set; }

        /// <summary>District Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = ErrorMessageConstants.DISTRICT_DESCRIPTION_LENGTH)]
        public string? Description { get; set; }

        /// <summary>District Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}