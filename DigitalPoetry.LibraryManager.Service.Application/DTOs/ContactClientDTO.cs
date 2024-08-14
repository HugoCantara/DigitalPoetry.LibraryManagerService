namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Contact Client Data Transfer Object</summary>
    public class ContactClientDTO
    {
        /// <summary>Primary Key Contact Client Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Foreign Key Client Identifier</summary>
        [Required]
        public int ClientId { get; set; }

        /// <summary>Contact Client Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.CONTACT_CLIENT_DESCRIPTION_LENGTH)]
        public string Description { get; set; }
    }
}