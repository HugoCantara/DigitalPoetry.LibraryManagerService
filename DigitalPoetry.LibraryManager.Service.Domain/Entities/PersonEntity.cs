namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Person Entity</summary>
    public abstract class PersonEntity
    {
        /// <summary>Person Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; set; }

        /// <summary>Address Identifier</summary>
        [Required]
        [Column("AddressId")]
        public int AddressId { get; set; }

        /// <summary>Address Entity</summary>
        public AddressEntity Address { get; set; }

        /// <summary>Person First Name</summary>
        [Required]
        [StringLength(50)]
        [Column("FirstName")]
        public string FirstName { get; set; }

        /// <summary>Person Middle Name</summary>
        [Required]
        [StringLength(200)]
        [Column("MiddleName")]
        public string MiddleName { get; set; }

        /// <summary>Person Last Name</summary>
        [Required]
        [StringLength(50)]
        [Column("LastName")]
        public string LastName { get; set; }

        /// <summary>Person Full Name</summary>
        [Required]
        [Column("FullName")]
        public string FullName
        { 
            get 
            {
                return string.Concat(FirstName, " ", MiddleName, " ", LastName);
            } 
        }

        /// <summary>Person Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; set; }

        /// <summary>Person Entity Constructor</summary>
        /// <param name="id">Person Identifier</param>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Person First Name</param>
        /// <param name="middleName">Person Middle Name</param>
        /// <param name="lastName">Person Last Name</param>
        /// <param name="status">Person Status</param>
        public PersonEntity(int id, int addressId, string firstName, string middleName, string lastName, bool status)
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
        public PersonEntity(int addressId, string firstName, string middleName, string lastName, bool status)
        {
            this.Create(addressId, firstName, middleName, lastName, status);
        }

        /// <summary>Create Person</summary>
        /// <param name="addressId">Address Identifier</param>
        /// <param name="firstName">Person First Name</param>
        /// <param name="middleName">Person Middle Name</param>
        /// <param name="lastName">Person Last Name</param>
        /// <param name="status">Person Status</param>
        public void Create(int addressId, string firstName, string middleName, string lastName, bool status)
        {
            this.AddressId = addressId;
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Status = status;
        }
    }
}