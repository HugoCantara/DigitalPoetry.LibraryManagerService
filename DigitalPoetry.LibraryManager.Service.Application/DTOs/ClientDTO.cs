namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Messages;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Client Data Transfer Object</summary>
    public class ClientDTO
    {
        /// <summary>Primary Key Client Identifier</summary>
        [IgnoreDataMember]
        public Guid Id { get; set; }

        /// <summary>Foreign Key Client Address Identifier</summary>
        [Required]
        public Guid AddressId { get; set; }

        /// <summary>Client First Name</summary>
        [Required]
        [StringLength(50, ErrorMessage = ErrorMessageConstants.CLIENT_FIRST_NAME_LENGTH)]
        public string? FirstName { get; set; }

        /// <summary>Client Middle Name</summary>
        [Required]
        [StringLength(200, ErrorMessage = ErrorMessageConstants.CLIENT_MIDDLE_NAME_LENGTH)]
        public string? MiddleName { get; set; }

        /// <summary>Client Last Name</summary>
        [Required]
        [StringLength(50, ErrorMessage = ErrorMessageConstants.CLIENT_LAST_NAME_LENGTH)]
        public string? LastName { get; set; }

        /// <summary>Client Full Name</summary>
        [Required]
        public string FullName
        {
            get
            {
                return string.Concat(this.FirstName, " ", this.MiddleName, " ", this.LastName);
            }
        }

        /// <summary>Client Taxpayer Number</summary>
        [Required]
        [StringLength(9, ErrorMessage = ErrorMessageConstants.CLIENT_TAXPAYER_NUMBER_LENGTH)]
        public string? TaxpayerNumber { get; private set; }

        /// <summary>Client Discriminator</summary>
        [Required]
        public string Discriminator
        {
            get
            {
                return "Client";
            }
        }

        /// <summary>Client Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}