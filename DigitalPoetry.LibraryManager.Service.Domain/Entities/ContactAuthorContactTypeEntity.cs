namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>ContactAuthorContactType Entity</summary>
    public class ContactAuthorContactTypeEntity
    {
        /// <summary>Primary Key ContactAuthorContactType Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Key ContactAuthor Identifier Property</summary>
        public Guid ContactAuthorId { get; private set; }

        /// <summary>ContactAuthor Entity</summary>
        public ContactAuthorEntity ContactAuthor { get; set; }

        /// <summary>Foreign Key ContactType Identifier Property</summary>
        public Guid ContactTypeId { get; private set; }

        /// <summary>ContactType Entity</summary>
        public ContactTypeEntity ContactType { get; set; }

        /// <summary>IsPrincipalContact Property</summary>
        public bool IsPrincipalContact { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>Contact Author Contact Type Entity Constructor</summary>
        /// <param name="id">Contact Author Contact Type Identifier</param>
        /// <param name="contactAuthorId">Contact Author Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public ContactAuthorContactTypeEntity(Guid id, Guid contactAuthorId, Guid contactTypeId, bool isPrincipalContact, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactAuthorContactTypeId);
            this.CreateAndValidate(contactAuthorId, contactTypeId, isPrincipalContact, status);
        }

        /// <summary>Contact Author Contact Type Entity Constructor</summary>
        /// <param name="contactAuthorId">Contact Author Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public ContactAuthorContactTypeEntity(Guid contactAuthorId, Guid contactTypeId, bool isPrincipalContact, bool status)
        {
            this.CreateAndValidate(contactAuthorId, contactTypeId, isPrincipalContact, status);
        }

        /// <summary>Create and Validate Contact Author Contact Type</summary>
        /// <param name="contactAuthorId">Contact Author Identifier</param>
        /// <param name="contactTypeId">Contact Type Identifier</param>
        /// <param name="isPrincipalContact">Is Principal Contact</param>
        /// <param name="status">Status</param>
        public void CreateAndValidate(Guid contactAuthorId, Guid contactTypeId, bool isPrincipalContact, bool status)
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
        public void Update(Guid contactAuthorId, Guid contactTypeId, bool isPrincipalContact, bool status)
        {
            this.CreateAndValidate(contactAuthorId, contactTypeId, isPrincipalContact, status);
        }
    }
}