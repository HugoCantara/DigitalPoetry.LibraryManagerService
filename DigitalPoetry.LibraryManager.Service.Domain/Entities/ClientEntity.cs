namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>Client Entity</summary>
    public class ClientEntity : PersonEntity
    {
        /// <summary>TaxpayerNumber Property</summary>
        public string TaxpayerNumber { get; private set; }

        /// <summary>Loan Entity Collection</summary>
        public ICollection<LoanEntity> LoanCollection { get; set; }

        /// <summary>ContactClient Entity Collection</summary>
        public ICollection<ContactClientEntity> ContactClientCollection { get; set; }

        /// <summary>Client Entity Constructor</summary>
        /// <param name="id">Primary Key Client Identifier Parameter</param>
        /// <param name="addressId">Foreign Key Address Identifier Parameter</param>
        /// <param name="taxpayerNumber">Taxpayer Number Parameter</param>
        /// <param name="firstName">First Name Parameter</param>
        /// <param name="middleName">Middle Name Parameter</param>
        /// <param name="lastName">Last Name Parameter</param>
        /// <param name="status">Status Parameter</param>
        public ClientEntity(Guid id, Guid addressId, string taxpayerNumber, string firstName, string middleName, string lastName, bool status)
            : base(id, addressId, firstName, middleName, lastName, status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ClientId);
            this.CreateAndValidate(addressId, taxpayerNumber, firstName, middleName, lastName, status);
        }

        /// <summary>Client Entity Constructor</summary>
        /// <param name="addressId">Foreign Key Address Identifier Parameter</param>
        /// <param name="taxpayerNumber">Taxpayer Number Parameter</param>
        /// <param name="firstName">First Name Parameter</param>
        /// <param name="middleName">Middle Name Parameter</param>
        /// <param name="lastName">Last Name Parameter</param>
        /// <param name="status">Status Parameter</param>
        public ClientEntity(Guid addressId, string taxpayerNumber, string firstName, string middleName, string lastName, bool status) 
            : base(addressId, firstName, middleName, lastName, status)
        {
            this.CreateAndValidate(addressId, taxpayerNumber, firstName, middleName, lastName, status);
        }

        /// <summary>Create and Validate Client</summary>
        /// <param name="addressId">Foreign Key Address Identifier Parameter</param>
        /// <param name="taxpayerNumber">Taxpayer Number Parameter</param>
        /// <param name="firstName">First Name Parameter</param>
        /// <param name="middleName">Middle Name Parameter</param>
        /// <param name="lastName">Last Name Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid addressId, string taxpayerNumber, string firstName, string middleName, string lastName, bool status)
        {
            Guid idAddress = addressId.ValidateProperty(IdentifierPropertyEnum.AddressId);
            string clientFirstName = firstName.ValidateProperty(NamePropertyEnum.ClientFirstName, 50);
            string clientMiddleName = middleName.ValidateProperty(NamePropertyEnum.ClientMiddleName, 200);
            string clientLastName = lastName.ValidateProperty(NamePropertyEnum.ClientLastName, 50);

            this.TaxpayerNumber = taxpayerNumber.ValidateProperty(TaxpayerNumberPropertyEnum.TaxpayerNumber);
            this.Create(idAddress, clientFirstName, clientMiddleName, clientLastName, status);
        }

        /// <summary>Update Client</summary>
        /// <param name="addressId">Foreign Key Address Identifier Parameter</param>
        /// <param name="taxpayerNumber">Taxpayer Number Parameter</param>
        /// <param name="firstName">First Name Parameter</param>
        /// <param name="middleName">Middle Name Parameter</param>
        /// <param name="lastName">Last Name Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid addressId, string taxpayerNumber, string firstName, string middleName, string lastName, bool status)
        {
            this.CreateAndValidate(addressId, taxpayerNumber, firstName, middleName, lastName, status);
        }
    }
}