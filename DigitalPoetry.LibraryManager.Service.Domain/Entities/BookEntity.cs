namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Book Entity</summary>
    public class BookEntity
    {
        /// <summary>Book Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Author Identifier</summary>
        [Required]
        [Column("AuthorId")]
        public int AuthorId { get; private set; }

        /// <summary>Author Entity</summary>
        public AuthorEntity Author { get; set; }

        /// <summary>Book Name</summary>
        [Required]
        [StringLength(100, ErrorMessage = EntityValidationConstants.BOOK_NAME_LENGTH)]
        [Column("BookName")]
        public string BookName { get; private set; }

        /// <summary>Book Resume</summary>
        [Column("BookResume")]
        public string BookResume { get; private set; }

        /// <summary>Book Publisher</summary>
        [Column("BookPublisher")]
        public string BookPublisher { get; private set; }

        /// <summary>Book Publication Year</summary>
        [Column("BookPublicationYear")]
        public DateTime BookPublicationYear { get; private set; }

        /// <summary>Book Edition</summary>
        [Column("BookEdition")]
        public string BookEdition { get; private set; }

        /// <summary>Book Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>Loan Entity Collection</summary>
        public ICollection<LoanEntity> LoanEntityCollection { get; set; }

        /// <summary>Book Entity Constructor</summary>
        /// <param name="id">Book Identifier</param>
        /// <param name="authorId">Author Identifier</param>
        /// <param name="bookName">Book Name</param>
        /// <param name="bookResume">Book Resume</param>
        /// <param name="bookPublisher">Book Publisher</param>
        /// <param name="bookPublicationYear">Book Publication Year</param>
        /// <param name="bookEdition">Book Edition</param>
        /// <param name="status">Book Status</param>
        public BookEntity(int id, int authorId, string bookName, string bookResume, string bookPublisher, DateTime bookPublicationYear, string bookEdition, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.BookId);
            this.CreateAndValidate(authorId, bookName, bookResume, bookPublisher, bookPublicationYear, bookEdition, status);
        }

        /// <summary>Book Entity Constructor</summary>
        /// <param name="authorId">Author Identifier</param>
        /// <param name="bookName">Book Name</param>
        /// <param name="bookResume">Book Resume</param>
        /// <param name="bookPublisher">Book Publisher</param>
        /// <param name="bookPublicationYear">Book Publication Year</param>
        /// <param name="bookEdition">Book Edition</param>
        /// <param name="status">Book Status</param>
        public BookEntity(int authorId, string bookName, string bookResume, string bookPublisher, DateTime bookPublicationYear, string bookEdition, bool status)
        {
            this.CreateAndValidate(authorId, bookName, bookResume, bookPublisher, bookPublicationYear, bookEdition, status);
        }

        /// <summary>Create and Validate Book</summary>
        /// <param name="authorId">Author Identifier</param>
        /// <param name="bookName">Book Name</param>
        /// <param name="bookResume">Book Resume</param>
        /// <param name="bookPublisher">Book Publisher</param>
        /// <param name="bookPublicationYear">Book Publication Year</param>
        /// <param name="bookEdition">Book Edition</param>
        /// <param name="status">Book Status</param>
        public void CreateAndValidate(int authorId, string bookName, string bookResume, string bookPublisher, DateTime bookPublicationYear, string bookEdition, bool status)
        {
            this.AuthorId = authorId.ValidateProperty(IdentifierPropertyEnum.AuthorId);
            this.BookName = bookName.ValidateProperty(NamePropertyEnum.BookName, 100);
            this.BookResume = bookResume;
            this.BookPublisher = bookPublisher;
            this.BookPublicationYear = bookPublicationYear;
            this.BookEdition = bookEdition;
            this.Status = status;
        }

        /// <summary>Update Book</summary>
        /// <param name="authorId">Author Identifier</param>
        /// <param name="bookName">Book Name</param>
        /// <param name="bookResume">Book Resume</param>
        /// <param name="bookPublisher">Book Publisher</param>
        /// <param name="bookPublicationYear">Book Publication Year</param>
        /// <param name="bookEdition">Book Edition</param>
        /// <param name="status">Book Status</param>
        public void Update(int authorId, string bookName, string bookResume, string bookPublisher, DateTime bookPublicationYear, string bookEdition, bool status)
        {
            this.CreateAndValidate(authorId, bookName, bookResume, bookPublisher, bookPublicationYear, bookEdition, status);
        }  
    }
}