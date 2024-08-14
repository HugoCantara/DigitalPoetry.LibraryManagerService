namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Country Data Transfer Object</summary>
    public class CountryDTO
    {
        /// <summary>Primary Key Country Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Country Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.COUNTRY_DESCRIPTION_LENGTH)]
        public string Description { get; set; }

        /// <summary>Country Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}