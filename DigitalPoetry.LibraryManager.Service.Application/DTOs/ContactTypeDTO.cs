namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Contact Type Data Transfer Object</summary>
    public class ContactTypeDTO
    {
        /// <summary>Primary Key Contact Type Identifier</summary>
        [IgnoreDataMember]
        public Guid Id { get; set; }

        /// <summary>Contact Type Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = ErrorMessageConstants.CONTACT_TYPE_DESCRIPTION_LENGTH)]
        public string? Description { get; set; }

        /// <summary>Contact Type Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}