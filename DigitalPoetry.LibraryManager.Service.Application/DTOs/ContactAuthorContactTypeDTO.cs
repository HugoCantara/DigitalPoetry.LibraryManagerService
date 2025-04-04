namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Contact Author Contact Type Data Transfer Object</summary>
    public class ContactAuthorContactTypeDTO
    {
        /// <summary>Primary Key Contact Author Contact Type Identifier</summary>
        [IgnoreDataMember]
        public Guid Id { get; set; }

        /// <summary>Foreign Key Contact Author Identifier</summary>
        [Required]
        public Guid ContactAuthorId { get; set; }

        /// <summary>Foreign Key Contact Type Identifier</summary>
        [Required]
        public Guid ContactTypeId { get; set; }

        /// <summary>Is Principal Contact</summary>
        [Required]
        public bool IsPrincipalContact { get; set; }

        /// <summary>Contact Author Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}