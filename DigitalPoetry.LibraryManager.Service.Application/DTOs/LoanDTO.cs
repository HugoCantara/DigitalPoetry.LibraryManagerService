namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Loan Data Transfer Object</summary>
    public class LoanDTO
    {
        /// <summary>Primary Key Loan Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Foreign Key Client Identifier</summary>
        [Required]
        public int ClientId { get; set; }

        /// <summary>Foreign Key Book Identifier</summary>
        [Required]
        public int BookId { get; set; }

        /// <summary>Loan Date</summary>
        [Required]
        public DateTime LoanDate { get; set; }

        /// <summary>Delivery Date</summary>
        [Required]
        public DateTime DeliveryDate { get; set; }

        /// <summary>Is Delivered</summary>
        [Required]
        public bool IsDelivered { get; set; }

        /// <summary>Loan Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}