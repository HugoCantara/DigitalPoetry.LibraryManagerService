namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>Loan Entity</summary>
    public class LoanEntity
    {
        /// <summary>Primary Key Loan Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Key Client Identifier Property</summary>
        public Guid ClientId { get; private set; }

        /// <summary>Client Entity</summary>
        public ClientEntity Client { get; set; }

        /// <summary>Foreign Key Book Identifier Property</summary>
        public Guid BookId { get; private set; }

        /// <summary>Book Entity</summary>
        public BookEntity Book { get; set; }

        /// <summary>LoanDate Property</summary>
        public DateTime LoanDate { get; private set; }

        /// <summary>DeliveryDate Property</summary>
        public DateTime DeliveryDate { get; private set; }

        /// <summary>IsDelivered Property</summary>
        public bool IsDelivered { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>Loan Entity Constructor</summary>
        /// <param name="id">Primary Key Loan Identifier Parameter</param>
        /// <param name="clientId">Foreign Key Client Identifier Parameter</param>
        /// <param name="bookId">Foreign Key Book Identifier Parameter</param>
        /// <param name="loanDate">LoanDate Parameter</param>
        /// <param name="deliveryDate">DeliveryDate Parameter</param>
        /// <param name="isDelivered">IsDelivered Parameter</param>
        /// <param name="status">Status Parameter</param>
        public LoanEntity(Guid id, Guid clientId, Guid bookId, DateTime loanDate, DateTime deliveryDate, bool isDelivered, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.LoanId);
            this.CreateAndValidate(clientId, bookId, loanDate, deliveryDate, isDelivered, status);
        }

        /// <summary>Loan Entity Constructor</summary>
        /// <param name="clientId">Foreign Key Client Identifier Parameter</param>
        /// <param name="bookId">Foreign Key Book Identifier Parameter</param>
        /// <param name="loanDate">LoanDate Parameter</param>
        /// <param name="deliveryDate">DeliveryDate Parameter</param>
        /// <param name="isDelivered">IsDelivered Parameter</param>
        /// <param name="status">Status Parameter</param>
        public LoanEntity(Guid clientId, Guid bookId, DateTime loanDate, DateTime deliveryDate, bool isDelivered, bool status)
        {
            this.CreateAndValidate(clientId, bookId, loanDate, deliveryDate, isDelivered, status);
        }

        /// <summary>Create and Validate Loan</summary>
        /// <param name="clientId">Foreign Key Client Identifier Parameter</param>
        /// <param name="bookId">Foreign Key Book Identifier Parameter</param>
        /// <param name="loanDate">LoanDate Parameter</param>
        /// <param name="deliveryDate">DeliveryDate Parameter</param>
        /// <param name="isDelivered">IsDelivered Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid clientId, Guid bookId, DateTime loanDate, DateTime deliveryDate, bool isDelivered, bool status)
        {
            this.ClientId = clientId.ValidateProperty(IdentifierPropertyEnum.ClientId);
            this.BookId = bookId.ValidateProperty(IdentifierPropertyEnum.BookId);
            this.LoanDate = loanDate;
            this.DeliveryDate = deliveryDate;
            this.IsDelivered = isDelivered;
            this.Status = status;
        }

        /// <summary>Update Loan</summary>
        /// <param name="clientId">Foreign Key Client Identifier Parameter</param>
        /// <param name="bookId">Foreign Key Book Identifier Parameter</param>
        /// <param name="loanDate">LoanDate Parameter</param>
        /// <param name="deliveryDate">DeliveryDate Parameter</param>
        /// <param name="isDelivered">IsDelivered Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid clientId, Guid bookId, DateTime loanDate, DateTime deliveryDate, bool isDelivered, bool status)
        {
            this.CreateAndValidate(clientId, bookId, loanDate, deliveryDate, isDelivered, status);
        }  
    }
}