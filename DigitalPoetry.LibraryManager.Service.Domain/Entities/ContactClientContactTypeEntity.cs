namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>ContactClientContactType Entity</summary>
    public class ContactClientContactTypeEntity
    {
        /// <summary>Primary Key ContactClientContactType Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Key ContactClient Identifier Property</summary>
        public Guid ContactClientId { get; private set; }

        /// <summary>ContactClient Entity</summary>
        public ContactClientEntity ContactClient { get; set; }

        /// <summary>Foreign Key ContactType Identifier Property</summary>
        public Guid ContactTypeId { get; private set; }

        /// <summary>ContactType Entity</summary>
        public ContactTypeEntity ContactType { get; set; }

        /// <summary>IsPrincipalContact Property</summary>
        public bool IsPrincipalContact { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>ContactClientContactType Entity Constructor</summary>
        /// <param name="id">ContactClientContactType Identifier Parameter</param>
        /// <param name="contactClientId">ContactClient Identifier Parameter</param>
        /// <param name="contactTypeId">ContactType Identifier Parameter</param>
        /// <param name="isPrincipalContact">IsPrincipalContact Parameter</param>
        /// <param name="status">Status Parameter</param>
        public ContactClientContactTypeEntity(Guid id, Guid contactClientId, Guid contactTypeId, bool isPrincipalContact, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactClientContactTypeId);
            this.CreateAndValidate(contactClientId, contactTypeId, isPrincipalContact, status);
        }

        /// <summary>ContactClientContactType Entity Constructor</summary>
        /// <param name="contactClientId">ContactClient Identifier Parameter</param>
        /// <param name="contactTypeId">ContactType Identifier Parameter</param>
        /// <param name="isPrincipalContact">IsPrincipalContact Parameter</param>
        /// <param name="status">Status Parameter</param>
        public ContactClientContactTypeEntity(Guid contactClientId, Guid contactTypeId, bool isPrincipalContact, bool status)
        {
            this.CreateAndValidate(contactClientId, contactTypeId, isPrincipalContact, status);
        }

        /// <summary>Create and Validate ContactClientContactType</summary>
        /// <param name="contactClientId">ContactClient Identifier Parameter</param>
        /// <param name="contactTypeId">ContactType Identifier Parameter</param>
        /// <param name="isPrincipalContact">IsPrincipalContact Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(Guid contactClientId, Guid contactTypeId, bool isPrincipalContact, bool status)
        {
            this.ContactClientId = contactClientId.ValidateProperty(IdentifierPropertyEnum.ContactClientId);
            this.ContactTypeId = contactTypeId.ValidateProperty(IdentifierPropertyEnum.ContactTypeId);
            this.IsPrincipalContact = isPrincipalContact;
            this.Status = status;
        }

        /// <summary>Update ContactClientContactType</summary>
        /// <param name="contactClientId">ContactClient Identifier Parameter</param>
        /// <param name="contactTypeId">ContactType Identifier Parameter</param>
        /// <param name="isPrincipalContact">IsPrincipalContact Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(Guid contactClientId, Guid contactTypeId, bool isPrincipalContact, bool status)
        {
            this.CreateAndValidate(contactClientId, contactTypeId, isPrincipalContact, status);
        }       
    }
}