namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Author Data Transfer Object</summary>
    public class AuthorDTO
    {
        /// <summary>Primary Key Author Identifier</summary>
        [IgnoreDataMember]
        public Guid Id { get; set; }

        /// <summary>Foreign Key Author Address Identifier</summary>
        [Required]
        public Guid AddressId { get; set; }

        /// <summary>Author First Name</summary>
        [Required]
        [StringLength(50, ErrorMessage = ErrorMessageConstants.AUTHOR_FIRST_NAME_LENGTH)]
        public string? FirstName { get; set; }

        /// <summary>Author Middle Name</summary>
        [Required]
        [StringLength(200, ErrorMessage = ErrorMessageConstants.AUTHOR_MIDDLE_NAME_LENGTH)]
        public string? MiddleName { get; set; }

        /// <summary>Author Last Name</summary>
        [Required]
        [StringLength(50, ErrorMessage = ErrorMessageConstants.AUTHOR_LAST_NAME_LENGTH)]
        public string? LastName { get; set; }

        /// <summary>Author Full Name</summary>
        [Required]
        public string FullName
        {
            get
            {
                return string.Concat(this.FirstName, " ", this.MiddleName, " ", this.LastName);
            }
        }

        /// <summary>Author Discriminator</summary>
        [Required]
        public static string? Discriminator
        {
            get
            {
                return "Author";
            }
        }

        /// <summary>Author Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}