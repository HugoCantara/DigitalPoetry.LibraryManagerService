namespace DigitalPoetry.LibraryManager.Service.Domain.Entities
{
    using DigitalPoetry.LibraryManager.Service.Domain.Constants;
    using DigitalPoetry.LibraryManager.Service.Domain.Enumerables;
    using DigitalPoetry.LibraryManager.Service.Domain.Extensions;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>Contact Author Entity</summary>
    public class ContactAuthorEntity
    {
        /// <summary>Contact Author Identifier</summary>
        [Required]
        [Column("Id")]
        public int Id { get; private set; }

        /// <summary>Author Identifier</summary>
        [Required]
        [Column("AuthorId")]
        public int AuthorId { get; private set; }

        /// <summary>Author Entity</summary>
        public AuthorEntity Author { get; set; }

        /// <summary>Contact Author Description</summary>
        [Required]
        [StringLength(50, ErrorMessage = EntityValidationConstants.CONTACT_AUTHOR_DESCRIPTION_LENGTH)]
        [Column("Description")]
        public string Description { get; private set; }

        /// <summary>Contact Author Contact Type Collection</summary>
        public ICollection<ContactAuthorContactTypeEntity> ContactAuthorContactTypeCollection { get; set; }

        /// <summary>Contact Author Entity Constructor</summary>
        /// <param name="id">Contact Author Identifier</param>
        /// <param name="authorId">Author Identifier</param>
        /// <param name="description">Contact Author Description</param>
        public ContactAuthorEntity(int id, int authorId, string description)
        {
            this.Id = id.ValidateProperty(IdentifierPropertyEnum.ContactAuthorId);
            this.CreateAndValidate(authorId, description);
        }

        /// <summary>Contact Author Entity Constructor</summary>
        /// <param name="authorId">Author Identifier</param>
        /// <param name="description">Contact Author Description</param>
        public ContactAuthorEntity(int authorId, string description)
        {
            this.CreateAndValidate(authorId, description);
        }

        /// <summary>Create and Validate Contact Author</summary>
        /// <param name="authorId">Author Identifier</param>
        /// <param name="description">Contact Author Description</param>
        public void CreateAndValidate(int authorId, string description)
        {
            this.AuthorId = authorId.ValidateProperty(IdentifierPropertyEnum.AuthorId);
            this.Description = description.ValidateProperty(DescriptionPropertyEnum.ContactAuthorDescription, 50);
        }

        /// <summary>Update Contact Author</summary>
        /// <param name="authorId">Author Identifier</param>
        /// <param name="description">Contact Author Description</param>
        public void Update(int authorId, string description)
        {
            this.CreateAndValidate(authorId, description);
        }
    }
}