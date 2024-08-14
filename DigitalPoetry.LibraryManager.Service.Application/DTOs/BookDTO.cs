namespace DigitalPoetry.LibraryManager.Service.Application.DTOs
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>Book Data Transfer Object</summary>
    public class BookDTO
    {
        /// <summary>Primary Key Book Identifier</summary>
        [IgnoreDataMember]
        public int Id { get; set; }

        /// <summary>Foreign Key Author Identifier</summary>
        [Required]
        public int AuthorId { get; set; }

        /// <summary>Book Name</summary>
        [Required]
        [StringLength(100, ErrorMessage = EntityValidationConstants.BOOK_NAME_LENGTH)]
        public string BookName { get; set; }

        /// <summary>Book Resume</summary>
        public string BookResume { get; set; }

        /// <summary>Book Publisher</summary>
        public string BookPublisher { get; set; }

        /// <summary>Book Publication Year</summary>
        public DateTime BookPublicationYear { get; set; }

        /// <summary>Book Edition</summary>
        public string BookEdition { get; set; }

        /// <summary>Book Status</summary>
        [Required]
        public bool Status { get; set; }
    }
}