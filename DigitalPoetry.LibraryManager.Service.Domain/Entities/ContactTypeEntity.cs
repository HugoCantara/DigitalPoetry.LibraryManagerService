namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>ContactType Entity</summary>
    public class ContactTypeEntity
    {
        /// <summary>Primary Key ContactType Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Description Property</summary>
        public string Description { get; private set; }

        /// <summary>Status Property</summary>
        public bool Status { get; private set; }

        /// <summary>ContactClientContactType Entity Collection</summary>
        public ICollection<ContactClientContactTypeEntity> ContactClientContactTypeCollection { get; set; }

        /// <summary>ContactAuthorContactType Entity Collection</summary>
        public ICollection<ContactAuthorContactTypeEntity> ContactAuthorContactTypeCollection { get; set; }

        /// <summary>ContactType Entity Constructor</summary>
        /// <param name="id">Primary Key ContactType Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public ContactTypeEntity(Guid id, string description, bool status)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactTypeId);
            this.CreateAndValidate(description, status);
        }

        /// <summary>ContactType Entity Constructor</summary>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public ContactTypeEntity(string description, bool status)
        {
            this.CreateAndValidate(description, status);
        }

        /// <summary>Create and Validate ContactType</summary>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void CreateAndValidate(string description, bool status)
        {
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.ContactTypeDescription, 50);
            this.Status = status;
        }

        /// <summary>Update ContactType</summary>
        /// <param name="description">Description Parameter</param>
        /// <param name="status">Status Parameter</param>
        public void Update(string description, bool status)
        {
            this.CreateAndValidate(description, status);
        }
    }
}