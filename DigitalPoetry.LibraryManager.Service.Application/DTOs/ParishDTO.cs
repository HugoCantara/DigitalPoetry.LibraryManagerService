namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Parish Data Transfer Object</summary>
    public class ParishDTO
    {
        /// <summary>Primary Key Parish Identifier</summary>
        [IgnoreDataMember]
        public Guid Id { get; set; }

        /// <summary>Foreign Key Country Identifier</summary>
        [Required]
        public Guid CountryId { get; set; }

        /// <summary>Foreign Key District Identifier</summary>
        [Required]
        public Guid DistrictId { get; set; }

        /// <summary>Foreign Key County Identifier</summary>
        [Required]
        public Guid CountyId { get; set; }

        /// <summary>Parish Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = ErrorMessageConstants.PARISH_DESCRIPTION_LENGTH)]
        public string? Description { get; set; }

        /// <summary>Parish Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}