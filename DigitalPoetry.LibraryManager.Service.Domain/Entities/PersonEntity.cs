using System.ComponentModel.DataAnnotations.Schema;

namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    /// <summary>Person Entity</summary>
    public abstract class PersonEntity
    {
        /// <summary>Person Identifier</summary>
        public Guid Id { get; set; }

        /// <summary>Address Identifier</summary>
        public Guid AddressId { get; set; }

        /// <summary>Address Entity</summary>
        public AddressEntity Address { get; set; }

        /// <summary>Person First Name</summary>
        public string FirstName { get; set; }

        /// <summary>Person Middle Name</summary>
        public string MiddleName { get; set; }

        /// <summary>Person Last Name</summary>
        public string LastName { get; set; }

        /// <summary>Person Full Name</summary>
        [NotMapped]
        public string FullName
        { 
            get 
            {
                return string.Concat(FirstName, " ", MiddleName, " ", LastName);
            } 
        }

        /// <summary>Person Status</summary>
        public bool Status { get; set; }

        /// <summary>Person Entity Constructor</summary>
        /// <param name="id">Person Identifier</param>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Person First Name</param>
        /// <param name="middleName">Person Middle Name</param>
        /// <param name="lastName">Person Last Name</param>
        /// <param name="status">Person Status</param>
        public PersonEntity(Guid id, Guid addressId, string firstName, string middleName, string lastName, bool status)
        {
            this.Id = id;
            this.Create(addressId, firstName, middleName, lastName, status);
        }

        /// <summary>Person Entity Constructor</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Person First Name</param>
        /// <param name="middleName">Person Middle Name</param>
        /// <param name="lastName">Person Last Name</param>
        /// <param name="status">Person Status</param>
        public PersonEntity(Guid addressId, string firstName, string middleName, string lastName, bool status)
        {
            this.Create(addressId, firstName, middleName, lastName, status);
        }

        /// <summary>Create Person</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Person First Name</param>
        /// <param name="middleName">Person Middle Name</param>
        /// <param name="lastName">Person Last Name</param>
        /// <param name="status">Person Status</param>
        public void Create(Guid addressId, string firstName, string middleName, string lastName, bool status)
        {
            this.AddressId = addressId;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Status = status;
        }
    }
}