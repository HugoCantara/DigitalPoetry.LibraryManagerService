namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Contact Author Data Transfer Object</summary>
    public class ContactAuthorDTO
    {
        /// <summary>Primary Key Contact Author Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Foreign Key Author Identifier</summary>
        [Required]
        public int AuthorId { get; set; }

        /// <summary>Contact Author Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.CONTACT_AUTHOR_DESCRIPTION_LENGTH)]
        public string Description { get; private set; }
    }
}