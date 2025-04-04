namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;

    /// <summary>ContactAuthor Entity</summary>
    public class ContactAuthorEntity
    {
        /// <summary>Primary Key ContactAuthor Identifier Property</summary>
        public Guid Id { get; private set; }

        /// <summary>Foreign Key Author Identifier Property</summary>
        public Guid AuthorId { get; private set; }

        /// <summary>Author Entity</summary>
        public AuthorEntity Author { get; set; }

        /// <summary>Description Property</summary>
        public string Description { get; private set; }

        /// <summary>ContactAuthorContactType Entity Collection</summary>
        public ICollection<ContactAuthorContactTypeEntity> ContactAuthorContactTypeCollection { get; set; }

        /// <summary>ContactAuthor Entity Constructor</summary>
        /// <param name="id">Primary Key ContactAuthor Identifier Parameter</param>
        /// <param name="authorId">Foreign Key Author Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        public ContactAuthorEntity(Guid id, Guid authorId, string description)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactAuthorId);
            this.CreateAndValidate(authorId, description);
        }

        /// <summary>ContactAuthor Entity Constructor</summary>
        /// <param name="authorId">Foreign Key Author Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        public ContactAuthorEntity(Guid authorId, string description)
        {
            this.CreateAndValidate(authorId, description);
        }

        /// <summary>Create and Validate ContactAuthor</summary>
        /// <param name="authorId">Foreign Key Author Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        public void CreateAndValidate(Guid authorId, string description)
        {
            this.AuthorId = authorId.ValidateProperty(IdentifierPropertyEnum.AuthorId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.ContactAuthorDescription, 50);
        }

        /// <summary>Update ContactAuthor</summary>
        /// <param name="authorId">Foreign Key Author Identifier Parameter</param>
        /// <param name="description">Description Parameter</param>
        public void Update(Guid authorId, string description)
        {
            this.CreateAndValidate(authorId, description);
        }
    }
}