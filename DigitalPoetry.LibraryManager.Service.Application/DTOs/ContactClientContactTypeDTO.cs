namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Contact Client Contact Type Data Transfer Object</summary>
    public class ContactClientContactTypeDTO
    {
        /// <summary>Primary Key Contact Client Contact Type Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Foreign Key Contact Client Identifier</summary>
        [Required]
        public int ContactClientId { get; set; }

        /// <summary>Foreign Key Contact Type Identifier</summary>
        [Required]
        public int ContactTypeId { get; set; }

        /// <summary>Is Principal Contact</summary>
        [Required]
        public bool IsPrincipalContact { get; set; }

        /// <summary>Contact Client Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}