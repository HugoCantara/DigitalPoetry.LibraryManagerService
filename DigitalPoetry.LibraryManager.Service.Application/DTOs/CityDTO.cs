namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>City Data Transfer Object</summary>
    public class CityDTO
    {
        /// <summary>Primary Key City Identifier</summary>
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

        /// <summary>Foreign Key Parish Identifier</summary>
        [Required]
        public Guid ParishId { get; set; }

        /// <summary>Parish Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = ErrorMessageConstants.CITY_DESCRIPTION_LENGTH)]
        public string? Description { get; set; }

        /// <summary>Parish Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}