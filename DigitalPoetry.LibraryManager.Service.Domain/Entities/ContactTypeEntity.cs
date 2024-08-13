namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Contact Type Entity</summary>
    public class ContactTypeEntity
    {
        /// <summary>Contact Type Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Contact Type Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.CONTACT_TYPE_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>Contact Type Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>Contact Client Contact Type Collection</summary>
        public ICollection<ContactClientContactTypeEntity> ContactClientContactTypeEntityCollection { get; set; }

        /// <summary>Contact Author Contact Type Collection</summary>
        public ICollection<ContactAuthorContactTypeEntity> ContactAuthorContactTypeEntityCollection { get; set; }

        /// <summary>Contact Type Entity Constructor</summary>
        /// <param name="id">Contact Type Identifier</param>
        /// <param name="description">Contact Type Description</param>
        /// <param name="status">Contact Type Status</param>
        public ContactTypeEntity(int id, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactTypeId);
            this.CreateAndValidate(description, status);
        }

        /// <summary>Contact Type Entity Constructor</summary>
        /// <param name="description">Contact Type Description</param>
        /// <param name="status">Contact Type Status</param>
        public ContactTypeEntity(string description, bool status)
        {
            this.CreateAndValidate(description, status);
        }

        /// <summary>Create and Validate Contact Type</summary>
        /// <param name="description">Contact Type Description</param>
        /// <param name="status">Contact Type Status</param>
        public void CreateAndValidate(string description, bool status)
        {
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.ContactTypeDescription, 50);
            this.Status = status;
        }

        /// <summary>Update Contact Type</summary>
        /// <param name="description">Contact Type Description</param>
        /// <param name="status">Contact Type Status</param>
        public void Update(string description, bool status)
        {
            this.CreateAndValidate(description, status);
        }
    }
}