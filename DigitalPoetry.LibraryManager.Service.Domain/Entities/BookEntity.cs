namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>Book Entity</summary>
    public class BookEntity
    {
        /// <summary>Primary Key Book Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Key Author Identifier Property</summary>
        public Guid AuthorId { get; private set; }

        /// <summary>Author Entity</summary>
        public AuthorEntity Author { get; set; }

        /// <summary>Book Name Property</summary>
        public string BookName { get; private set; }

        /// <summary>Book Resume Property</summary>
        public string BookResume { get; private set; }

        /// <summary>Book Publisher Property</summary>
        public string BookPublisher { get; private set; }

        /// <summary>Publication Year Property</summary>
        public DateTime BookPublicationYear { get; private set; }

        /// <summary>Book Edition Property</summary>
        public string BookEdition { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>Loan Entity Collection</summary>
        public ICollection<LoanEntity> LoanCollection { get; set; }

        /// <summary>Book Entity Constructor</summary>
        /// <param name="id">Primary Key Book Identifier Parameter</param>
        /// <param name="authorId">Foreign Key Author Identifier Parameter</param>
        /// <param name="bookName">Book Name Parameter</param>
        /// <param name="bookResume">Book Resume Parameter</param>
        /// <param name="bookPublisher">Book Publisher Parameter</param>
        /// <param name="bookPublicationYear">Book Publication Year Parameter</param>
        /// <param name="bookEdition">Book Edition Parameter</param>
        /// <param name="status">Status Parameter</param>
        public BookEntity(Guid id, Guid authorId, string bookName, string bookResume, string bookPublisher, DateTime bookPublicationYear, string bookEdition, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.BookId);
            this.CreateAndValidate(authorId, bookName, bookResume, bookPublisher, bookPublicationYear, bookEdition, status);
        }

        /// <summary>Book Entity Constructor</summary>
        /// <param name="authorId">Foreign Key Author Identifier Parameter</param>
        /// <param name="bookName">Book Name Parameter</param>
        /// <param name="bookResume">Book Resume Parameter</param>
        /// <param name="bookPublisher">Book Publisher Parameter</param>
        /// <param name="bookPublicationYear">Book Publication Year Parameter</param>
        /// <param name="bookEdition">Book Edition Parameter</param>
        /// <param name="status">Status Parameter</param>
        public BookEntity(Guid authorId, string bookName, string bookResume, string bookPublisher, DateTime bookPublicationYear, string bookEdition, bool status)
        {
            this.CreateAndValidate(authorId, bookName, bookResume, bookPublisher, bookPublicationYear, bookEdition, status);
        }

        /// <summary>Create and Validate Book</summary>
        /// <param name="authorId">Foreign Key Author Identifier Parameter</param>
        /// <param name="bookName">Book Name Parameter</param>
        /// <param name="bookResume">Book Resume Parameter</param>
        /// <param name="bookPublisher">Book Publisher Parameter</param>
        /// <param name="bookPublicationYear">Book Publication Year Parameter</param>
        /// <param name="bookEdition">Book Edition Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid authorId, string bookName, string bookResume, string bookPublisher, DateTime bookPublicationYear, string bookEdition, bool status)
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
        /// <param name="authorId">Foreign Key Author Identifier Parameter</param>
        /// <param name="bookName">Book Name Parameter</param>
        /// <param name="bookResume">Book Resume Parameter</param>
        /// <param name="bookPublisher">Book Publisher Parameter</param>
        /// <param name="bookPublicationYear">Book Publication Year Parameter</param>
        /// <param name="bookEdition">Book Edition Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid authorId, string bookName, string bookResume, string bookPublisher, DateTime bookPublicationYear, string bookEdition, bool status)
        {
            this.CreateAndValidate(authorId, bookName, bookResume, bookPublisher, bookPublicationYear, bookEdition, status);
        }  
    }
}