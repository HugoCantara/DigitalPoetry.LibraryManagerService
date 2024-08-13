namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Client Entity</summary>
    public class ClientEntity : PersonEntity
    {
        /// <summary>Client Taxpayer Number</summary>
        [Required]
        [StringLength(9, ErrorMessage = EntityValidationConstants.CLIENT_TAXPAYER_NUMBER_LENGTH)]
        [Column("TaxpayerNumber")]
        public string TaxpayerNumber { get; private set; }

        /// <summary>Client Discriminator</summary>
        [Required]
        [Column("Discriminator")]
        public string Discriminator
        {
            get
            {
                return "Client";
            }
        }

        /// <summary>Loan Entity Collection</summary>
        public ICollection<LoanEntity> LoanEntityCollection { get; set; }

        /// <summary>Contact Client Entity Collection</summary>
        public ICollection<ContactClientEntity> ContactClientEntityCollection { get; set; }

        /// <summary>Client Entity Constructor</summary>
        /// <param name="id">Client Identifier</param>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="taxpayerNumber">Client Taxpayer Number</param>
        /// <param name="firstName">Client First Name</param>
        /// <param name="middleName">Client Middle Name</param>
        /// <param name="lastName">Client Last Name</param>
        /// <param name="status">Client Status</param>
        public ClientEntity(int id, int addressId, string taxpayerNumber, string firstName, string middleName, string lastName, bool status)
            : base(id, addressId, firstName, middleName, lastName, status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ClientId);
            this.CreateAndValidate(addressId, taxpayerNumber, firstName, middleName, lastName, status);
        }

        /// <summary>Client Entity Constructor</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="taxpayerNumber">Client Taxpayer Number</param>
        /// <param name="firstName">Client First Name</param>
        /// <param name="middleName">Client Middle Name</param>
        /// <param name="lastName">Client Last Name</param>
        /// <param name="status">Client Status</param>
        public ClientEntity(int addressId, string taxpayerNumber, string firstName, string middleName, string lastName, bool status) 
            : base(addressId, firstName, middleName, lastName, status)
        {
            this.CreateAndValidate(addressId, taxpayerNumber, firstName, middleName, lastName, status);
        }

        /// <summary>Validate Client</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="taxpayerNumber">Client Taxpayer Number</param>
        /// <param name="firstName">Client First Name</param>
        /// <param name="middleName">Client Middle Name</param>
        /// <param name="lastName">Client Last Name</param>
        /// <param name="status">Client Status</param>
        public void CreateAndValidate(int addressId, string taxpayerNumber, string firstName, string middleName, string lastName, bool status)
        {
            int idAddress = addressId.ValidateProperty(IdentifierPropertyEnum.AddressId);
            string clientFirstName = firstName.ValidateProperty(NamePropertyEnum.ClientFirstName, 50);
            string clientMiddleName = middleName.ValidateProperty(NamePropertyEnum.ClientMiddleName, 200);
            string clientLastName = lastName.ValidateProperty(NamePropertyEnum.ClientLastName, 50);

            this.TaxpayerNumber = taxpayerNumber.ValidateProperty(TaxpayerNumberPropertyEnum.TaxpayerNumber);
            this.Create(idAddress, clientFirstName, clientMiddleName, clientLastName, status);
        }

        /// <summary>Update Client</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="taxpayerNumber">Client Taxpayer Number</param>
        /// <param name="firstName">Client First Name</param>
        /// <param name="middleName">Client Middle Name</param>
        /// <param name="lastName">Client Last Name</param>
        /// <param name="status">Client Status</param>
        public void Update(int addressId, string taxpayerNumber, string firstName, string middleName, string lastName, bool status)
        {
            this.CreateAndValidate(addressId, taxpayerNumber, firstName, middleName, lastName, status);
        }
    }
}