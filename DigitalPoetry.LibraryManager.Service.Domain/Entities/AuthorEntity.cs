namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Author Entity</summary>
    public class AuthorEntity : PersonEntity
    {
        /// <summary>Author Discriminator</summary>
        [Required]
        [Column("Discriminator")]
        public string Discriminator 
        {
            get 
            {
                return "Author";
            }
        }

        /// <summary>Contact Author Entity Collection</summary>
        public ICollection<ContactAuthorEntity> ContactAuthorEntityCollection { get; set; }

        /// <summary>Author Entity Constructor</summary>
        /// <param name="id">Author Identifier</param>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Author First Name</param>
        /// <param name="middleName">Author Middle Name</param>
        /// <param name="lastName">Author Last Name</param>
        /// <param name="status">Author Status</param>
        public AuthorEntity(int id, int addressId, string firstName, string middleName, string lastName, bool status)
            : base(id, addressId, firstName, middleName, lastName, status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.AuthorId);
            this.CreateAndValidate(addressId, firstName, middleName, lastName, status);
        }

        /// <summary>Author Entity Constructor</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Author First Name</param>
        /// <param name="middleName">Author Middle Name</param>
        /// <param name="lastName">Author Last Name</param>
        /// <param name="status">Author Status</param>
        public AuthorEntity(int addressId, string firstName, string middleName, string lastName, bool status) 
            : base(addressId, firstName, middleName, lastName, status)
        {
            this.CreateAndValidate(addressId, firstName, middleName, lastName, status);
        }

        /// <summary>Create and Validate Author</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Author First Name</param>
        /// <param name="middleName">Author Middle Name</param>
        /// <param name="lastName">Author Last Name</param>
        /// <param name="status">Author Status</param>
        public void CreateAndValidate(int addressId, string firstName, string middleName, string lastName, bool status)
        {
            int idAddress = addressId.ValidateProperty(IdentifierPropertyEnum.AddressId);
            string authorFirstName = firstName.ValidateProperty(NamePropertyEnum.AuthorFirstName, 50);
            string authorMiddleName = middleName.ValidateProperty(NamePropertyEnum.AuthorMiddleName, 200);
            string authorLastName = lastName.ValidateProperty(NamePropertyEnum.AuthorLastName, 50);

            this.Create(idAddress, authorFirstName, authorMiddleName, authorLastName, status);
        }

        /// <summary>Update Author</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Author First Name</param>
        /// <param name="middleName">Author Middle Name</param>
        /// <param name="lastName">Author Last Name</param>
        /// <param name="status">Author Status</param>
        public void Update(int addressId, string firstName, string middleName, string lastName, bool status)
        {
            this.CreateAndValidate(addressId, firstName, middleName, lastName, status);
        }   
    }
}