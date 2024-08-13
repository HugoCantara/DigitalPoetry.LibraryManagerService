namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Loan Entity</summary>
    public class LoanEntity
    {
        /// <summary>Loan Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Client Identifier</summary>
        [Required]
        [Column("ClientId")]
        public int ClientId { get; private set; }

        /// <summary>Client Entity</summary>
        public ClientEntity Client { get; set; }

        /// <summary>Book Identifier</summary>
        [Required]
        [Column("BookId")]
        public int BookId { get; private set; }

        /// <summary>Book Entity</summary>
        public BookEntity Book { get; set; }

        /// <summary>Loan Date</summary>
        [Required]
        [Column("LoanDate")]
        public DateTime LoanDate { get; private set; }

        /// <summary>Delivery Date</summary>
        [Required]
        [Column("DeliveryDate")]
        public DateTime DeliveryDate { get; private set; }

        /// <summary>Is Delivered</summary>
        [Required]
        [Column("IsDelivered")]
        public bool IsDelivered { get; private set; }

        /// <summary>Loan Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>Loan Entity Constructor</summary>
        /// <param name="id">Loan Identifier</param>
        /// <param name="clientId">Client Identifier</param>
        /// <param name="bookId">Book Identifier</param>
        /// <param name="loanDate">Loan Date</param>
        /// <param name="deliveryDate">Delivery Date</param>
        /// <param name="isDelivered">Book Is Delivered</param>
        /// <param name="status">Loan Status</param>
        public LoanEntity(int id, int clientId, int bookId, DateTime loanDate, DateTime deliveryDate, bool isDelivered, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.LoanId);
            this.CreateAndValidate(clientId, bookId, loanDate, deliveryDate, isDelivered, status);
        }

        /// <summary>Loan Entity Constructor</summary>
        /// <param name="clientId">Client Identifier</param>
        /// <param name="bookId">Book Identifier</param>
        /// <param name="loanDate">Loan Date</param>
        /// <param name="deliveryDate">Delivery Date</param>
        /// <param name="isDelivered">Book Is Delivered</param>
        /// <param name="status">Loan Status</param>
        public LoanEntity(int clientId, int bookId, DateTime loanDate, DateTime deliveryDate, bool isDelivered, bool status)
        {
            this.CreateAndValidate(clientId, bookId, loanDate, deliveryDate, isDelivered, status);
        }

        /// <summary>Create and Validate Loan</summary>
        /// <param name="clientId"></param>
        /// <param name="bookId"></param>
        /// <param name="loanDate"></param>
        /// <param name="deliveryDate"></param>
        /// <param name="isDelivered"></param>
        /// <param name="status"></param>
        public void CreateAndValidate(int clientId, int bookId, DateTime loanDate, DateTime deliveryDate, bool isDelivered, bool status)
        {
            this.ClientId = clientId.ValidateProperty(IdentifierPropertyEnum.ClientId);
            this.BookId = bookId.ValidateProperty(IdentifierPropertyEnum.BookId);
            this.LoanDate = loanDate;
            this.DeliveryDate = deliveryDate;
            this.IsDelivered = isDelivered;
            this.Status = status;
        }

        /// <summary>Update Loan</summary>
        /// <param name="clientId">Client Identifier</param>
        /// <param name="bookId">Book Identifier</param>
        /// <param name="loanDate">Loan Date</param>
        /// <param name="deliveryDate">Delivery Date</param>
        /// <param name="isDelivered">Book Is Delivered</param>
        /// <param name="status">Loan Status</param>
        public void Update(int clientId, int bookId, DateTime loanDate, DateTime deliveryDate, bool isDelivered, bool status)
        {
            this.CreateAndValidate(clientId, bookId, loanDate, deliveryDate, isDelivered, status);
        }  
    }
}