namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Contact Client Contact Type Entity</summary>
    public class ContactClientContactTypeEntity
    {
        /// <summary>Contact Client Contact Type Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Contact Client Identifier</summary>
        [Required]
        [Column("ContactClientId")]
        public int ContactClientId { get; private set; }

        /// <summary>Contact Client Entity</summary>
        public ContactClientEntity ContactClient { get; set; }

        /// <summary>Contact Type Identifier</summary>
        [Required]
        [Column("ContactTypeId")]
        public int ContactTypeId { get; private set; }

        /// <summary>Contact Type Entity</summary>
        public ContactTypeEntity ContactType { get; set; }

        /// <summary>Is Principal Contact</summary>
        [Required]
        [Column("IsPrincipalContact")]
        public bool IsPrincipalContact { get; private set; }

        /// <summary>Contact Client Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>Contact Client Contact Type Entity Constructor</summary>
        /// <param name="id">Contact Client Contact Type Identifier</param>
        /// <param name="contactClientId">Contact Client Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public ContactClientContactTypeEntity(int id, int contactClientId, int contactTypeId, bool isPrincipalContact, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactClientContactTypeId);
            this.CreateAndValidate(contactClientId, contactTypeId, isPrincipalContact, status);
        }

        /// <summary>Contact Client Contact Type Entity Constructor</summary>
        /// <param name="contactClientId">Contact Client Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public ContactClientContactTypeEntity(int contactClientId, int contactTypeId, bool isPrincipalContact, bool status)
        {
            this.CreateAndValidate(contactClientId, contactTypeId, isPrincipalContact, status);
        }

        /// <summary>Create and Validate Contact Client Contact Type</summary>
        /// <param name="contactClientId">Contact Client Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public void CreateAndValidate(int contactClientId, int contactTypeId, bool isPrincipalContact, bool status)
        {
            this.ContactClientId = contactClientId.ValidateProperty(IdentifierPropertyEnum.ContactClientId);
            this.ContactTypeId = contactTypeId.ValidateProperty(IdentifierPropertyEnum.ContactTypeId);
            this.IsPrincipalContact = isPrincipalContact;
            this.Status = status;
        }

        /// <summary>Update Contact Client Contact Type</summary>
        /// <param name="contactClientId">Contact Client Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public void Update(int contactClientId, int contactTypeId, bool isPrincipalContact, bool status)
        {
            this.CreateAndValidate(contactClientId, contactTypeId, isPrincipalContact, status);
        }       
    }
}