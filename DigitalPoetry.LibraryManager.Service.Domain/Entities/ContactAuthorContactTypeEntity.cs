namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Contact Author Contact Type Entity</summary>
    public class ContactAuthorContactTypeEntity
    {
        /// <summary>Contact Author Contact Type Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Contact Author Identifier</summary>
        [Required]
        [Column("ContactAuthorId")]
        public int ContactAuthorId { get; private set; }

        /// <summary>Contact Author Entity</summary>
        public ContactAuthorEntity ContactAuthor { get; set; }

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

        /// <summary>Contact Author Status</summary>
        [Required]
        [Column("Status")]
        public bool Status { get; private set; }

        /// <summary>Contact Author Contact Type Entity Constructor</summary>
        /// <param name="id">Contact Author Contact Type Identifier</param>
        /// <param name="contactAuthorId">Contact Author Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public ContactAuthorContactTypeEntity(int id, int contactAuthorId, int contactTypeId, bool isPrincipalContact, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactAuthorContactTypeId);
            this.CreateAndValidate(contactAuthorId, contactTypeId, isPrincipalContact, status);
        }

        /// <summary>Contact Author Contact Type Entity Constructor</summary>
        /// <param name="contactAuthorId">Contact Author Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public ContactAuthorContactTypeEntity(int contactAuthorId, int contactTypeId, bool isPrincipalContact, bool status)
        {
            this.CreateAndValidate(contactAuthorId, contactTypeId, isPrincipalContact, status);
        }

        /// <summary>Create and Validate Contact Author Contact Type</summary>
        /// <param name="contactAuthorId">Contact Author Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public void CreateAndValidate(int contactAuthorId, int contactTypeId, bool isPrincipalContact, bool status)
        {
            this.ContactAuthorId = contactAuthorId.ValidateProperty(IdentifierPropertyEnum.ContactAuthorId);
            this.ContactTypeId = contactTypeId.ValidateProperty(IdentifierPropertyEnum.ContactTypeId);
            this.IsPrincipalContact = isPrincipalContact;
            this.Status = status;
        }

        /// <summary>Update Contact Author Contact Type</summary>
        /// <param name="contactAuthorId">Contact Author Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public void Update(int contactAuthorId, int contactTypeId, bool isPrincipalContact, bool status)
        {
            this.CreateAndValidate(contactAuthorId, contactTypeId, isPrincipalContact, status);
        }
    }
}