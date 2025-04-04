namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>Author Entity</summary>
    public class AuthorEntity : PersonEntity
    {
        /// <summary>Book Entity Collection</summary>
        public ICollection<BookEntity> BookCollection { get; set; }

        /// <summary>Contact Author Entity Collection</summary>
        public ICollection<ContactAuthorEntity> ContactAuthorCollection { get; set; }

        /// <summary>Author Entity Constructor</summary>
        /// <param name="id">Primary Key Author Identifier Parameter</param>
        /// <param name="addressId">Foreign Key Address Identifier Parameter</param>
        /// <param name="firstName">First Name Parameter</param>
        /// <param name="middleName">Middle Name Parameter</param>
        /// <param name="lastName">Last Name Parameter</param>
        /// <param name="status">Status Parameter</param>
        public AuthorEntity(Guid id, Guid addressId, string firstName, string middleName, string lastName, bool status)
            : base(id, addressId, firstName, middleName, lastName, status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.AuthorId);
            this.CreateAndValidate(addressId, firstName, middleName, lastName, status);
        }

        /// <summary>Author Entity Constructor</summary>
        /// <param name="addressId">Foreign Key Address Identifier Parameter</param>
        /// <param name="firstName">First Name Parameter</param>
        /// <param name="middleName">Middle Name Parameter</param>
        /// <param name="lastName">Last Name Parameter</param>
        /// <param name="status">Status Parameter</param>
        public AuthorEntity(Guid addressId, string firstName, string middleName, string lastName, bool status) 
            : base(addressId, firstName, middleName, lastName, status)
        {
            this.CreateAndValidate(addressId, firstName, middleName, lastName, status);
        }

        /// <summary>Create and Validate Author</summary>
        /// <param name="addressId">Foreign Key Address Identifier Parameter</param>
        /// <param name="firstName">First Name Parameter</param>
        /// <param name="middleName">Middle Name Parameter</param>
        /// <param name="lastName">Last Name Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid addressId, string firstName, string middleName, string lastName, bool status)
        {
            Guid idAddress = addressId.ValidateProperty(IdentifierPropertyEnum.AddressId);
            string authorFirstName = firstName.ValidateProperty(NamePropertyEnum.AuthorFirstName, 50);
            string authorMiddleName = middleName.ValidateProperty(NamePropertyEnum.AuthorMiddleName, 200);
            string authorLastName = lastName.ValidateProperty(NamePropertyEnum.AuthorLastName, 50);

            this.Create(idAddress, authorFirstName, authorMiddleName, authorLastName, status);
        }

        /// <summary>Update Author</summary>
        /// <param name="addressId">Foreign Key Address Identifier Parameter</param>
        /// <param name="firstName">First Name Parameter</param>
        /// <param name="middleName">Middle Name Parameter</param>
        /// <param name="lastName">Last Name Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid addressId, string firstName, string middleName, string lastName, bool status)
        {
            this.CreateAndValidate(addressId, firstName, middleName, lastName, status);
        }   
    }
}